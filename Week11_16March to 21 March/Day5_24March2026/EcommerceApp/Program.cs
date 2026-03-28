using System;
using Microsoft.EntityFrameworkCore;
using EcommerceApp.Data;
using Microsoft.Extensions.Diagnostics.HealthChecks; // ✅ add this

namespace EcommerceApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services
			builder.Services.AddControllersWithViews();
			builder.Services.AddSession();

			builder.Services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			// ✅ ADD HEALTH CHECK HERE
			builder.Services.AddHealthChecks()
                .AddSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

			var app = builder.Build();

			// Configure pipeline
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseSession();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			// ✅ ADD HEALTH ENDPOINT HERE
			app.MapHealthChecks("/health");

			app.Run();
		}
	}
}