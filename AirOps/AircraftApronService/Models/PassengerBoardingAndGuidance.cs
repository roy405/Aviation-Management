using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Models
{
    public class PassengerBoardingAndGuidance
    {
        [Key]
        [Required]
        public int Id {get; set;}

        [Required]
        public string? airlineNo {get; set;}

        [Required]
        public DateTime? activityDateTime {get; set;}

        [Required]
        public string? assignedTeamDet {get; set;}
    }
}