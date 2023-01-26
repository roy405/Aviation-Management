using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Dtos
{
    public class CreateAAHDto
    {
        [Required]
        public string? aircraftCleaningStatus {get; set;}
        
        [Required]
        public string? aircraftDrainageStatus {get; set;}

        [Required]
        public string? aircraftCateringStatus {get; set;}

        [Required]
        public string? aircraftFuelingStatus {get; set;}
    }
}