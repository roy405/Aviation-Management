using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class CreateCommsDto
    {
        [Required]
        public string? commsChannelNo { get; set; }
        [Required]
        public string? commsDepartment { get; set; }
        [Required]
        public string? participants { get; set; }
        [Required]
        public string? messages { get; set; }

    }
}