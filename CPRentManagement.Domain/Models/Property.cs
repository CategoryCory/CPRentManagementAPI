using System;
using System.Collections.Generic;

namespace CPRentManagement.Domain.Models
{
    public enum PropertyType
    {
        Commercial,
        Residential,
        Billboard,
        Tower
    }

    public class Property
    {
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
        public PropertyType PropertyType { get; set; }
        public double SquareFeet { get; set; }
        public int Taxes { get; set; }
        public int Insurance { get; set; }

        public List<Unit> Units { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
