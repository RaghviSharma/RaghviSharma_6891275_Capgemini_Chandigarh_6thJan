using ECommerceAPI.Models;
//using ECommerceAPI.DTOs;
using ECommerceAPI.Data;
namespace ECommerceAPI.Data;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}