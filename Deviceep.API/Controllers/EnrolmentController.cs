using AutoMapper;
using Deviceep.API.DTOs;
using Deviceep.Core.Services;
using Deviceep.Entity.AdditionalModels;
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
    public class EnrolmentController : Controller
    {
        // Definition of variables for Dependency Injection
        private readonly IAttendanceHourService _attendanceHourService;
        private readonly IEnrollmentService _enrollmentService;
        private readonly IMapper _mapper;
        private readonly ILogger<EnrolmentController> _logger;

        // Constructor for the class
        // Initiating the dependency injection

        public EnrolmentController(IAttendanceHourService attendanceHourService, IMapper mapper, ILogger<EnrolmentController> logger, IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
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
                var attendanceHour = await _enrollmentService.GetPagedList(requestParams, null);
                var results = _mapper.Map<IList<EnrollmentDTO>>(attendanceHour);
                return Ok(results);
            }
            catch (Exception ex)
            {

                _logger.LogError($"Something went wrong in the {nameof(GetattendanceHours)}", ex);
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
