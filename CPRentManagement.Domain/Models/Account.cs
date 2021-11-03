using System.Collections.Generic;

namespace CPRentManagement.Domain.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }

        public ICollection<Charge> Charges { get; set; }
    }
}
