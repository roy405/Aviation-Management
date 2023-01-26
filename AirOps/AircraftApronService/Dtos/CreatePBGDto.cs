using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Dtos
{
    public class CreatePBGDto
    {
        [Required]
        public string? airlineNo { get; set; }

        [Required]
        public DateTime? activityDateTime { get; set; }

        [Required]
        public string? assignedTeamDet { get; set; }
    }
}