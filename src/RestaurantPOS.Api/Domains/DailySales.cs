using RestaurantPOS.Api.Domains.Constants;

namespace RestaurantPOS.Api.Domains;

public class DailySales
{
    public Guid DailySalesId { get; set; }
    public DateTime Date { get; set; }
    public int BillNo { get; set; }
    public SalesType Type { get; set; }
    public decimal SalesTotal { get;}
    public decimal? AmountReceived { get;}
    public decimal? BalancePaid { get; }
    public List<SoldMenuItem> SoldMenuItems { get; set; } = new List<SoldMenuItem>();
}
