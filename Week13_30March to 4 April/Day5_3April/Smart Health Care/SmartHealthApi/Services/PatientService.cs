using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHealthApi.Data;
using SmartHealthApi.Services.Interface;
using SmartHealthApi.DTOs;
using SmartHealthApi.Models;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;

namespace SmartHealthApi.Services
{
    public class PatientService : IPatientService
    {
        private readonly ApplicationDbContext _db;

        public PatientService(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task<PatientDTO> AddPatient(PatientDTO patient)
        {
            var newPatient = new Patients
            {
                Name = patient.Name,
                Problem = patient.Problem
            };

            await _db.Patients.AddAsync(newPatient);
            await _db.SaveChangesAsync();
            return patient;
        }

        public async Task<ICollection<GetPatientDTO>> GetAllPatient()
        {
            var patient = await _db.Patients.ToListAsync();

            var PatientDto = patient.Select(p => new GetPatientDTO
            {
                Id = p.Id,
                Name = p.Name,
                Problem = p.Problem

            }).ToList();

            return PatientDto;
        }

        public async Task<string> RemovePatient(int id)
        {
            var patient = await _db.Patients.FindAsync(id);

            if(patient == null)
            {
                return "Patient not found";
            }

            _db.Patients.Remove(patient);
            await _db.SaveChangesAsync();
            return "Patient remove successfully";
        }
    }
}