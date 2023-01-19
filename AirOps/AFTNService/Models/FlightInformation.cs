using System.ComponentModel.DataAnnotations;

namespace AFTNService.Models
{
    public class FlightInformation
    {
        [Key]
        [Required]
        public int Id {get; set;}

        [Required]     
        public string? aircraftRegistrationNo {get; set;}

        [Required]
        public string? currentAllocatedFlight {get; set;}

        [Required]
        public string? currentStatus {get; set;}

        [Required]
        public string? aircraftDetails {get; set;}

        [Required]
        public string? hangerInfo {get; set;}
    }
}