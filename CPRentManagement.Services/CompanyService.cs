using CPRentManagement.Domain.Models;
using CPRentManagement.Repository;
using CPRentManagement.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CPRentManagement.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;

        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> GetAllCompanies()
        {
            var companies = await _context.Companies
                .AsNoTracking()
                .ToListAsync();
            return companies;
        }

        public async Task<Company> GetCompanyById(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            return company;
        }

        public async Task CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCompany(Company company)
        {
            if (company is null || company.CompanyId <= 0)
            {
                return false;
            }

            _context.Companies.Update(company);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCompany(int id)
        {
            if (id <= 0)
            {
                return false;
            }

            Company company = await _context.Companies.FindAsync(id);
            if (company is not null)
            {
                company.IsActive = false;
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
