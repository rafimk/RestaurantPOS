using RestaurantPOS.Api.Domains.Constants;

namespace RestaurantPOS.Api.Domains;

public class RecipeItem
{
    public int RecipeItemId { get; set; }
    public Ingredient Ingredient { get; set; }
    public decimal Quantity { get; set; } // Quantity of the ingredient needed for the recipe
    public UnitOfMeasurement Unit { get; set; } // Unit of measurement for the quantity
}