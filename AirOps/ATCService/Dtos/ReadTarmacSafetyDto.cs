using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class ReadTarmacSafetyDto
    {
        public int Id { get; set; }
        public string? tarmacNo { get; set; }
        public string? tarmacZone { get; set; }
        public string? safetyPlan { get; set; }
        public string? status { get; set; }
        public string? situationDesc { get; set; }
    }
}