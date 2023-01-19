using System.Collections.Generic;
using AFTNService.Models;

namespace AFTNService.Data
{
    public interface IStatusReportRepo
    {
        bool SaveChanges();

        IEnumerable<StatusReport> GetAllStatusReport();
        StatusReport GetStatusReportbyId(int id);
        void CreateStatusReport(StatusReport statusReport);
    }
}