namespace AFTNService.Dtos
{
    public class ReadStatusReportDto
    {
        public int Id {get; set;}
        public string? reportDesc {get; set;}
        public string? safetyMessage {get; set;}
        public string? envMessage {get; set;}
        public string? weatherInfo {get; set;}
        public string? geoMaterial {get; set;}
        public string? disruptionMessages {get; set;}
    }
}