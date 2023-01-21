using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class CreateTarmacSafetyDto
    {
        [Required]
        public string? tarmacNo { get; set; }
        [Required]
        public string? tarmacZone { get; set; }
        [Required]
        public string? safetyPlan { get; set; }
        [Required]
        public string? status { get; set; }
        [Required]
        public string? situationDesc { get; set; }
    }
}