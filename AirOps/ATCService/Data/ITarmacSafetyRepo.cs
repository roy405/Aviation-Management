using System.Collections.Generic;
using ATCService.Models;

namespace ATCService.Data
{
    public interface ITarmacSafetyRepo
    {
        bool SaveChanges();
        IEnumerable<TarmacSafetyExec> GetAllTarmacSafetyExecs();
        TarmacSafetyExec GetTarmacSafetyExecById(int id);
        void CreateTarmacSafetyExec(TarmacSafetyExec tarmacSafetyExec);
    }
}