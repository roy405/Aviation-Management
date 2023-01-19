using System.ComponentModel.DataAnnotations;

namespace AFTNService.Dtos
{
    public class CreateNavDataDto
    {
        [Required]
        public string? navDesc { get; set; }

        [Required]
        public string? naviationCoordinateLocationPair { get; set; }
    }
}