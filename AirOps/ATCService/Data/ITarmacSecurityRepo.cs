using System.Collections.Generic;
using ATCService.Models;

namespace ATCService.Data
{
    public interface ITarmacSecurityRepo
    {
        bool SaveChanges();
        IEnumerable<TarmacSecurityExec> GetAllTarmacSecurityExecs();
        TarmacSecurityExec GetTarmacSecurityExecById(int id);
        void CreateTarmacSecurityExec(TarmacSecurityExec tarmacSecurityExec);
    }
}