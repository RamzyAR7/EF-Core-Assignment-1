using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.Models
{
    internal class Appointment
    {
        // PatientId, DoctorId, AppointmentDate

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public  DateTime AppointmentDate { get; set; }

        // Navigation Properties

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
