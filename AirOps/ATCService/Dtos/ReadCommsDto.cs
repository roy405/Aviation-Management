using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class ReadCommsDto
    {
        public int Id { get; set; }
        public string? commsChannelNo { get; set; }
        public string? commsDepartment { get; set; }
        public string? participants { get; set; }
        public string? messages { get; set; }
    }
}