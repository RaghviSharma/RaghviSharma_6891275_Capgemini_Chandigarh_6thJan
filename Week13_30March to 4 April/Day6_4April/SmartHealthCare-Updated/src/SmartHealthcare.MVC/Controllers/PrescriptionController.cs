using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class PrescriptionController : Controller
{
    private readonly IApiService _apiService;
    private readonly ILogger<PrescriptionController> _logger;

    public PrescriptionController(IApiService apiService, ILogger<PrescriptionController> logger)
    {
        _apiService = apiService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Create(int appointmentId)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Doctor")
        {
            return Forbid();
        }

        // Check if prescription already exists
        var existingPrescription = await _apiService.GetAsync<PrescriptionDTO>($"prescriptions/appointment/{appointmentId}", token);
        if (existingPrescription != null)
        {
            TempData["Info"] = "Prescription already exists for this appointment.";
            return RedirectToAction("Details", "Appointment", new { id = appointmentId });
        }

        var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{appointmentId}", token);
        if (appointment == null)
        {
            return NotFound();
        }

        ViewBag.Appointment = appointment;
        return View(new CreatePrescriptionDTO { AppointmentId = appointmentId });
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePrescriptionDTO dto)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Doctor")
        {
            return Forbid();
        }

        if (!ModelState.IsValid)
        {
            var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{dto.AppointmentId}", token);
            ViewBag.Appointment = appointment;
            return View(dto);
        }

        var result = await _apiService.PostAsync<PrescriptionDTO>("prescriptions", dto, token);
        if (result == null)
        {
            ModelState.AddModelError(string.Empty, "Failed to create prescription.");
            var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{dto.AppointmentId}", token);
            ViewBag.Appointment = appointment;
            return View(dto);
        }

        _logger.LogInformation("Prescription created successfully");
        TempData["Success"] = "Prescription created successfully!";
        return RedirectToAction("Details", "Appointment", new { id = dto.AppointmentId });
    }
}