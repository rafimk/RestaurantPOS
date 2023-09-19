using RestaurantPOS.Api.Domains.Constants;

namespace RestaurantPOS.Api.Domains;

public class UnitOfMeasurement
{
    public Guid Id { get; set; } 
    public string Short { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public UnitOfMeasurementType Type { get; set; }

}
