using CPRentManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CPRentManagement.Services.Contracts
{
    public interface ICompanyService
    {
        Task<List<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(int id);
        Task CreateCompany(Company company);
        Task<bool> UpdateCompany(Company company);
        Task<bool> DeleteCompany(int id);
    }
}