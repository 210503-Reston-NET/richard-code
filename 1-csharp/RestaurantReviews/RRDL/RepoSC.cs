using System.Collections.Generic;
using RRModels;

namespace RRDL
{
    public class RepoSC: IRepository
    {
        public List<Restaurant> GetAllRestaurants()
        {
            return RRSCStorage.Restaurants;
        } 
    }
}