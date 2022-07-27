using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Review
  {
    public Review()
    {
      // this.Restaurants = new HashSet<Restaurant>();
    }

    public int ReviewId{ get; set; }
    public int Rating{ get; set; }
    public string ReviewText{ get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
    
  }
}