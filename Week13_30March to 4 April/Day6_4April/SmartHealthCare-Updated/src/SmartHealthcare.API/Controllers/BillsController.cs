using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.API.Services.Interfaces;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class BillsController : ControllerBase
{
    private readonly IBillService _service;

    public BillsController(IBillService service) => _service = service;

    [HttpGet("appointment/{appointmentId:int}")]
    public async Task<IActionResult> GetByAppointmentId(int appointmentId)
    {
        var bill = await _service.GetByAppointmentIdAsync(appointmentId);
        if (bill == null) return NotFound(new ErrorResponseDTO { Message = "Bill not found", StatusCode = 404 });
        return Ok(bill);
    }

    [HttpPost]
    [Authorize(Roles = "Admin,Doctor")]
    public async Task<IActionResult> Create([FromBody] CreateBillDTO dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetByAppointmentId), new { appointmentId = result.AppointmentId }, result);
    }

    [HttpPut("{id:int}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateBillDTO dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await _service.UpdateAsync(id, dto);
        return Ok(result);
    }
}