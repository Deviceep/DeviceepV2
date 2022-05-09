using AutoMapper;
using Deviceep.API.DTOs;
using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Entity.AdditionalModels;
using Deviceep.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deviceep.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceHourController : ControllerBase
    {
        // Definition of variables for Dependency Injection
        private readonly IAttendanceHourService _attendanceHourService;
        private readonly IMapper _mapper;
        private readonly ILogger<AttendanceHourController> _logger;

        // Constructor for the class
        // Initiating the dependency injection

        public AttendanceHourController(IAttendanceHourService attendanceHourService, IMapper mapper, ILogger<AttendanceHourController> logger)
        {
            _attendanceHourService = attendanceHourService;
            _mapper = mapper;
            _logger = logger;

        }


        [HttpGet]
        // Gets all the Attendances
        // It uses PagedList feature to not boggle the database
        public async Task<IActionResult> GetattendanceHours([FromQuery] RequestParams requestParams)
        {
            try
            {
                var attendanceHour = await _attendanceHourService.GetPagedList(requestParams, null);
                var results = _mapper.Map<IList<AttendanceHourDTO>>(attendanceHour);
                return Ok(results);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Something went wrong in the {nameof(GetattendanceHours)}", ex);
                return StatusCode(500, "Internal Server Error");
            }
        }



        [HttpGet("{id:int}", Name = "GetAttendancyHour")]
        //[ResponseCache(CacheProfileName = "120SecondsDuration")]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Gets attendance hour specified by id
        public async Task<IActionResult> GetAttendancyHour(int id)
        {
            var attendanceHour = await _attendanceHourService.GetByIdAsync(id);
            var result = _mapper.Map<AttendanceHourDTO>(attendanceHour);
            return Ok(result);
        }
        // Controls if the user has the right verifications to use this function
        // Checks the role as well
        //[Authorize(Roles = "Administrator")]

        [HttpPost]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Creates a new AttendanceHour taken information by the body
        public async Task<IActionResult> CreateAttendanceHour([FromBody] CreateAttendanceHourDTO createAttendanceHourDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateAttendanceHour)}");
                return BadRequest(ModelState);
            }
            var attendance = _mapper.Map<AttendanceHour>(createAttendanceHourDTO);
            await _attendanceHourService.AddAsync(attendance);

            return CreatedAtRoute("GetCourse", new { id = attendance.Id }, attendance);
        }
        // Controls if the user has the right verifications to use this function
        //[Authorize]
        [HttpPut("{id:int}")]
        // Possible Responses from the function
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAttendanceHour(int id, [FromBody] UpdateAttendanceHourDTO updateAttendanceHourDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateAttendanceHour)}");
                return BadRequest(ModelState);
            }
            var attendanceHourId = await _attendanceHourService.GetByIdAsync(id);

            if (attendanceHourId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateAttendanceHour)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(updateAttendanceHourDTO, attendanceHourId);
            _attendanceHourService.Update(attendanceHourId);
            return NoContent();

        }
        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveAttendanceyHour(int id)
        {
            await _attendanceHourService.Remove(id);
            return NoContent();
        }
    }
}
