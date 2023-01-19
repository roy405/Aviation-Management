using System.ComponentModel.DataAnnotations;

namespace AFTNService.Models
{
    public class NavigationData
    {
            [Key]
            [Required]
            public int Id {get; set;}

            [Required]
            public string? navDesc {get; set;}

            [Required]
            public string? naviationCoordinateLocationPair {get; set;}
    }
}