using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHealthApi.DTOs;

namespace SmartHealthApi.Services.Interface
{
    public interface IDoctorService
    {
        Task<DoctorDTO> AddDoctor(DoctorDTO doctor);

        Task<ICollection<GetDoctorDTO>> GetAllDoctor();

        Task<string> RemoveDoctor(int id);
    }
}