using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartHealthMVC.Models;

namespace SmartHealthMVC.Controllers
{
    
    public class AppointmentsController : Controller
    {
        private readonly ILogger<AppointmentsController> _logger;
        private readonly HttpClient _client;

        public AppointmentsController(ILogger<AppointmentsController> logger, HttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync("http://localhost:5287/api/Appointment");

            if(response.IsSuccessStatusCode)
            {
                var appointments = await response.Content.ReadFromJsonAsync<List<Appointments>>();
                return View(appointments);
            }

            // Optionally handle failure (e.g., show error view)
            return View("Error");
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var doctors = await _client.GetFromJsonAsync<List<Doctor>>("http://localhost:5287/api/Doctor");
            var patients = await _client.GetFromJsonAsync<List<Patient>>("http://localhost:5287/api/Patient");

            ViewBag.Doctors = doctors ?? new List<Doctor>();
            ViewBag.Patients = patients ?? new List<Patient>();

            return View();
        }

         [HttpPost]
        public async Task<IActionResult> Create(int DoctorId, int PatientId, string Problem)
        {
            var appointmentDto = new
            {
                AppointmentTime = DateTime.Now,
                Status = "Pending",
                DoctorId = DoctorId,
                PatientId = PatientId
                // Note: Problem is not saved currently in backend appointment model
            };

            var response = await _client.PostAsJsonAsync("http://localhost:5287/api/Appointment", appointmentDto);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Failed to book appointment");
                // Reload dropdowns for redisplay
                var doctors = await _client.GetFromJsonAsync<List<Doctor>>("http://localhost:5287/api/Doctor");
                var patients = await _client.GetFromJsonAsync<List<Patient>>("http://localhost:5287/api/Patient");

                ViewBag.Doctors = doctors ?? new List<Doctor>();
                ViewBag.Patients = patients ?? new List<Patient>();

                return View();
            }
        }

       [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _client.DeleteAsync($"http://localhost:5287/api/Appointment/{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Failed to delete appointment");
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}