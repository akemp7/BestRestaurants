using System.Collections.Generic; //maybe unnecessary?

namespace Best.Models
{
    public class Cuisine
    {
        public string Name { get; set; }
        public int CuisineId { get; set; }
        // public virtual ICollection<Cuisine> Cuisines { get; set; } //this is not necessary?
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}