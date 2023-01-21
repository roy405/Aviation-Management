using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using ATCService.Models;

namespace ATCService.Data
{
    public static class DBSeed
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedBoardingData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedCommsData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedTarmacSafetyData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedTarmacSecurityData(serviceScope.ServiceProvider.GetService<AppDbContext>());

            }
        }

        //Seeding Boarding Data
        private static void SeedBoardingData(AppDbContext context)
        {
            if (!context.BoardingData.Any())
            {
                Console.WriteLine("---> Seeding Boarding Data...");

                context.BoardingData.AddRange(
                    new Boarding() { gateNo = "BG01", flightNo = "SG554", gateArea = "section1", gateStatus = "buys", assignedPersonnel = "personnel 1" },
                    new Boarding() { gateNo = "BG03", flightNo = "AX112", gateArea = "section2", gateStatus = "active", assignedPersonnel = "personnel 2" },
                    new Boarding() { gateNo = "BG05", flightNo = "TG221", gateArea = "section6", gateStatus = "active", assignedPersonnel = "personnel 3" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Boarding Data Already Exists");
            }
        }

        //Seeding Comms Data
        private static void SeedCommsData(AppDbContext context)
        {
            if (!context.Communications.Any())
            {
                Console.WriteLine("---> Seeding Comms Data...");

                context.Communications.AddRange(
                    new Comms()
                    {
                        commsChannelNo = "",
                        commsDepartment = "",
                        participants = "participants list 1",
                        messages = "message1"
                    }, new Comms()
                    {
                        commsChannelNo = "",
                        commsDepartment = "",
                        participants = "participants list 2",
                        messages = "message2"
                    }, new Comms()
                    {
                        commsChannelNo = "",
                        commsDepartment = "",
                        participants = "participants list 3",
                        messages = "message3"
                    }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> Comms Data Already Exists");
            }
        }

        //Seeding TarmacSafetyExec Data
        private static void SeedTarmacSafetyData(AppDbContext context)
        {
            if (!context.TarmacSafetyExecs.Any())
            {
                Console.WriteLine("---> Seeding Data...");

                context.TarmacSafetyExecs.AddRange(
                    new TarmacSafetyExec() { tarmacNo = "001", tarmacZone = "section1", safetyPlan = "Plan A", status = "standby", situationDesc = "Description1" },
                    new TarmacSafetyExec() { tarmacNo = "003", tarmacZone = "section2", safetyPlan = "Pan B, Plan C", status = "standby", situationDesc = "Description2" },
                    new TarmacSafetyExec() { tarmacNo = "005", tarmacZone = "section6", safetyPlan = "Plan G", status = "under revision", situationDesc = "Description3" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> We already have data");
            }
        }

        //Seeding TarmacSecurityExec Data
        private static void SeedTarmacSecurityData(AppDbContext context)
        {
            if (!context.TarmacSecurityExecs.Any())
            {
                Console.WriteLine("---> Seeding Data...");

                context.TarmacSecurityExecs.AddRange(
                    new TarmacSecurityExec() { tarmacNo = "001", tarmacZone = "section1", assignedSecurityTeam = "team10", opsDesc = "Grounds" },
                    new TarmacSecurityExec() { tarmacNo = "003", tarmacZone = "section2", assignedSecurityTeam = "team02", opsDesc = "Gates" },
                    new TarmacSecurityExec() { tarmacNo = "005", tarmacZone = "section6", assignedSecurityTeam = "team07", opsDesc = "Hangers and Taxi Section" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> We already have data");
            }
        }
    }
}