using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class Order
    {
        // Id, OrderDate, CustomerId

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        // Navigation Properties
        public List<OrderDetail> OrderDetails;
        public Customer Customer;
    }
}
