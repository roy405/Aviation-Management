using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class Comms
    {
        [Key]
        [Required]
        public int Id { get; set; }

    }
}