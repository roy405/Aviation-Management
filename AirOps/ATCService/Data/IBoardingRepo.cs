using System.Collections.Generic;
using ATCService.Models;

namespace ATCService.Data
{
    public interface IBoardingRepo
    {
        bool SaveChanges();
        IEnumerable<Boarding> GetAllBoardings();
        Boarding GetBoardingById(int id);
        void CreateBoarding(Boarding boarding);
    }
}