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
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patient;

        public PatientController(IPatientService patient)
        {
            this._patient = patient;
        }

        [HttpGet]

        public async Task<IActionResult> GetPatient()
        {
            return Ok(await _patient.GetAllPatient());
        }

        [HttpPost]

        public async Task<IActionResult> AddPatient(PatientDTO patient)
        {
            return Ok(await _patient.AddPatient(patient));
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> RemovePatient(int id)
        {
            return Ok(await _patient.RemovePatient(id));
        }
    }
}