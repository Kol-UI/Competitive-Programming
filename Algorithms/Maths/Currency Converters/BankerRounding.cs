namespace CompetitiveProgramming.Algorithms;

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
}