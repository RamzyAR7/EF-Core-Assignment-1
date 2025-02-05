using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class Customer
    {
        // Id, Name, Email

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation Properties
        public List<Order> Orders { get; set; }
    }
}
