using Microsoft.AspNetCore.Identity;

namespace CPRentManagement.Repository.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
