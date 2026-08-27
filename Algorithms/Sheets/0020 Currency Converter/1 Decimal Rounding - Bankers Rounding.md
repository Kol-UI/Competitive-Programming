Decimal Rounding (Banker's Rounding)

Return rounded to the nearest even integer Banker's Rounding (Round Half to Even) Ties (x.5) round toward nearest even digit to reduce cumulative bias

```cs
public class BankersRounder
{
    // Approach 1: Built-in MidpointRounding.ToEven
    public static decimal RoundBuiltIn(decimal value, int decimals = 0) => Math.Round(value, decimals, MidpointRounding.ToEven);

    // Approach 2: Manual Implementation
    public static decimal RoundManual(decimal value, int decimals = 0)
    {
        decimal factor = (decimal)Math.Pow(10, decimals);
        decimal scaled = value * factor;
        decimal truncated = Math.Truncate(scaled);
        decimal remainder = scaled - truncated;

        decimal result;

        if (Math.Abs(remainder) == 0.5m)
        {
            // Tie: round toward nearest even
            bool truncatedIsEven = truncated % 2 == 0;
            result = truncatedIsEven ? truncated : truncated + Math.Sign(remainder);
        }
        else
        {
            // Normal rounding
            result = Math.Round(scaled, MidpointRounding.AwayFromZero);
        }

        return result / factor;
    }
}```