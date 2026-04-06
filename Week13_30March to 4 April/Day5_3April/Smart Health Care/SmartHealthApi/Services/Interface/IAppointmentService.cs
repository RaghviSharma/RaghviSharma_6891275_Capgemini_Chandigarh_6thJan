using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHealthApi.DTOs;

namespace SmartHealthApi.Services.Interface
{
    public interface IAppointmentService
    {
        Task <ICollection<AllAppointmentDTO>> AllAppointments();

        Task<ICollection<AllAppointmentDTO>> AllAppointmentByDoctor(int id);
        Task<AppointmentDTO> GetAppointment(AppointmentDTO appointment);

        Task<string> RemoveAppointment(int appointmentId);
    }
}