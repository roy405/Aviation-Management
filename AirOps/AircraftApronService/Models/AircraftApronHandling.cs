using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Models
{
    public class AircraftApronHandling
    {
        [Key]
        [Required]
        public int Id {get; set;}

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