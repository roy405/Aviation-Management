using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class CreateTarmacSecurityDto
    {
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