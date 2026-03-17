using ProductManagement.Filters;

namespace ProductManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews(options =>
			{
				// Register global exception filter
				options.Filters.Add<CustomExceptionFilter>();
			});

			// Register logging filter
			builder.Services.AddScoped<LogActionFilter>();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Product}/{action=Index}/{id?}");

			app.Run();
		}
	}
}