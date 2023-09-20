using RestaurantPOS.Api.Domains.Constants;

namespace RestaurantPOS.Api.Domains;

public class MenuItem
{
    public Guid MenuItemId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public ServingType ServingType { get; set; }
    public Guid MenuId { get; set; }
    public Menu Menu { get; set; } = new Menu();
    public List<RecipeItem>? Recipes { get; set; }
    public List<SoldMenuItem> SoldItems { get; set; } = new List<SoldMenuItem>();
}