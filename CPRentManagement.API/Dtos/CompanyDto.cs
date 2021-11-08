using System.ComponentModel.DataAnnotations;

namespace CPRentManagement.API.Dtos
{
    public class CompanyDto
    {
        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        [MaxLength(50)]
        public string AddrLine1 { get; set; }

        [MaxLength(50)]
        public string AddrLine2 { get; set; }

        [MaxLength(25)]
        public string City { get; set; }

        [MaxLength(25)]
        public string State { get; set; }

        [MaxLength(15)]
        public string ZipCode { get; set; }

        [MaxLength(25)]
        public string Phone { get; set; }

        [MaxLength(25)]
        public string AlternatePhone { get; set; }

        [MaxLength(25)]
        public string Fax { get; set; }
    }
}
