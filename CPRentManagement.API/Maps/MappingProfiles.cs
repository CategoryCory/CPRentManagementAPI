using AutoMapper;
using CPRentManagement.API.Dtos;
using CPRentManagement.Domain.Models;
using CPRentManagement.Repository.IdentityModels;

namespace CPRentManagement.API.Maps
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            //CreateMap<ApplicationUser, UserDto>().ReverseMap();
        }
    }
}
