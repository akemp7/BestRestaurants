using System.Collections.Generic;

namespace Best.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            this.Cuisines = new HashSet<Cuisine>();
        }

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Cuisine> Cuisines { get; set; }
    }
}