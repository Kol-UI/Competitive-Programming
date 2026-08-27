namespace CompetitiveProgramming.Algorithms;

public class ChangeMaker
{
    // Approach 1 : Greedy
    // Always picks the largest coin that fits.
    // Correct for standard systems (USD, EUR, GBP...) but not guaranteed otherwise.
    public static Dictionary<int, int> GreedyChange(int amountCents, int[] denominations)
    {
        if (amountCents < 0) throw new ArgumentException("Amount must be non-negative.");
        if (denominations == null || denominations.Length == 0)
            throw new ArgumentException("At least one denomination required.");
        if (denominations.Any(d => d <= 0))
            throw new ArgumentException("All denominations must be positive.");

        var sorted = denominations.OrderByDescending(d => d).ToArray();
        var result = new Dictionary<int, int>();

        foreach (var coin in sorted)
        {
            int count = amountCents / coin;
            if (count > 0)
                result[coin] = count;
            amountCents %= coin;
        }

        if (amountCents != 0)
            throw new InvalidOperationException("Cannot make exact change with given denominations.");

        return result;
    }

    // Approach 2 : Dynamic Programming
    // Finds the minimum number of coins for any denomination set.
    public static Dictionary<int, int> DPChange(int amountCents, int[] denominations)
    {
        if (amountCents < 0) throw new ArgumentException("Amount must be non-negative.");
        if (denominations == null || denominations.Length == 0)
            throw new ArgumentException("At least one denomination required.");
        if (denominations.Any(d => d <= 0))
            throw new ArgumentException("All denominations must be positive.");

        // dp[i] = min coins to make amount i; coinUsed[i] = last coin picked
        var dp = new int[amountCents + 1];
        var coinUsed = new int[amountCents + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;

        for (int i = 1; i <= amountCents; i++)
        {
            foreach (var coin in denominations)
            {
                if (coin <= i && dp[i - coin] != int.MaxValue && dp[i - coin] + 1 < dp[i])
                {
                    dp[i] = dp[i - coin] + 1;
                    coinUsed[i] = coin;
                }
            }
        }

        if (dp[amountCents] == int.MaxValue)
            throw new InvalidOperationException("Cannot make exact change with given denominations.");

        // Reconstruct coin counts
        var result = new Dictionary<int, int>();
        int remaining = amountCents;
        while (remaining > 0)
        {
            int coin = coinUsed[remaining];
            result[coin] = result.GetValueOrDefault(coin) + 1;
            remaining -= coin;
        }
        return result;
    }

    // Get total number of coins in a result
    public static int TotalCoins(Dictionary<int, int> change) => change.Values.Sum();
}