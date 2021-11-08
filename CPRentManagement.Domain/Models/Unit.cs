using System.Collections.Generic;

namespace CPRentManagement.Domain.Models
{
    public enum UnitStatus
    {
        Occupied,
        Unoccupied
    }

    public class Unit
    {
        public int UnitId { get; set; }
        public bool IsDeleted { get; set; }
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public int RentInCents { get; set; }
        public double SquareFeet { get; set; }
        public double PercentageOccupied { get; set; }
        public UnitStatus UnitStatus { get; set; }

        public ICollection<Tenant> Tenants { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
