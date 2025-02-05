using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_Part01.Models
{
    internal class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = "OurProject";
        public  double  Cost { get; set; }

    }
}
