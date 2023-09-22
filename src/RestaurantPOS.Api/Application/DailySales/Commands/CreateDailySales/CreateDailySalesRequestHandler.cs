namespace RestaurantPOS.Application.DailySales.Commands.CreateDailySales;

public class CreateDailySalesRequestHandler : IRequestHandler<CreateDailySalesRequest, Guid>
{
    private readonly ApplicationDbContext _context;

    public CreateDailySalesRequestHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateDailySalesRequest request, CancellationToken cancellationToken)
    {
        var entity = new DailySales
        {
            Id = Guid.NewGuid(),
            BranchId = request.BranchId,
            Date = request.Date,
            BillNo = request.BillNo,
            Type = request.Type,
            SalesTotal = request.SalesTotal,
            AmountReceived = request.AmountReceived,
            BalancePaid = request.BalancePaid,
            SoldMenuItems = new List<SoldMenuItem>()
        };

        foreach(var soldMenuItem in request.SoldMenuItems)
        {
            entity.Add(new SoldMenuItem
            {
                Id = Guid.NewGuid(),
                DailySalesId = entity.Id,
                MenuItemId = soldMenuItem.MenuItemId,
                Price = soldMenuItem.Price,
                QuantitySold = soldMenuItem.QuantitySold
            });    
        }


        _context.DailySales.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}