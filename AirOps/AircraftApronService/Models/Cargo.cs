using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Models
{
    public class Cargo
    {
        [Key]
        [Required]
        public int Id {get; set;}
        
        [Required]
        public string? cargoNo {get; set;}

        [Required]
        public int? itemQuantity {get; set;}

        [Required]
        public string? assignedHandler {get; set;}

        [Required]
        public string? status {get; set;}
    }
}