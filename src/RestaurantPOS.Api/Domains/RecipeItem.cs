﻿using RestaurantPOS.Api.Domains.Constants;

namespace RestaurantPOS.Api.Domains;

public class RecipeItem
{
    public Guid RecipeItemId { get; set; }
    public Ingredient Ingredient { get; set; } = new();
    public decimal Quantity { get; set; }
    public UnitOfMeasurement Unit { get; set; } = new();
}