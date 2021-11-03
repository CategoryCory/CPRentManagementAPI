using System;

namespace CPRentManagement.Domain.Models
{
    public enum ChargeStatus
    {
        Paid,
        Unpaid,
        Deleted
    }

    public class Charge
    {
        public int ChargeId { get; set; }
        public ChargeStatus ChargeStatus { get; set; }
        public DateTime ChargeDate { get; set; }
        public int AmountInCents { get; set; }
        public int BalanceInCents { get; set; }
        public string Memo { get; set; }

        public int ParentChargeId { get; set; }
        public Charge ParentCharge { get; set; }
        public Charge LateCharge { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
