using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class TarmacSafetyExec
    {
        [Key]
        [Required]
        public int Id { get; set; }
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