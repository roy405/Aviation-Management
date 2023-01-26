using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public static class DBSeed
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedPBNGData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedAAHData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedCargoData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedPBNGData(AppDbContext context)
        {
            if (!context.PassengerBNG.Any())
            {
                Console.WriteLine("---> Seeding Passenger Boarding and Gudance Data...");

                context.PassengerBNG.AddRange(
                    new PassengerBoardingAndGuidance() { airlineNo = "AX443", activityDateTime = new DateTime(2023, 5, 21), assignedTeamDet = "Team 1" },
                     new PassengerBoardingAndGuidance() { airlineNo = "TG221", activityDateTime = new DateTime(2023, 5, 19), assignedTeamDet = "Team 4" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Passenger Boarding and Gudance data already exists");
            }
        }

        private static void SeedAAHData(AppDbContext context)
        {
            if (!context.APHandling.Any())
            {
                Console.WriteLine("---> Seeding Aircraft Apron Handling Data...");

                context.APHandling.AddRange(
                    new AircraftApronHandling() { aircraftCleaningStatus = "Completed", aircraftDrainageStatus = "Undergoing", aircraftCateringStatus = "Standby", aircraftFuelingStatus="Undergoing" },
                     new AircraftApronHandling() { aircraftCleaningStatus = "Undergoing", aircraftDrainageStatus = "Completed", aircraftCateringStatus = "Undergoing", aircraftFuelingStatus="Standby" },
                      new AircraftApronHandling() { aircraftCleaningStatus = "Standby", aircraftDrainageStatus = "Standby", aircraftCateringStatus = "Completed", aircraftFuelingStatus="Completed" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Aircraft Apron Handling Data already exists");
            }
        }

        private static void SeedCargoData(AppDbContext context)
        {
            if (!context.Cargos.Any())
            {
                Console.WriteLine("---> Seeding Cargo Data...");

                context.Cargos.AddRange(
                    new Cargo() { cargoNo = "CGO1123", itemQuantity = 5, assignedHandler = "Handler A", status = "Loaded" },
                    new Cargo() { cargoNo = "CGO4432", itemQuantity = 10, assignedHandler = "Handler D", status = "Loaded" },
                      new Cargo() { cargoNo = "CGO2321", itemQuantity = 15, assignedHandler = "Handler Team 6", status = "Standby" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Cargo Data already exists");
            }
        }
    }
}