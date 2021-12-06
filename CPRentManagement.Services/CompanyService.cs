using CPRentManagement.Domain.Models;
using CPRentManagement.Repository;
using CPRentManagement.Services.Contracts;
using CPRentManagement.Services.Validators;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPRentManagement.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CompanyService> _logger;
        private readonly CompanyValidator _companyValidator;

        public CompanyService(ApplicationDbContext context, ILogger<CompanyService> logger)
        {
            _context = context;
            _logger = logger;
            _companyValidator = new CompanyValidator();
        }

        public async Task<List<Company>> GetAllCompanies(bool includeDeleted = false)
        {
            var companies = _context.Companies.AsNoTracking();

            if (includeDeleted)
            {
                companies = companies.IgnoreQueryFilters();
            }

            return await companies.ToListAsync();
        }

        public async Task<Company> GetCompanyById(int id, bool includeDeleted = false)
        {
            var company = includeDeleted
                ? await _context.Companies.IgnoreQueryFilters().Where(c => c.CompanyId == id).FirstOrDefaultAsync()
                : await _context.Companies.FindAsync(id);
            return company;
        }

        public async Task<ApplicationResult> CreateCompany(Company company)
        {
            ValidationResult result = _companyValidator.Validate(company);

            if (!result.IsValid)
            {
                _logger.LogError("Failed to create new company");

                return ApplicationResult.Failure(result.Errors.Select(e => e.ErrorMessage).ToList());
            }

            _context.Companies.Add(company);
            await _context.SaveChangesAsync();

            return ApplicationResult.Success();
        }

        public async Task<ApplicationResult> UpdateCompany(Company cmp)
        {
            if (await _context.Companies.AnyAsync(c => c.CompanyId == cmp.CompanyId) == false)
            {
                _logger.LogError("The specified company {companyName} could not be found.", cmp.CompanyName);

                return null;
            }

            ValidationResult result = _companyValidator.Validate(cmp);

            if (!result.IsValid)
            {
                _logger.LogError("Failed to update company {companyName}", cmp.CompanyName);

                return ApplicationResult.Failure(result.Errors.Select(e => e.ErrorMessage).ToList());
            }

            _context.Companies.Update(cmp);
            await _context.SaveChangesAsync();

            return ApplicationResult.Success();
        }

        public async Task<ApplicationResult> DeleteCompany(int id)
        {
            Company company = await _context.Companies.FindAsync(id);

            if (company is null)
            {
                _logger.LogError("The specified company could not be found.");

                return null;
            }

            company.IsDeleted = true;
            await _context.SaveChangesAsync();

            return ApplicationResult.Success();
        }
    }
}
