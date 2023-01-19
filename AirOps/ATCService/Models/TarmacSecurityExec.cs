using System.ComponentModel.DataAnnotations;

namespace ATCService.Models
{
    public class TarmacSecurityExec
    {
        [Key]
        [Required]
        public int Id { get; set; }

    }
}