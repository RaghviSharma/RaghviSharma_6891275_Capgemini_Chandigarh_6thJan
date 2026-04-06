using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHealthMVC.Models
{
    public class Appointments
    {
        public int AppointmentId {get; set;}
        public DateTime AppointmentTime {get; set;}
        public string? Status {get; set;}
        public int DoctorId {get; set;}
        public Doctor? Doctor {get; set;}
        public int PatientId {get; set;}
        public Patient? Patient {get; set;} 
    }
}