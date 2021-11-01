using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRentManagement.Entities.Models
{
    public class Property
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateBuilt { get; set; }
        public int KeyNumber { get; set; }

    }
}
