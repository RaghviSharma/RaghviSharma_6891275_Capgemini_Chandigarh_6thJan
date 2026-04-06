using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHealthApi.Models
{
    public class Doctor
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? PhoneNumber {get; set;}
        public List<Appointment>Appointments {get; set;} = new List<Appointment>();

    }
}