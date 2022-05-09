using AutoMapper;
using Deviceep.API.DTOs;
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
    public class CourseTimeInfoController : ControllerBase
    {
        private readonly ICourseTimeInfoService _courseTimeInfoService;
        private readonly IMapper _mapper;
        private readonly ILogger<CourseTimeInfoController> _logger;

        public CourseTimeInfoController(ICourseTimeInfoService courseTimeInfoService, IMapper mapper, ILogger<CourseTimeInfoController> logger)
        {
            _courseTimeInfoService = courseTimeInfoService;
            _mapper = mapper;
            _logger = logger;

        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCourseTimes([FromQuery] RequestParams requestParams)
        {
            var courseTimeInfos = await _courseTimeInfoService.GetPagedList(requestParams);
            var results = _mapper.Map<IList<CourseTimeInfoDTO>>(courseTimeInfos);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetCourseTime")]
        //[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCourseTime(int id)
        {
            var courseTimeInfos = await _courseTimeInfoService.GetByIdAsync(id);
            var result = _mapper.Map<CourseTimeInfoDTO>(courseTimeInfos);
            return Ok(result);
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCourseTime([FromBody] CreateCourseTimeInfoDTO createCourseTimeInfoDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateCourseTime)}");
                return BadRequest(ModelState);
            }
            var courseTimeInfos = _mapper.Map<CourseTimeInfo>(createCourseTimeInfoDTO);
            await _courseTimeInfoService.AddAsync(courseTimeInfos);

            return CreatedAtRoute("GetCourse", new { id = courseTimeInfos.Id }, courseTimeInfos);
        }
        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateCourseTime(int id, [FromBody]  UpdateCourseTimeInfoDTO updateCourseTimeInfoDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateCourseTime)}");
                return BadRequest(ModelState);
            }
            var courseTimeId = await _courseTimeInfoService.GetByIdAsync(id);

            if (courseTimeId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateCourseTime)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(updateCourseTimeInfoDTO, courseTimeId);
            _courseTimeInfoService.Update(courseTimeId);
            return NoContent();

        }
        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveCourseTime(int id)
        {
            await _courseTimeInfoService.Remove(id);
            return NoContent();
        }
    }
}
