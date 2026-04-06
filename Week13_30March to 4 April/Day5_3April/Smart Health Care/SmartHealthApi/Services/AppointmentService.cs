using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartHealthApi.Data;
using SmartHealthApi.DTOs;
using SmartHealthApi.Models;
using SmartHealthApi.Services.Interface;

namespace SmartHealthApi.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task<ICollection<AllAppointmentDTO>> AllAppointments()
        {
            var appointment = await _db.Appointments
            .Include(a => a.Doctor)
            .Include(a => a.Patient)
            .ToListAsync();

            var allappointments = appointment.Select(a => new AllAppointmentDTO
            {
                AppointmentId = a.Id,
                AppointmentTime = a.AppointmentTime,
                Status = a.Status,
                DoctorId = a.DoctorId,
                Doctor = new DoctorDTO
                {
                    Name = a.Doctor?.Name,
                    PhoneNumber = a.Doctor?.PhoneNumber
                },
                PatientId = a.PatientId,
                Patient = new PatientDTO
                {
                    Name = a.Patient?.Name,
                    Problem = a.Patient?.Problem
                }
            }).ToList();

            return allappointments;
        }

        public async Task<ICollection<AllAppointmentDTO>> AllAppointmentByDoctor(int doctorId)
        {
            var appointments = await _db.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Where(a => a.DoctorId == doctorId)
                .ToListAsync();

            return appointments.Select(a => new AllAppointmentDTO
            {
                AppointmentId = a.Id,
                AppointmentTime = a.AppointmentTime,
                Status = a.Status,
                DoctorId = a.DoctorId,
                Doctor = new DoctorDTO
                {
                    Name = a.Doctor?.Name,
                    PhoneNumber = a.Doctor?.PhoneNumber
                },
                PatientId = a.PatientId,
                Patient = new PatientDTO
                {
                    Name = a.Patient?.Name,
                    Problem = a.Patient?.Problem
                }
            }).ToList();
        }

        public async Task<AppointmentDTO> GetAppointment(AppointmentDTO appointment)
        {
            var Appointment = new Appointment
            {
                AppointmentTime = DateTime.Now,
                Status = "Approved",
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId
            };

            await _db.Appointments.AddAsync(Appointment);
            await _db.SaveChangesAsync();

            return appointment;
        }

        public async Task<string> RemoveAppointment(int id)
        {
            var appointmentExisit = await _db.Appointments.FindAsync(id);
            
            if(appointmentExisit == null)
            {
                return "No Appointment Found";
            }

            _db.Appointments.Remove(appointmentExisit);
            await _db.SaveChangesAsync();

            return "Appointment Remove Successfully";
        }
    }
}