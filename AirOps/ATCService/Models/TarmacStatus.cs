using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class TarmacStatus
    {
        [Key]
        [Required]
        public int Id { get; set; }

    }
}