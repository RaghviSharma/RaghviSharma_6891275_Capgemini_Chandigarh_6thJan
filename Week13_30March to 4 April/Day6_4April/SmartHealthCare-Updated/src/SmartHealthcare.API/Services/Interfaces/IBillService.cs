using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.API.Services.Interfaces;

public interface IBillService
{
    Task<BillDTO> CreateAsync(CreateBillDTO dto);
    Task<BillDTO?> GetByAppointmentIdAsync(int appointmentId);
    Task<BillDTO> UpdateAsync(int id, UpdateBillDTO dto);
}