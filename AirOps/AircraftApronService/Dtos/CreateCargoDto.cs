using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Dtos
{
    public class CreateCargoDto
    {
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