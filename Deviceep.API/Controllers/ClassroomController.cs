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
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomService _classroomService;
        private readonly IMapper _mapper;
        private readonly ILogger<ClassroomController> _logger;

        public ClassroomController(IClassroomService classroomService, IMapper mapper, ILogger<ClassroomController> logger)
        {
            _classroomService = classroomService;
            _mapper = mapper;
            _logger = logger;

        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetClassrooms([FromQuery] RequestParams requestParams)
        {
                var classrooms = await _classroomService.GetPagedList(requestParams, null);
                var results = _mapper.Map<IList<ClassroomDTO>>(classrooms);
                return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetClassroom")]
        //[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetClasroom(int id)
        {
            var classrooms = await _classroomService.GetByIdAsync(id);
            var result = _mapper.Map<ClassroomDTO>(classrooms);
            return Ok(result);
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateClassroom([FromBody] CreateClassroomDTO createClassroomDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateClassroom)}");
                return BadRequest(ModelState);
            }
            var classrooms = _mapper.Map<Classroom>(createClassroomDTO);
            await _classroomService.AddAsync(classrooms);

            return CreatedAtRoute("GetClassroom", new { id = classrooms.Id }, classrooms);
        }
        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateClassroom(int id, [FromBody] UpdateClassroomDTO updateClassroomDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(updateClassroomDTO)}");
                return BadRequest(ModelState);
            }
            var clasroomId = await _classroomService.GetByIdAsync(id);

            if (clasroomId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateClassroom)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(updateClassroomDTO, clasroomId);
            _classroomService.Update(clasroomId);
            return NoContent();

        }
        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveClassroom(int id)
        {
            await _classroomService.Remove(id);
            return NoContent();
        }

    }
}
