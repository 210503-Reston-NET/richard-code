using System.Collections.Generic;
using RRModels;
using RRDL;
using System;
namespace RRBL
{
    public class RestaurantBL : IRestaurantBL
    {
       // Some things to note:
        // BL classes are in charge of processing/ sanitizing/ further validating data
        // As the name suggests its in charge of processing logic. For example, how does the ordering process
        // work in a store app. 
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the DL 
        private IRepository _repo;
        //private IRepository _repo=new RepoSC();
        public RestaurantBL(IRepository repo)
        {
            _repo = repo;
        }
        public List<Restaurant> GetAllRestaurants()
        {
            //Note that this method isn't really dependent on any inputs/parameters, I can just directly call the 
            // DL method in charge of getting all restaurants
            return _repo.GetAllRestaurants();
        }

         public Restaurant AddRestaurant(Restaurant restaurant)
        {
            // Todo: call a repo method that adds a restaurant
            if (_repo.GetRestaurant(restaurant) != null)
            {
                throw new Exception("Restaurant already exists :<");
            }
            return _repo.AddRestaurant(restaurant);
        }
    }
}