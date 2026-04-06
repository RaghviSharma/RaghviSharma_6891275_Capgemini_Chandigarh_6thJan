using SmartHealthcare.API.Repositories.Interfaces;
using SmartHealthcare.API.Services.Interfaces;
using SmartHealthcare.Models.DTOs;
using SmartHealthcare.Models.Entities;
using System.Threading.Tasks;

namespace SmartHealthcare.API.Services;

public class BillService : IBillService
{
    private readonly IBillRepository _repository;
    private readonly IAppointmentRepository _appointmentRepository;

    public BillService(IBillRepository repository, IAppointmentRepository appointmentRepository)
    {
        _repository = repository;
        _appointmentRepository = appointmentRepository;
    }

    public async Task<BillDTO> CreateAsync(CreateBillDTO dto)
    {
        var appointment = await _appointmentRepository.GetByIdAsync(dto.AppointmentId);
        if (appointment == null)
            throw new KeyNotFoundException("Appointment not found");

        var bill = new Bill
        {
            AppointmentId = dto.AppointmentId,
            ConsultationFee = dto.ConsultationFee,
            MedicineCharges = dto.MedicineCharges,
            PaymentStatus = dto.PaymentStatus
        };

        await _repository.AddAsync(bill);
        await _repository.SaveAsync();

        return new BillDTO
        {
            Id = bill.Id,
            AppointmentId = bill.AppointmentId,
            ConsultationFee = bill.ConsultationFee,
            MedicineCharges = bill.MedicineCharges,
            Total = bill.Total,
            PaymentStatus = bill.PaymentStatus,
            CreatedAt = bill.CreatedAt
        };
    }

    public async Task<BillDTO?> GetByAppointmentIdAsync(int appointmentId)
    {
        var bill = await _repository.GetByAppointmentIdAsync(appointmentId);
        if (bill == null) return null;

        return new BillDTO
        {
            Id = bill.Id,
            AppointmentId = bill.AppointmentId,
            ConsultationFee = bill.ConsultationFee,
            MedicineCharges = bill.MedicineCharges,
            Total = bill.Total,
            PaymentStatus = bill.PaymentStatus,
            CreatedAt = bill.CreatedAt
        };
    }

    public async Task<BillDTO> UpdateAsync(int id, UpdateBillDTO dto)
    {
        var bill = await _repository.GetByIdAsync(id);
        if (bill == null)
            throw new KeyNotFoundException("Bill not found");

        bill.ConsultationFee = dto.ConsultationFee;
        bill.MedicineCharges = dto.MedicineCharges;
        bill.PaymentStatus = dto.PaymentStatus;

        _repository.Update(bill);
        await _repository.SaveAsync();

        return new BillDTO
        {
            Id = bill.Id,
            AppointmentId = bill.AppointmentId,
            ConsultationFee = bill.ConsultationFee,
            MedicineCharges = bill.MedicineCharges,
            Total = bill.Total,
            PaymentStatus = bill.PaymentStatus,
            CreatedAt = bill.CreatedAt
        };
    }
}