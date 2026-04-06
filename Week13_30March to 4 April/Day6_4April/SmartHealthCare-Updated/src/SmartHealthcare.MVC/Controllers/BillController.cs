using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class BillController : Controller
{
    private readonly IApiService _apiService;
    private readonly ILogger<BillController> _logger;

    public BillController(IApiService apiService, ILogger<BillController> logger)
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
        if (role != "Admin" && role != "Doctor")
        {
            return Forbid();
        }

        // Check if bill already exists
        var existingBill = await _apiService.GetAsync<BillDTO>($"bills/appointment/{appointmentId}", token);
        if (existingBill != null)
        {
            TempData["Error"] = "Bill already exists for this appointment.";
            return RedirectToAction("Details", "Appointment", new { id = appointmentId });
        }

        var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{appointmentId}", token);
        if (appointment == null)
        {
            return NotFound();
        }

        ViewBag.Appointment = appointment;
        return View(new CreateBillDTO { AppointmentId = appointmentId });
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBillDTO dto)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin" && role != "Doctor")
        {
            return Forbid();
        }

        if (!ModelState.IsValid)
        {
            var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{dto.AppointmentId}", token);
            ViewBag.Appointment = appointment;
            return View(dto);
        }

        var result = await _apiService.PostAsync<BillDTO>("bills", dto, token);
        if (result == null)
        {
            ModelState.AddModelError(string.Empty, "Failed to create bill.");
            var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{dto.AppointmentId}", token);
            ViewBag.Appointment = appointment;
            return View(dto);
        }

        _logger.LogInformation("Bill created successfully");
        TempData["Success"] = "Bill created successfully!";
        return RedirectToAction("Details", "Appointment", new { id = dto.AppointmentId });
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return Forbid();
        }

        var bill = await _apiService.GetAsync<BillDTO>($"bills/appointment/{id}", token);
        if (bill == null)
        {
            return NotFound();
        }

        var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{id}", token);
        ViewBag.Appointment = appointment;

        var updateDto = new UpdateBillDTO
        {
            ConsultationFee = bill.ConsultationFee,
            MedicineCharges = bill.MedicineCharges,
            PaymentStatus = bill.PaymentStatus
        };

        return View(updateDto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, UpdateBillDTO dto)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
        {
            return Forbid();
        }

        if (!ModelState.IsValid)
        {
            var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{id}", token);
            ViewBag.Appointment = appointment;
            return View(dto);
        }

        var result = await _apiService.PutAsync<BillDTO>($"bills/{id}", dto, token);
        if (result == null)
        {
            ModelState.AddModelError(string.Empty, "Failed to update bill.");
            var appointment = await _apiService.GetAsync<AppointmentDTO>($"appointments/{id}", token);
            ViewBag.Appointment = appointment;
            return View(dto);
        }

        _logger.LogInformation("Bill updated successfully");
        TempData["Success"] = "Bill updated successfully!";
        return RedirectToAction("Details", "Appointment", new { id = id });
    }
}