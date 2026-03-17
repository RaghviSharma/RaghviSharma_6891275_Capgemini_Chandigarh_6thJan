var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Enable Session
builder.Services.AddSession();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Enable Session Middleware
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();