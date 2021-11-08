using CPRentManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CPRentManagement.Services.Contracts
{
    public interface ICompanyService
    {
        Task<List<Company>> GetAllCompanies(bool includeDeleted = false);
        Task<Company> GetCompanyById(int id, bool includeDeleted = false);
        Task<ApplicationResult> CreateCompany(Company company);
        Task<ApplicationResult> UpdateCompany(Company company);
        Task<ApplicationResult> DeleteCompany(int id);
    }
}