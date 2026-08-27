namespace CompetitiveProgramming.Algorithms;

public class TaxCalculator
{
    // Approach 1 : Basic tax-exclusive (GST style)
    // Tax is added on top of the base price.
    public static decimal CalculateGST(decimal basePrice, decimal ratePercent)
    {
        if (basePrice < 0) throw new ArgumentException("Price must be non-negative.");
        if (ratePercent < 0) throw new ArgumentException("Rate must be non-negative.");
        return Math.Round(basePrice * (ratePercent / 100m), 2, MidpointRounding.AwayFromZero);
    }

    public static decimal TotalWithGST(decimal basePrice, decimal ratePercent) => basePrice + CalculateGST(basePrice, ratePercent);

    // Approach 2 : Tax-inclusive extraction (VAT style)
    // Extract the tax amount from a price that already includes tax.
    public static decimal ExtractVAT(decimal grossPrice, decimal ratePercent)
    {
        if (grossPrice < 0) throw new ArgumentException("Price must be non-negative.");
        if (ratePercent < 0) throw new ArgumentException("Rate must be non-negative.");
        decimal net = grossPrice / (1 + ratePercent / 100m);
        return Math.Round(grossPrice - net, 2, MidpointRounding.AwayFromZero);
    }

    public static decimal NetFromGross(decimal grossPrice, decimal ratePercent) => Math.Round(grossPrice / (1 + ratePercent / 100m), 2, MidpointRounding.AwayFromZero);

    // Approach 3 : Compound / cascading tax
    // Apply multiple independent tax rates sequentially.
    public static decimal CalculateCompoundTax(decimal basePrice, params decimal[] rates)
    {
        if (basePrice < 0) throw new ArgumentException("Price must be non-negative.");
        decimal total = basePrice;
        foreach (var r in rates)
        {
            if (r < 0) throw new ArgumentException("All rates must be non-negative.");
            total += total * (r / 100m);
        }
        return Math.Round(total - basePrice, 2, MidpointRounding.AwayFromZero);
    }

    public static decimal TotalWithCompoundTax(decimal basePrice, params decimal[] rates) => Math.Round(basePrice + CalculateCompoundTax(basePrice, rates), 2, MidpointRounding.AwayFromZero);
}