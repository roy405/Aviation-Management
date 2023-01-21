using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class TarmacSecurityExec
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? tarmacNo { get; set; }
        [Required]
        public string? tarmacZone { get; set; }
        [Required]
        public string? assignedSecurityTeam { get; set; }
        [Required]
        public string? opsDesc { get; set; }
    }
}