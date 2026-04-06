using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHealthApi.DTOs;
using SmartHealthApi.Services.Interface;

namespace SmartHealthApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctor;

        public DoctorController(IDoctorService doctor)
        {
            this._doctor = doctor;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllDoctor()
        {
            return Ok(await _doctor.GetAllDoctor());
        }

        [HttpPost]

        public async Task<IActionResult> AddDoctor(DoctorDTO doctor)
        {
            return Ok(await _doctor.AddDoctor(doctor));
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveDoctor(int id)
        {
            return Ok(await _doctor.RemoveDoctor(id));
        }
    }
}