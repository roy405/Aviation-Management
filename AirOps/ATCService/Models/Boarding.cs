using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class Boarding
    {
        [Key]
        [Required]
        public int Id { get; set; }

    }
}