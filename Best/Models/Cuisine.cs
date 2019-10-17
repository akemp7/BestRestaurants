using System.Collections.Generic;

namespace Best.Models
{
    public class Cuisine
    {
    
        public string Name { get; set; }
        public int CuisineId { get; set; }
        public virtual ICollection<Cuisine> Cuisines { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurants { get; set; }
    }
}