using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class OrderDetail
    {
        // OrderId, ProductId, Quantity

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public double Quantity { get; set; }

        // Navigation Properties
        public Order Order;
        public Product Product;
    }
}
