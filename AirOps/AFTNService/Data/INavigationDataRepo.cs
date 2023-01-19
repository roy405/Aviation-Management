using System.Collections.Generic;
using AFTNService.Models;

namespace AFTNService.Data
{
    public interface INavigationDataRepo
    {
        bool SaveChanges();

        IEnumerable<NavigationData> GetAllNavigationData();
        NavigationData GetNavigationDataById(int id);
        void CreateNavigationData(NavigationData navData);
    }
}