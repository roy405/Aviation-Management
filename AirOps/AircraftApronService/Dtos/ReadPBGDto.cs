using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Dtos
{
    public class ReadPBGDto
    {
        public int Id {get; set;}
        public string? airlineNo {get; set;}
        public DateTime? activityDateTime {get; set;}
        public string? assignedTeamDet {get; set;}
    }
}