using System.Collections.Generic;
using System.Linq;
using ATCService.Models;

namespace ATCService.Data
{
    public class CommsRepo : ICommsRepo
    {
        private readonly AppDbContext _context;

        public CommsRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateComms(Comms comms)
        {
            if(comms == null)
            {
                throw new ArgumentNullException(nameof(comms));
            }
            _context.Communications.Add(comms);
        }

        public IEnumerable<Comms> GetAllComms()
        {
            return _context.Communications.ToList();
        }

        public Comms GetCommsById(int id)
        {
            return _context.Communications.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}