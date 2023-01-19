namespace AFTNService.Dtos
{
    public class ReadFlightPlanDto
    {
        public int Id {get; set;}
        public DateTime? takeOffDateTime {get; set;}
        public DateTime? landingDateTime {get; set;}
        public string? departureLocation {get; set;}
        public string? arrivalLocation {get; set;}
        public string? contacts {get; set;}
    }
}