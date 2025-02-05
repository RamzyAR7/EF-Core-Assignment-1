using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.Models
{
    internal class Doctor
    {
        // Id, Name, Specialization

        public int Id { get; set; }
        public string Name { get; set; }

        public string Specialization { get; set; }

        // Navigation Properties

        public List<Appointment> Appointments { get; set; }

    }
}
