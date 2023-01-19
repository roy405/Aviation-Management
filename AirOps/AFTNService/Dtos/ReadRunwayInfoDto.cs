namespace AFTNService.Dtos
{
    public class ReadRunwayInfoDto
    {
        public int Id {get; set;}
        public string? runwayStatus {get; set;}
        public DateTime? runwayUseDateTime {get; set;}
        public string? location {get; set;}   
    }


}