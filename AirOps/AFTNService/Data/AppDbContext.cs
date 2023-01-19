using Microsoft.EntityFrameworkCore;
using AFTNService.Models;

namespace AFTNService.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt): base (opt)
        {

        }

        public DbSet<FlightInformation>? FlightInfo{get; set;}
        public DbSet<FlightPlan>? FlightPlan{get; set;}
        public DbSet<NavigationData>? NavData{get; set;}
        public DbSet<RunwayInformation>? RunwayInfo{get; set;}
        public DbSet<StatusReport>? StatusReport{get; set;}
    }
}