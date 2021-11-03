using System;
using System.Collections.Generic;

namespace CPRentManagement.Domain.Models
{
    public enum TenantStatus
    {
        Active,
        Inactive
    }

    public class Tenant
    {
        public int TenantId { get; set; }
        public TenantStatus TenantStatus { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string SSN { get; set; }
        public string CompanyName { get; set; }
        public string AlternateCompany1 { get; set; }
        public string AlternateCompany2 { get; set; }
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Notes { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime MoveOutDate { get; set; }
        public DateTime LeaseBeginDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public ICollection<Charge> Charges { get; set; }
    }
}
