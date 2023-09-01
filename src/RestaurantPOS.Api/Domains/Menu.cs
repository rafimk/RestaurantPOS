namespace RestaurantPOS.Api.Domains;

public class Menu
{
    public int MenuId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<MenuItem> Items { get; set; } = new List<MenuItem>();
}