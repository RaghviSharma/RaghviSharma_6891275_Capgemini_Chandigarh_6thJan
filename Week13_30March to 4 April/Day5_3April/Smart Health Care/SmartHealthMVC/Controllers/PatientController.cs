using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartHealthMVC.Models;

namespace SmartHealthMVC.Controllers
{
  
    public class PatientController : Controller
    {
        private readonly ILogger<PatientController> _logger;
        private readonly HttpClient _client;
        public PatientController(ILogger<PatientController> logger, HttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync("http://localhost:5287/api/Patient");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var patients = JsonSerializer.Deserialize<List<Patient>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(patients);
            }
            return View(new List<Patient>());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Patient patient)
        {
            var response = await _client.PostAsJsonAsync("http://localhost:5287/api/Patient", patient);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
             TempData["Error"] = "Failed to remove Patient.";
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _client.DeleteAsync($"http://localhost:5287/api/Patient/{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Failed to remove Patient.";
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}