using System.ComponentModel.DataAnnotations;

namespace SmartHealthcare.Models.DTOs;

public class BillDTO
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal MedicineCharges { get; set; }
    public decimal Total { get; set; }
    public string PaymentStatus { get; set; } = "Unpaid";
    public DateTime CreatedAt { get; set; }
}

public class CreateBillDTO
{
    [Required]
    public int AppointmentId { get; set; }

    [Required, Range(0, double.MaxValue)]
    public decimal ConsultationFee { get; set; }

    [Required, Range(0, double.MaxValue)]
    public decimal MedicineCharges { get; set; }

    [Required]
    public string PaymentStatus { get; set; } = "Unpaid";
}

public class UpdateBillDTO
{
    [Required, Range(0, double.MaxValue)]
    public decimal ConsultationFee { get; set; }

    [Required, Range(0, double.MaxValue)]
    public decimal MedicineCharges { get; set; }

    [Required]
    public string PaymentStatus { get; set; }
}