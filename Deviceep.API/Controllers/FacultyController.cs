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
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _FacultyService;
        private readonly IMapper _mapper;
        private readonly ILogger<FacultyController> _logger;

        public FacultyController(IFacultyService FacultyService, IMapper mapper, ILogger<FacultyController> logger)
        {
            _FacultyService = FacultyService;
            _mapper = mapper;
            _logger = logger;

        }
        [HttpGet]
        //özel cache süresi eklenebilir.
        //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
        //[HttpCacheValidation(MustRevalidate = false)]
        [ResponseCache(CacheProfileName = "120SecondDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Asnc yaparak başlamak iyi api'la çalışıyon sonuçta
        public async Task<IActionResult> GetFaculties([FromQuery] RequestParams requestParams)
        {

            var faculties = await _FacultyService.GetPagedList(requestParams, null);
            // Mapping yaparak direk data^ya değil dto üzerinden ulaşmasını sağlıyoruz.
            var results = _mapper.Map<IList<FacultyDTO>>(faculties);
            // Return Type'lar önemli
            // Yapabildiysek OK yani 200 Veriyoruz
            return Ok(results);

        }

        [HttpGet("{id:int}", Name = "GetFaculty")]
        //[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFaculty(int id)
        {
            var faculty = await _FacultyService.GetByIdAsync(id);
            var result = _mapper.Map<FacultyDTO>(faculty);
            return Ok(result);
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateFaculty([FromBody] CreateFacultyDTO createFacultyDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateFaculty)}");
                return BadRequest(ModelState);
            }
            var faculty = _mapper.Map<Faculty>(createFacultyDTO);
            await _FacultyService.AddAsync(faculty);

            return CreatedAtRoute("GetCourse", new { id = faculty.Id }, faculty);
        }
        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateFaculty(int id, [FromBody] UpdateFacultyDTO updateFacultyDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateFaculty)}");
                return BadRequest(ModelState);
            }
            var facultyId = await _FacultyService.GetByIdAsync(id);

            if (facultyId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateFaculty)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(updateFacultyDTO, facultyId);
            _FacultyService.Update(facultyId);
            return NoContent();

        }
        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveFaculty(int id)
        {
            await _FacultyService.Remove(id);
            return NoContent();
        }
    }
}
