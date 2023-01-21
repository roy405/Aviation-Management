using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class Boarding
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? gateNo { get; set; }
        [Required]
        public string? flightNo { get; set; }
        [Required]
        public string? gateArea { get; set; }
        [Required]
        public string? gateStatus { get; set; }
        [Required]
        public string? assignedPersonnel { get; set; }

    }
}