using System.Collections.Generic;
using System.Linq;
using AFTNService.Models;

namespace AFTNService.Data
{
    public class StatusReportRepo : IStatusReportRepo
    {
        public readonly AppDbContext _context;

        public StatusReportRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateStatusReport(StatusReport statusReport)
        {
            if(statusReport == null)
            {
                throw new ArgumentNullException(nameof(statusReport));
            }
            _context.StatusReport.Add(statusReport);
        }

        public IEnumerable<StatusReport> GetAllStatusReport()
        {
            return _context.StatusReport.ToList();
        }

        public StatusReport GetStatusReportbyId(int id)
        {
           return _context.StatusReport.FirstOrDefault( sr => sr.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}