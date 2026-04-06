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
    public class DoctorService : IDoctorService
    { 
        private readonly ApplicationDbContext _db;

        public DoctorService(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task<DoctorDTO> AddDoctor(DoctorDTO doctor)
        {
            var newDoctor = new Doctor
            {
                Name = doctor.Name,
                PhoneNumber = doctor.PhoneNumber
            };

            await _db.Doctors.AddAsync(newDoctor);
            await _db.SaveChangesAsync();
            return doctor;
        }

        public async Task<ICollection<GetDoctorDTO>> GetAllDoctor()
        {
            var doctors = await _db.Doctors.ToListAsync();

            var doctorDtos = doctors.Select(d => new GetDoctorDTO
            {
                Id = d.Id,
                Name = d.Name,
                PhoneNumber = d.PhoneNumber
            }).ToList();

            return doctorDtos;
        }

        public async Task<string> RemoveDoctor(int id)
        {
            var doctor = await _db.Doctors.FindAsync(id);

            if(doctor == null)
            {
                return "Doctor not found";
            }

            _db.Doctors.Remove(doctor);
            await _db.SaveChangesAsync();
            return "Doctor Removed";
        }
    }
}