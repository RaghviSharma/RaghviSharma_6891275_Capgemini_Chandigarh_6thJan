using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHealthApi.Models;

namespace SmartHealthApi.DTOs
{
    public class AppointmentDTO
    {
        public DateTime AppointmentTime {get; set;}
        public string? Status {get; set;}
        public int DoctorId {get; set;}
        public DoctorDTO? Doctor {get; set;}

        public int PatientId {get; set;}
        public PatientDTO? Patient {get; set;}
    }
}