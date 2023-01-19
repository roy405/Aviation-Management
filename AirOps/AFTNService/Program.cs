using Microsoft.EntityFrameworkCore;
using AFTNService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//This is the added service for DbContext to connect to the database
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<IFlightInformationRepo, FlightInformationRepo>();
builder.Services.AddScoped<IFlightPlanRepo, FlightPlanRepo>();
builder.Services.AddScoped<IRunwayInformationRepo, RunwayInformationRepo>();
builder.Services.AddScoped<IStatusReportRepo, StatusReportRepo>();
builder.Services.AddScoped<INavigationDataRepo, NavigationDataRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

DBSeeding.PrepPop(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
