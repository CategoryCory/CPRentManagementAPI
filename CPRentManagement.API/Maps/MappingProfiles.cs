using AutoMapper;
using CPRentManagement.API.Dtos;
using CPRentManagement.Domain.Models;

namespace CPRentManagement.API.Maps
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
        }
    }
}
