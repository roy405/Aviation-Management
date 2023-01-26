using Microsoft.EntityFrameworkCore;
using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    //This is to do with creating a connection with the database.
    public class AppDbContext : DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        public DbSet<Cargo>? Cargos {get; set;}
        public DbSet<AircraftApronHandling>? APHandling {get; set;}
        public DbSet<PassengerBoardingAndGuidance>? PassengerBNG {get; set;}

    }
}