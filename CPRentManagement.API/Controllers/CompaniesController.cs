using CPRentManagement.Domain.Models;
using CPRentManagement.Services.Contracts;
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

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // GET: api/<CompaniesController>
        [HttpGet]
        public async Task<IActionResult> GetAllCompanies()
        {
            var companies = await _companyService.GetAllCompanies();
            return Ok(companies);
        }

        // GET api/<CompaniesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            var company = await _companyService.GetCompanyById(id);
            return Ok(company);
        }

        // POST api/<CompaniesController>
        [HttpPost]
        public async Task<IActionResult> AddCompany([FromBody] Company company)
        {
            await _companyService.CreateCompany(company);
            return Ok();
        }

        // PUT api/<CompaniesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, [FromBody] Company company)
        {
            company.CompanyId = id;
            bool success = await _companyService.UpdateCompany(company);
            if (success) return Ok();
            else return BadRequest();
        }

        // DELETE api/<CompaniesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            bool success = await _companyService.DeleteCompany(id);
            if (success) return Ok();
            else return BadRequest();
        }
    }
}
