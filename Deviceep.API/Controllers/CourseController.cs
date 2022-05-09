using AutoMapper;
using Deviceep.API.DTOs;
using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Entity.AdditionalModels;
using Deviceep.Entity.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ICourseService courseService, IMapper mapper, ILogger<CourseController> logger)
        {
            _courseService = courseService;
            _mapper = mapper;
            _logger = logger;

        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCourses([FromQuery] RequestParams requestParams)
        {
            var courses = await _courseService.GetPagedList(requestParams);
            var results = _mapper.Map<IList<CourseTimeInfoDTO>>(courses);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetCourse")]
        //[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCourse(int id)
        {
            var courses = await _courseService.GetByIdAsync(id);
            var result = _mapper.Map<CourseTimeInfoDTO>(courses);
            return Ok(result);
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseDTO coursesDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateCourse)}");
                return BadRequest(ModelState);
            }
            var courses = _mapper.Map<Course>(coursesDTO);
            await _courseService.AddAsync(courses);

            return CreatedAtRoute("GetCourse", new { id = courses.Id }, courses);
        }
        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateCourse(int id, [FromBody] UpdateCourseDTO courseDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateCourse)}");
                return BadRequest(ModelState);
            }
            var courseId = await _courseService.GetByIdAsync(id);
            
            if (courseId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateCourse)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(courseDTO, courseId);
            _courseService.Update(courseId);
            return NoContent();
            
        }
        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveCourse(int id)
        {
            await _courseService.Remove(id);
            return NoContent();
        }

    }
}
