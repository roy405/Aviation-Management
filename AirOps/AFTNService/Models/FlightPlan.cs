using System.ComponentModel.DataAnnotations;

namespace AFTNService.Models
{
    public class FlightPlan
    {
        [Key]
        [Required]
        public int Id {get; set;}

        [Required]
        public DateTime? takeOffDateTime {get; set;}

        [Required]
        public DateTime? landingDateTime {get; set;}

        [Required]
        public string? departureLocation {get; set;}

        [Required]
        public string? arrivalLocation {get; set;}

        [Required]
        public string? contacts {get; set;}
    }
}