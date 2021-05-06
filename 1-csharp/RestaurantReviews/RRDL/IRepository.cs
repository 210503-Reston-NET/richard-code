using System;
using RRModels;
using System.Collections.Generic;
namespace RRDL
{
    public interface IRepository
    {
         List<Restaurant> GetAllRestaurants();
    }
}
