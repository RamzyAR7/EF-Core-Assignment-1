using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class Category
    {
        // Id, Name

        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Properties
        public List<Product> Products;
    }
}
