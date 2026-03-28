using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ? Add Controllers
builder.Services.AddControllers();

// ? Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ? In-Memory DB
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseInMemoryDatabase("StudentDB"));

var app = builder.Build();

// ? Swagger Middleware
app.UseSwagger();
app.UseSwaggerUI();

// ? Map Controllers
app.MapControllers();

app.Run();