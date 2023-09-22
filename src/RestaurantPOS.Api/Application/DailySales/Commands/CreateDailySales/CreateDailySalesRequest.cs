using RestaurantPOS.Api.Application.Constants;

namespace RestaurantPOS.Application.DailySales.Commands.CreateDailySales;

public record CreateDailySalesRequest
{
    public Guid BranchId { get; set;}
    public DateTime Date { get; set; }
    public int BillNo { get; set; }
    public SalesType Type { get; set; }
    public decimal SalesTotal { get;}
    public decimal? AmountReceived { get;}
    public decimal? BalancePaid { get; }
    public List<SoldMenuItemCreateRequest> SoldMenuItems { get; set; } = new List<SoldMenuItemCreateRequest>();
}

public record SoldMenuItemCreateRequest
{
    public Guid SoldMenuItemId { get; set; }
    public Guid DailySalesId { get; set; }
    public Guid MenuItemId { get; set; }
    public decimal Price { get; set; }
    public decimal QuantitySold { get; set; }
}


