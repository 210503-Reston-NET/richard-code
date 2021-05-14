using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Reviews = new HashSet<Review>();
        }

       public Restaurant(string name, string city, string state){
this.Name=name;
this.City=city;
this.State=state;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
