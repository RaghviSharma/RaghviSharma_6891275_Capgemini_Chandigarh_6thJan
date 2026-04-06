using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHealthApi.DTOs;

namespace SmartHealthApi.Services.Interface
{
    public interface IPatientService
    {
        Task<PatientDTO> AddPatient(PatientDTO patient);
        Task<ICollection<GetPatientDTO>> GetAllPatient();
        Task<string> RemovePatient(int id);
    }
}