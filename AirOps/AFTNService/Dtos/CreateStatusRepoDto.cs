using System.ComponentModel.DataAnnotations;

namespace AFTNService.Dtos
{
    public class CreateStatusReportDto
    {
        [Required]
        public string? reportDesc {get; set;}

        [Required]
        public string? safetyMessage {get; set;}

        [Required]
        public string? envMessage {get; set;}

        [Required]
        public string? weatherInfo {get; set;}

        [Required]
        public string? geoMaterial {get; set;}

        [Required]
        public string? disruptionMessages {get; set;}
    }
}