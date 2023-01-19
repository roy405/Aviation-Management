using System.ComponentModel.DataAnnotations;

namespace AFTNService.Models
{
    public class RunwayInformation
    {
        [Key]
        [Required]
        public int Id {get; set;}

        [Required]
        public string? runwayStatus {get; set;}

        [Required]
        public DateTime? runwayUseDateTime {get; set;}

        [Required]
        public string? location {get; set;}       
    }
}