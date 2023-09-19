namespace RestaurantPOS.Api.Domains;

public class MenuItem
{
    public Guid MenuItemId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public List<RecipeItem>? Ingredients { get; set; } // List of ingredients in the recipe
}