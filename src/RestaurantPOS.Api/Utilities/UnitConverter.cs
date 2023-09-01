using RestaurantPOS.Api.Domains.Constants;

namespace RestaurantPOS.Api.Utilities;

public class UnitConverter
{
    public static decimal ConvertToGrams(decimal quantity, UnitOfMeasurement unit)
    {
        switch (unit)
        {
            case UnitOfMeasurement.Kilogram:
                return quantity * 1000;
            case UnitOfMeasurement.Gram:
                return quantity;
            case UnitOfMeasurement.Liter:
                // Assuming 1 L = 1000 mL
                return quantity * 1000;
            case UnitOfMeasurement.Milliliter:
                return quantity;
            case UnitOfMeasurement.Box:
                // Define your conversion logic for boxes to grams here
                // For example, 1 box = 200 grams
                return quantity * 200;
            case UnitOfMeasurement.Number:
                // Define your conversion logic for numbers to grams here
                // For example, 1 number = 50 grams
                return quantity * 50;
            case UnitOfMeasurement.Dozen:
                // Define your conversion logic for dozens to grams here
                // For example, 1 dozen = 600 grams
                return quantity * 600;
            default:
                throw new ArgumentException("Invalid unit of measurement");
        }
    }

    public static decimal ConvertToMilliliters(decimal quantity, UnitOfMeasurement unit)
    {
        switch (unit)
        {
            case UnitOfMeasurement.Kilogram:
                // Assuming 1 kg = 1000 g
                return quantity * 1000;
            case UnitOfMeasurement.Gram:
                return quantity;
            case UnitOfMeasurement.Liter:
                return quantity * 1000;
            case UnitOfMeasurement.Milliliter:
                return quantity;
            case UnitOfMeasurement.Box:
                // Define your conversion logic for boxes to milliliters here
                // For example, 1 box = 5000 mL
                return quantity * 5000;
            case UnitOfMeasurement.Number:
                // Define your conversion logic for numbers to milliliters here
                // For example, 1 number = 100 mL
                return quantity * 100;
            case UnitOfMeasurement.Dozen:
                // Define your conversion logic for dozens to milliliters here
                // For example, 1 dozen = 1200 mL
                return quantity * 1200;
            default:
                throw new ArgumentException("Invalid unit of measurement");
        }
    }
}