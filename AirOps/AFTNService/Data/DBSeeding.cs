using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using AFTNService.Models;


namespace AFTNService.Data
{
    public static class DBSeeding
    {
        public static void PrepPop(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedFlightInfoData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedFlightPlanData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedNavData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedRunwayInfo(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedStatusReport(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        //Seed Flight Information
        private static void SeedFlightInfoData(AppDbContext context)
        {
            if (!context.FlightInfo.Any())
            {
                Console.WriteLine("---> Seeding Flight Info Data...");

                context.FlightInfo.AddRange(
                    new FlightInformation() { aircraftRegistrationNo = "AX4233", currentAllocatedFlight = "nil", currentStatus = "available", aircraftDetails = "large jet", hangerInfo = "HG001" },
                     new FlightInformation() { aircraftRegistrationNo = "BO1123", currentAllocatedFlight = "nil", currentStatus = "available", aircraftDetails = "jumbo jet", hangerInfo = "HG002" },
                      new FlightInformation() { aircraftRegistrationNo = "SE554", currentAllocatedFlight = "nil", currentStatus = "taxi", aircraftDetails = "medium jet", hangerInfo = "HG003" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Flight Info data already");
            }
        }

        //Seed Flight Plan Data
        private static void SeedFlightPlanData(AppDbContext context)
        {
            if (!context.FlightPlan.Any())
            {
                Console.WriteLine("---> Seeding Flight Info Data...");

                context.FlightPlan.AddRange(
                    new FlightPlan() { takeOffDateTime = new DateTime(2023, 1, 5), landingDateTime = new DateTime(), departureLocation = "Texas", arrivalLocation = "Sydney", contacts = "ATC 441" },
                     new FlightPlan() { takeOffDateTime = new DateTime(2023, 5, 21), landingDateTime = new DateTime(), departureLocation = "Melbourne", arrivalLocation = "Singapore", contacts = "ATC 484" },
                      new FlightPlan() { takeOffDateTime = new DateTime(2023, 4, 15), landingDateTime = new DateTime(), departureLocation = "Stockholm", arrivalLocation = "Colorado", contacts = "ATC 110" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Flight Info data already");
            }
        }

        //Seed Navigation Data 
        private static void SeedNavData(AppDbContext context)
        {
            if (!context.NavData.Any())
            {
                Console.WriteLine("---> Seeding Flight Info Data...");

                context.NavData.AddRange(
                    new NavigationData() { navDesc = "Texas - Sydney Nav Data", naviationCoordinateLocationPair = "A-B, 56 North, 21 West B-C 21 West, 45 South C-D 24 West, 25 North"},
                     new NavigationData() { navDesc = "Melbourne - Singapore Nav Data", naviationCoordinateLocationPair = "A-B, 93 South, 15 East, B-C 16 North, 80 East C-D 67 North, 44 East" },
                      new NavigationData() { navDesc = "Stockholm - Colorado Nav Data", naviationCoordinateLocationPair = "A-B 16 South, 45 West B-C21 South, 23 East C-D57 South, 53 West"}
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Flight Info data already");
            }
        }

        //Seed Runway Information 
        private static void SeedRunwayInfo(AppDbContext context)
        {
            if (!context.RunwayInfo.Any())
            {
                Console.WriteLine("---> Seeding Flight Info Data...");

                context.RunwayInfo.AddRange(
                    new RunwayInformation() { runwayStatus = "Available", runwayUseDateTime = new DateTime(2023, 4, 21), location = "Zone A" },
                     new RunwayInformation() { runwayStatus = "Unavailable", runwayUseDateTime = new DateTime(2023, 2, 16), location = "Zone D" },
                      new RunwayInformation() { runwayStatus = "Unavailable", runwayUseDateTime = new DateTime(2023, 3, 4), location = "Zone C" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Flight Info data already");
            }
        }

        //Seed Status Report
        private static void SeedStatusReport(AppDbContext context)
        {
            if (!context.StatusReport.Any())
            {
                Console.WriteLine("---> Seeding Flight Info Data...");

                context.StatusReport.AddRange(
                    new StatusReport()
                    {
                        reportDesc = "report1",
                        safetyMessage = "sm1",
                        envMessage = "env- clear",
                        weatherInfo = "clear",
                        geoMaterial = "rubble",
                        disruptionMessages = "clear"
                    },
                     new StatusReport()
                     {
                         reportDesc = "report2",
                         safetyMessage = "sm2",
                         envMessage = "env- fog",
                         weatherInfo = "hazy",
                         geoMaterial = "rubble",
                         disruptionMessages = "Beware- Fog: Vision issue"
                     },
                      new StatusReport()
                      {
                          reportDesc = "report3",
                          safetyMessage = "sm3",
                          envMessage = "env- drizzle",
                          weatherInfo = "Overcast",
                          geoMaterial = "rubble",
                          disruptionMessages = "Beware- Damaging Winds"
                      }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Flight Info data already");
            }
        }
    }
}