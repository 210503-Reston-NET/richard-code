using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI

{
    public class MainMenu:IMenu
    {
        public void Start(){
            bool repeat=true;
            do{
            Console.WriteLine("Welcome to my Restaurant Review App");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[0] View Restaurant");
            Console.WriteLine("[1] Exit");
            string input=Console.ReadLine();

            switch(input){
                case "0":
                    ViewRestaurant();
                    break;
                case "1":
                    Console.WriteLine("Good By");
                    repeat=false;
                    break;
                default:
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
        
    }
   
        
    
}