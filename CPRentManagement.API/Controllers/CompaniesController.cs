using AutoMapper;
using CPRentManagement.API.Dtos;
using CPRentManagement.Domain.Models;
using CPRentManagement.Services;
using CPRentManagement.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CPRentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompaniesController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        // GET: api/<CompaniesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAllCompanies([FromQuery] bool includeDeleted = false)
        {
            var companies = await _companyService.GetAllCompanies(includeDeleted);

            if (companies.Count == 0)
            {
                return NoContent();
            }

            return Ok(_mapper.Map<List<Company>, List<CompanyDto>>(companies));
        }

        // GET api/<CompaniesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCompanyById(int id, [FromQuery] bool includeDeleted = false)
        {
            var company = await _companyService.GetCompanyById(id, includeDeleted);

            if (company is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Company, CompanyDto>(company));
        }

        // POST api/<CompaniesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddCompany([FromBody] CompanyDto companyDto)
        {
            var companyToCreate = _mapper.Map<CompanyDto, Company>(companyDto);

            ApplicationResult result = await _companyService.CreateCompany(companyToCreate);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }

        // PUT api/<CompaniesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] CompanyDto companyDto)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var companyToEdit = _mapper.Map<CompanyDto, Company>(companyDto);
            companyToEdit.CompanyId = id;

            ApplicationResult result = await _companyService.UpdateCompany(companyToEdit);

            if (result is null)
            {
                return NotFound();
            }

            if (!result.IsSuccess)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }

        // DELETE api/<CompaniesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            ApplicationResult result = await _companyService.DeleteCompany(id);

            if (result is null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
