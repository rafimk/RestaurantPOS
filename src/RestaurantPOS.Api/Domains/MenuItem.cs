namespace RestaurantPOS.Api.Domains;

public class MenuItem
{
    public int MenuItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public List<RecipeItem> Ingredients { get; set; } // List of ingredients in the recipe
}