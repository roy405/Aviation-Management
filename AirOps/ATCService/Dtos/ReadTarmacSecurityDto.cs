using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class ReadTarmacSecurityDto
    {
        public int Id { get; set; }
        public string? tarmacNo { get; set; }
        public string? tarmacZone { get; set; }
        public string? assignedSecurityTeam { get; set; }
        public string? opsDesc { get; set; }
    }
}