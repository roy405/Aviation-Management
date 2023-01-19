using System.Collections.Generic;
using System.Linq;
using AFTNService.Models;

namespace AFTNService.Data
{
    public class RunwayInformationRepo : IRunwayInformationRepo
    {
        private readonly AppDbContext _context;

        public RunwayInformationRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateRunwayInformation(RunwayInformation runwayInfo)
        {
            if(runwayInfo == null)
            {
                throw new ArgumentNullException(nameof(runwayInfo));
            }
            _context.RunwayInfo.Add(runwayInfo);
        }

        public IEnumerable<RunwayInformation> GetAllRunwayInfo()
        {
            return _context.RunwayInfo.ToList();
        }

        public RunwayInformation GetRunwayInfoById(int id)
        {
            return _context.RunwayInfo.FirstOrDefault(ri => ri.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}