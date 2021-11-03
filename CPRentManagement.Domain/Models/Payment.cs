using System;

namespace CPRentManagement.Domain.Models
{
    public enum PaymentType
    {
        Payment,
        Credit,
        Deposit
    }

    public enum PaymentMethod
    {
        Check,
        Cash,
        CreditCard,
        Electronic
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public bool? IsActive { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public int AmountInCents { get; set; }
        public int BalanceInCents { get; set; }
        public string Memo { get; set; }

        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
