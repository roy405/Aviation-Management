using System.ComponentModel.DataAnnotations;

namespace AFTNService.Models
{
    public class StatusReport
    {
        [Key]
        [Required]
        public int Id {get; set;}

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