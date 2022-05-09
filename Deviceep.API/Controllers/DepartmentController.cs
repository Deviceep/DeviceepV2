using AutoMapper;
using Deviceep.API.DTOs;
using Deviceep.Core.Services;
using Deviceep.Entity.AdditionalModels;
using Deviceep.Entity.Models;
using Marvin.Cache.Headers;
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
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _DepartmentService;
        private readonly IMapper _mapper;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IDepartmentService DepartmentService, IMapper mapper, ILogger<DepartmentController> logger)
        {
            _DepartmentService = DepartmentService;
            _mapper = mapper;
            _logger = logger;

        }

        [HttpGet]
        //özel cache süresi eklenebilir.
        //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
        //[HttpCacheValidation(MustRevalidate = false)]
        [ResponseCache(CacheProfileName ="120SecondDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // Asnc yaparak başlamak iyi api'la çalışıyon sonuçta
        public async Task<IActionResult> GetDepartments([FromQuery] RequestParams requestParams)
        {
               
            var departments = await _DepartmentService.GetPagedList(requestParams, null);
            // Mapping yaparak direk data^ya değil dto üzerinden ulaşmasını sağlıyoruz.
            var results = _mapper.Map<IList<DepartmentDTO>>(departments);
            // Return Type'lar önemli
            // Yapabildiysek OK yani 200 Veriyoruz
            return Ok(results); 
           
        }

        [HttpGet("{id:int}", Name = "GetDepartment")]
        //[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var department = await _DepartmentService.GetByIdAsync(id);
            var result = _mapper.Map<DepartmentDTO>(department);
            return Ok(result);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentDTO createDepartmentDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateDepartment)}");
                return BadRequest(ModelState);
            }
            var department = _mapper.Map<Department>(createDepartmentDTO);
            await _DepartmentService.AddAsync(department);

            return CreatedAtRoute("GetCourse", new { id = department.Id }, department);
        }
        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] UpdateDepartmentDTO updateDepartmentDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateDepartment)}");
                return BadRequest(ModelState);
            }
            var departmentId = await _DepartmentService.GetByIdAsync(id);

            if (departmentId == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateDepartment)}");
                return BadRequest("Submitted data is invalid");
            }
            _mapper.Map(updateDepartmentDTO, departmentId);
            _DepartmentService.Update(departmentId);
            return NoContent();

        }
        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoveDepartment(int id)
        {
            await _DepartmentService.Remove(id);
            return NoContent();
        }
    }
}
