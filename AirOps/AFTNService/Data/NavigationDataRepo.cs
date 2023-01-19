using System.Collections.Generic;
using System.Linq;
using AFTNService.Models;

namespace AFTNService.Data
{
    public class NavigationDataRepo : INavigationDataRepo
    {
        private readonly AppDbContext _context;

        public NavigationDataRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateNavigationData(NavigationData navData)
        {
            if(navData == null)
            {
                throw new ArgumentNullException(nameof(navData));
            }
            _context.NavData.Add(navData);
        }

        public IEnumerable<NavigationData> GetAllNavigationData()
        {
            return _context.NavData.ToList();
        }

        public NavigationData GetNavigationDataById(int id)
        {
           return _context.NavData.FirstOrDefault(nd => nd.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}