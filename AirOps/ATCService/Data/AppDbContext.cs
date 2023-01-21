using Microsoft.EntityFrameworkCore;
using ATCService.Models;

namespace ATCService.Data
{
    //This is to do with creating a connection with the database.
    public class AppDbContext : DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        public DbSet<Boarding>? BoardingData {get; set;}
        public DbSet<Comms>? Communications {get; set;}
        public DbSet<TarmacSafetyExec>? TarmacSafetyExecs {get; set;}
        public DbSet<TarmacSecurityExec>? TarmacSecurityExecs {get; set;}
        
    }
}