using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartHealthApi.Models;

namespace SmartHealthApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }

        public DbSet<Patients>Patients {get; set;}
        public DbSet<Doctor>Doctors {get; set;}
        public DbSet<Appointment>Appointments {get; set;}
    }
}