using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public class PassengerBNGRepo : IPassengerBNGRepo
    {
        private readonly AppDbContext _context;

        public PassengerBNGRepo(AppDbContext  context)
        {
            _context = context;
        }

        public void CreatePassengerBNG(PassengerBoardingAndGuidance passengerBoardingAndGuidance)
        {
            if(passengerBoardingAndGuidance == null)
            {
                throw new ArgumentNullException(nameof(passengerBoardingAndGuidance));
            }
            _context.PassengerBNG.Add(passengerBoardingAndGuidance);
        }

        public IEnumerable<PassengerBoardingAndGuidance> GetallPassengerBNG()
        {
            return _context.PassengerBNG.ToList();
        }

        public PassengerBoardingAndGuidance GetPassengerBNGById(int id)
        {
            return _context.PassengerBNG.FirstOrDefault(pbng => pbng.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}