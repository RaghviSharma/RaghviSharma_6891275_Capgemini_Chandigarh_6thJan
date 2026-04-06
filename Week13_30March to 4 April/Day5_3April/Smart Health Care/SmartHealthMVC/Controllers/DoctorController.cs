using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartHealthMVC.Models;

namespace SmartHealthMVC.Controllers
{
    
    public class DoctorController : Controller
    {
        private readonly ILogger<DoctorController> _logger;
        private readonly HttpClient _client;

        public DoctorController(ILogger<DoctorController> logger, HttpClient client)
        {
            _logger = logger;
            this._client = client;
        }

        public async Task<IActionResult> Index()
        {
            // cal web Api 
            var response = await _client.GetAsync("http://localhost:5287/api/Doctor");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var doctors = JsonSerializer.Deserialize<List<Doctor>>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(doctors);
            }
            return View(new List<Doctor>());
        }


        public async Task<IActionResult> DoctorAppointments(int doctorId)
{
    var response = await _client.GetAsync($"http://localhost:5287/api/Appointment/{doctorId}");

    if (response.IsSuccessStatusCode)
    {
        var appointments = await response.Content.ReadFromJsonAsync<List<Appointments>>(new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return View(appointments);
    }

    return View(new List<Appointments>()); // return empty list to show "No appointments"
}

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            var response = await _client.PostAsJsonAsync("http://localhost:5287/api/Doctor", doctor);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            TempData["Error"] = "Failed to add doctor";
            return RedirectToAction("Index");
        }
       

       [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _client.DeleteAsync($"http://localhost:5287/api/Doctor/{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Failed to remove doctor.";
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}