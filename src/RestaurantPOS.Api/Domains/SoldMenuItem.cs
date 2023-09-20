namespace RestaurantPOS.Api.Domains;

public class SoldMenuItem
{
    public Guid SoldMenuItemId { get; set; }
    public Guid DailySalesId { get; set; }
    public DailySales DailySales { get; set; } = new DailySales();
    public Guid MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; } = new MenuItem();
    public decimal Price { get; set; }
    public decimal QuantitySold { get; set; }
}
