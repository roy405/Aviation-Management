using System.ComponentModel.DataAnnotations;

namespace AircraftApronService.Dtos
{
    public class ReadCargoDto
    {
        public int Id {get; set;}
        public string? cargoNo {get; set;}
        public int? itemQuantity {get; set;}
        public string? assignedHandler {get; set;}
        public string? status {get; set;}
    }
}