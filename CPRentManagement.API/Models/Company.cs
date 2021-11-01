using System.Collections.Generic;

namespace CPRentManagement.API.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public bool IsActive { get; set; }
        public string CompanyName { get; set; }
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string AlternatePhone { get; set; }
        public string Fax { get; set; }

        public List<Property> Properties { get; set; }
    }
}
