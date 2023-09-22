namespace RestaurantPOS.Api.Domains;

public class Branch
{
     public Guid Id { get; set; }
     public string Name { get; set; } = string.Empty;
     public string Address  {get; set; } = string.Empty;
}