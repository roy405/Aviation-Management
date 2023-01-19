using System.Collections.Generic;
using AFTNService.Models;

namespace AFTNService.Data
{
    public interface IRunwayInformationRepo
    {
        bool SaveChanges();

        IEnumerable<RunwayInformation> GetAllRunwayInfo();
        RunwayInformation GetRunwayInfoById(int id);
        void CreateRunwayInformation(RunwayInformation runwayInfo);
    }
}