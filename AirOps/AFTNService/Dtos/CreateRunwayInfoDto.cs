using System.ComponentModel.DataAnnotations;

namespace AFTNService.Dtos
{
    public class CreateRunwayInfoDto
    {
        [Required]
        public string? runwayStatus {get; set;}
        [Required]
        public DateTime? runwayUseDateTime {get; set;}
        [Required]
        public string? location {get; set;}   
    }
}