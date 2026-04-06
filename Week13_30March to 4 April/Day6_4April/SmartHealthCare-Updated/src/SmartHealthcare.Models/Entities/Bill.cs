using System.ComponentModel.DataAnnotations;

namespace SmartHealthcare.Models.Entities;

public class Bill
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }

    [Required]
    public decimal ConsultationFee { get; set; }

    [Required]
    public decimal MedicineCharges { get; set; }

    public decimal Total => ConsultationFee + MedicineCharges;

    [Required, MaxLength(20)]
    public string PaymentStatus { get; set; } = "Unpaid";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Appointment Appointment { get; set; } = null!;
}