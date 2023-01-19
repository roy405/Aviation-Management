using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class TarmacSafetyExec
    {
        [Key]
        [Required]
        public int Id { get; set; }

    }
}