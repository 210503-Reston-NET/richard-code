using System;
using System.Collections.Generic;
namespace RRModels
{
    public class Restaurant
    {
      // Class Members
        // 1. Constructor - use this to create an instance of the class
        // 2. Fields - defines the characteristics of a class
        // 3. Methods - defines the behavior of a class
        // 4. Properties - also known as smart fields, are accessor methods used to access private backing fields (private fields)
        // *Note that properties are analogous to Java getter and setter
        // * Property naming convention uses PascalCase (like methods)

         public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }
        public Restaurant()
        {

        }
       
        public string Name { get; }
        public string City { get; }
      
        public string State { get; }
       
        public List <Review> Reviews { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State} \n Review: \n{Reviews.ToString()}";
        }
    }
}
