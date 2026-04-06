using SmartHealthcare.API.Repositories.Interfaces;
using SmartHealthcare.Models.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartHealthcare.API.Data;

namespace SmartHealthcare.API.Repositories;

public class BillRepository : GenericRepository<Bill>, IBillRepository
{
    public BillRepository(ApplicationDbContext context) : base(context) { }

    public async Task<Bill?> GetByAppointmentIdAsync(int appointmentId)
    {
        return await _context.Bills
            .FirstOrDefaultAsync(b => b.AppointmentId == appointmentId);
    }
}