using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Dtos
{
    public class ReadAAHDto
    {
        public int Id {get; set;}
        public string? aircraftCleaningStatus {get; set;}
        public string? aircraftDrainageStatus {get; set;}
        public string? aircraftCateringStatus {get; set;}
        public string? aircraftFuelingStatus {get; set;}
    }
}