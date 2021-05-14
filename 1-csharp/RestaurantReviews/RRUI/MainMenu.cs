using System;
using RRModels;
using RRBL;
using RRDL;
using System.Collections.Generic;
namespace RRUI

{
    public class MainMenu:IMenu
    {
        private IMenu submenu;
        Action <string> doprintlog = ActionWriteLog;
        public void Start(){
            bool repeat=true;
            do{
                //Console.WriteLine("Welcome to my Restaurant Reviews Application!");
               /* Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] CRUD Restaurants");
                Console.WriteLine("[1] Exit");*/
                doprintlog("Welcome to my Restaurant Reviews Application!");
                doprintlog("What would you like to do?");
                doprintlog("[0] CRUD Restaurants");
                doprintlog("[1] Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        //TODO: Fix this
                       /* submenu = new RestaurantMenu(new RestaurantBL(new RepoFile()), new ValidationService());
                        submenu.Start();*/
                        submenu = MenuFactory.GetMenu("restaurant");
                        submenu.Start();
                        break;
                    case "1":
                        //exit
                        Console.WriteLine("Goodbye cruel world.");
                        repeat = false;
                        break;
                    default:
                        //invalid input
                        Console.WriteLine("Please input a valid option");
                        break;
                }
            }while(repeat);
        }

          private void ViewRestaurant()
        {
            //TODO: Remove the hardcoded restaurant and refer to a stored restaurant that exists
            Restaurant goodTaste = new Restaurant("Good Taste", "Baguio City", "Benguet");
            goodTaste.Reviews = new List<Review>
            {
                new Review{
                    Rating = 5,
                    Description = "A M A Z I N G"
                },
                new Review{
                    Rating = 5,
                    Description = "Good food for cheap."
                }
            };
            Console.WriteLine(goodTaste.ToString());
            foreach (Review review in goodTaste.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }

        private static void ActionWriteLog(string mssg){
            Console.WriteLine(mssg);
        }
        
    }
   
        
    
}