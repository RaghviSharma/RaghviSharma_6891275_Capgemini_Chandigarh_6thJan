using System;
using System.Collections.Generic;

namespace Case_Study_Hospital.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string? Name { get; set; }

    public string? Specialization { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
