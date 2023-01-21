using System.Collections.Generic;
using ATCService.Models;

namespace ATCService.Data
{
    public interface ICommsRepo
    {
        bool SaveChanges();
        IEnumerable<Comms> GetAllComms();
        Comms GetCommsById(int id);
        void CreateComms(Comms comms);
    }
}