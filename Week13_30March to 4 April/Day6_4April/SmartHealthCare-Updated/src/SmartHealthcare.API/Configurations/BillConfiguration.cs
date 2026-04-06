using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthcare.Models.Entities;

namespace SmartHealthcare.API.Configurations;

public class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.ConsultationFee)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(b => b.MedicineCharges)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(b => b.PaymentStatus)
            .HasMaxLength(20)
            .IsRequired();

        builder.HasOne(b => b.Appointment)
            .WithOne(a => a.Bill)
            .HasForeignKey<Bill>(b => b.AppointmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}