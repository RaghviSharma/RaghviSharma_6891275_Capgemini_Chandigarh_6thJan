using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class PatientController : Controller
{
    private readonly IApiService _apiService;

    public PatientController(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<IActionResult> Profile()
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var patient = await _apiService.GetAsync<PatientDTO>("patients/my-profile", token);
        if (patient == null)
        {
            ViewBag.NeedsProfile = true;
            return View(new PatientDTO());
        }

        return View(patient);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProfile(CreatePatientDTO dto)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        if (!ModelState.IsValid)
        {
            ViewBag.NeedsProfile = true;
            return View("Profile", new PatientDTO());
        }

        var result = await _apiService.PostAsync<PatientDTO>("patients", dto, token);
        if (result == null)
        {
            ModelState.AddModelError(string.Empty, "Failed to create profile");
            ViewBag.NeedsProfile = true;
            return View("Profile", new PatientDTO());
        }

        TempData["Success"] = "Profile created successfully!";
        return RedirectToAction(nameof(Profile));
    }

    public async Task<IActionResult> MedicalHistory()
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Patient")
        {
            return Forbid();
        }

        // Get patient's appointments
        var appointments = await _apiService.GetAsync<PagedResult<AppointmentDTO>>("appointments/my-appointments?pageNumber=1&pageSize=100", token);
        var medicalRecords = new List<dynamic>();

        if (appointments?.Items != null)
        {
            foreach (var appointment in appointments.Items.Where(a => a.Status == "Completed"))
            {
                var prescription = await _apiService.GetAsync<PrescriptionDTO>($"prescriptions/appointment/{appointment.Id}", token);
                if (prescription != null)
                {
                    medicalRecords.Add(new
                    {
                        Appointment = appointment,
                        Prescription = prescription
                    });
                }
            }
        }

        return View(medicalRecords);
    }

    public async Task<IActionResult> Billing()
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        if (role != "Patient")
        {
            return Forbid();
        }

        // Get patient's appointments
        var appointments = await _apiService.GetAsync<PagedResult<AppointmentDTO>>("appointments/my-appointments?pageNumber=1&pageSize=100", token);
        var bills = new List<dynamic>();

        if (appointments?.Items != null)
        {
            foreach (var appointment in appointments.Items)
            {
                var bill = await _apiService.GetAsync<BillDTO>($"bills/appointment/{appointment.Id}", token);
                if (bill != null)
                {
                    bills.Add(new
                    {
                        Appointment = appointment,
                        Bill = bill
                    });
                }
            }
        }

        return View(bills);
    }
}