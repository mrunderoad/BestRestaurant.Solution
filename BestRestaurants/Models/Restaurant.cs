namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int restaurantId { get; set; }
    public string restaurantName { get; set; }
    public string restaurantAddress { get; set; }
    public int restaurantNumber { get; set; }
    public int cuisineId { get; set; } 
    public virtual Cuisine Cuisine { get; set; }
  }
}