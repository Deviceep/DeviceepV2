using AutoMapper;
using Deviceep.API.DTOs;
using Deviceep.Core.Services;
using Deviceep.Entity.AdditionalModels;
using Deviceep.Entity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Deviceep.API.IoTFunctions;

namespace Deviceep.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        // Definition of variables for Dependency Injection
        private readonly IAttendanceService _attendanceService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly ICourseService _courseService;
        private readonly IEnrollmentService _enrollmentService;
        private readonly ILogger<AttendanceController> _logger;


        // Constructor for the class
        // Initiating the dependency injection
        public AttendanceController(IAttendanceService attendanceService, IMapper mapper, ILogger<AttendanceController> logger,
            IUserService userService, ICourseService courseService, IEnrollmentService enrollmentService)
        {
            _courseService = courseService;
            _userService = userService;
            _attendanceService = attendanceService;
            _enrollmentService = enrollmentService;
            _mapper = mapper;
            _logger = logger;

        }


        [HttpGet(Name = "GetAttendances")]
        // Gets all the Attendances
        // It uses PagedList feature to not boggle the database
        public async Task<IActionResult> GetAttendances([FromQuery] RequestParams requestParams)
        {
            try
            {
                var attendances = await _attendanceService.GetPagedList(requestParams, null);
                var results = _mapper.Map<IList<AttendanceDTO>>(attendances);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAttendances)}", ex);
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpGet("{id:int}", Name = "GetAttendance")]
        [ResponseCache(CacheProfileName = "120SecondsDuration")]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Gets a specific Attendance according to the id it has been given
        public async Task<IActionResult> GetAttendance(int id)
        {
            var attendance = await _attendanceService.GetByIdAsync(id);
            var result = _mapper.Map<AttendanceDTO>(attendance);
            return Ok(result);
        }



        

        [HttpPost]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAttendance(/*[FromBody] CreateAttendanceDTO createAttendanceDTO*/ string StudentID, int CourseID)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateAttendance)}");
                return BadRequest(ModelState);
            }
            var isValidStudent = _userService.IsFieldValueUnique(StudentID);
            
            
            
            
            

            bool isValidCourse = _courseService.IsFieldValueUnique(CourseID);
            bool isValidEnrollment = await _enrollmentService.IsFieldValueUnique(StudentID,CourseID);
            
            //var isValidHour = false;
            var isValidAttendance = await _attendanceService.IsAttendanceExists(StudentID,CourseID);
            
            

            if (isValidStudent )
            {
                if (isValidCourse)
                {
                    if (isValidEnrollment )
                    {
                        if (!isValidAttendance)
                        {
                            
                                var model = new CreateAttendanceDTO { CourseId = CourseID, UserID = StudentID, AttendanceDate = DateTime.Now };
                                var CreateAttendance = _mapper.Map<Attendance>(model);
                                                           await _attendanceService.AddAsync(CreateAttendance);
                                                            return Ok("");
                          
                        }
                        else return BadRequest("You Have Attendance");
                    }
                    else return BadRequest("Student is not Enrolled in this Course!");
                }
                else return BadRequest("No Such Lesson!");
                
            }
            else { return BadRequest("No Student"); }
           
            
        }

        [Route("RfidAttendance")]
        [HttpPost]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAttendanceRfid(/*[FromBody] CreateAttendanceDTO createAttendanceDTO*/  int CourseID, string rfid)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateAttendance)}");
                return BadRequest(ModelState);
            }
            
            var isValidRfid = await _userService.GetWithAttendancetsByIdAsync(rfid);

            if (isValidRfid == null)
            {
                return BadRequest("No such student");
            }
                var isValidRfidAStudent = _userService.IsFieldValueUnique(isValidRfid.Id);
            
            bool isValidEnrollmentRfid = await _enrollmentService.IsFieldValueUnique(isValidRfid.Id, CourseID);

            bool isValidCourse = _courseService.IsFieldValueUnique(CourseID);

            //var isValidHour = false;
            var isValidAttendance = await _attendanceService.IsAttendanceExists(isValidRfid.Id, CourseID);



            if (isValidRfidAStudent)
            {
                if (isValidCourse)
                {
                    if ( isValidEnrollmentRfid)
                    {
                        if (!isValidAttendance)
                        {
                            
                                var model = new CreateAttendanceDTO { CourseId = CourseID, UserID = isValidRfid.Id, AttendanceDate = DateTime.Now };
                                var CreateAttendance = _mapper.Map<Attendance>(model);
                                await _attendanceService.AddAsync(CreateAttendance);
                                return Ok("");
                           
                        }
                        else return BadRequest("You Have Attendance");
                    }
                    else return BadRequest("Student is not Enrolled in this Course!");
                }
                else return BadRequest("No Such Lesson!");

            }
            else { return BadRequest("No Student"); }


        }
        // Controls if the user has the right verifications to use this function
        [Authorize]
        [HttpPut("{id:int}")]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Takes the identified row and lets you to chgange its content
        public async Task<IActionResult> UpdateAttendance(int id, [FromBody] UpdateAttendanceDTO updateAttendanceDTO )
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateAttendance)}");
                return BadRequest(ModelState);
            }
            var attendanceId = await _attendanceService.GetByIdAsync(id);

            if (attendanceId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateAttendance)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(updateAttendanceDTO, attendanceId);
            _attendanceService.Update(attendanceId);
            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        // Removes the specified row defined by id
        public async Task<IActionResult> RemoveAttendancey(int id)
        {
            await _attendanceService.Remove(id);
            return NoContent();
        }

    }
}
