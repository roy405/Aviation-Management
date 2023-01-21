using System.Collections.Generic;
using System.Linq;
using ATCService.Models;

namespace ATCService.Data
{
    public class TarmacSecurityRepo : ITarmacSecurityRepo
    {
        private readonly AppDbContext _context;

        public TarmacSecurityRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateTarmacSecurityExec(TarmacSecurityExec tarmacSecurityExec)
        {
            if(tarmacSecurityExec == null)
            {
                throw new ArgumentNullException(nameof(tarmacSecurityExec));
            }
            _context.TarmacSecurityExecs.Add(tarmacSecurityExec);
        }

        public IEnumerable<TarmacSecurityExec> GetAllTarmacSecurityExecs()
        {
            return _context.TarmacSecurityExecs.ToList();
        }

        public TarmacSecurityExec GetTarmacSecurityExecById(int id)
        {
            return _context.TarmacSecurityExecs.FirstOrDefault(tsec => tsec.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }
    }
}