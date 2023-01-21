using System.Collections.Generic;
using System.Linq;
using ATCService.Models;

namespace ATCService.Data
{
    public class TarmacSafetyRepo : ITarmacSafetyRepo
    {
        private readonly AppDbContext _context;

        public TarmacSafetyRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateTarmacSafetyExec(TarmacSafetyExec tarmacSafetyExec)
        {
            if(tarmacSafetyExec == null)
            {
                throw new ArgumentNullException(nameof(tarmacSafetyExec));
            }
            _context.TarmacSafetyExecs.Add(tarmacSafetyExec);
        }

        public IEnumerable<TarmacSafetyExec> GetAllTarmacSafetyExecs()
        {
            return _context.TarmacSafetyExecs.ToList();
        }

        public TarmacSafetyExec GetTarmacSafetyExecById(int id)
        {
            return _context.TarmacSafetyExecs.FirstOrDefault(tse => tse.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}