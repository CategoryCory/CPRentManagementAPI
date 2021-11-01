using System;

namespace CPRentManagement.API.Models
{
    public class Property
    {
        public enum PropertyType
        {
            Commercial,
            Residential,
            Billboard,
            Tower
        }

        public int PropertyId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateBuilt { get; set; }
        public int KeyNumber { get; set; }
        public string Description { get; set; }
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public PropertyType Type { get; set; }
        public int Taxes { get; set; }
        public int Insurance { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
