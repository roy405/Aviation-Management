using System.ComponentModel.DataAnnotations;

namespace AFTNService.Dtos
{
    public class ReadFlightInfoDto
    {
        public int Id {get; set;}

        public string? aircraftRegistrationNo {get; set;}

        public string? currentAllocatedFlight {get; set;}

        public string? currentStatus {get; set;}

        public string? aircraftDetails {get; set;}

        public string? hangerInfo {get; set;}
    }       
}