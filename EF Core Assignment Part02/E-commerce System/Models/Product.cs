using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class Product
    {
        //Id, Name, Price, CategoryId

        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }

        // Navigation Properties
        public List<OrderDetail> OrderDetails;
        public Category Category;
    }
}
