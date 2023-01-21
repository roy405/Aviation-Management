using System.Collections.Generic;
using System.Linq;
using ATCService.Models;

namespace ATCService.Data
{
    public class BoardingRepo : IBoardingRepo
    {
        private readonly AppDbContext _context;

        public BoardingRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateBoarding(Boarding boarding)
        {
            if(boarding == null)
            {
                throw new ArgumentNullException(nameof(boarding));
            }
            _context.BoardingData.Add(boarding);
        }

        public IEnumerable<Boarding> GetAllBoardings()
        {
           return _context.BoardingData.ToList();
        }

        public Boarding GetBoardingById(int id)
        {
            return _context.BoardingData.FirstOrDefault(b => b.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }

}