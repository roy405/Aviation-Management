using System.ComponentModel.DataAnnotations;

namespace ATCService.Dtos
{
    public class ReadBoardingDto
    {
        public int Id { get; set; }
        public string? gateNo { get; set; }
        public string? flightNo { get; set; }
        public string? gateArea { get; set; }
        public string? gateStatus { get; set; }
        public string? assignedPersonnel { get; set; }

    }
}