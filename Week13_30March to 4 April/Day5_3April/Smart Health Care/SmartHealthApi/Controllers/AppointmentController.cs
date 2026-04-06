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
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointment;


        public AppointmentController(IAppointmentService appointment)
        {
            this._appointment = appointment;
        }

        [HttpGet]

        public async Task<IActionResult> AllAppointment()
        {
            return Ok(await _appointment.AllAppointments());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByDoctor(int id)
        {
            var data = await _appointment.AllAppointmentByDoctor(id);
            return Ok(data);
        }

        [HttpPost]

        public async Task<IActionResult> GetAppointment(AppointmentDTO appointment)
        {
            return Ok(await _appointment.GetAppointment(appointment));
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveAppointment(int id)
        {
            return Ok(await _appointment.RemoveAppointment(id));
        }
    }
}