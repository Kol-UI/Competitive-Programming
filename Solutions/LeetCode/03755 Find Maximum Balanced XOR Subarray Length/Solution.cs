// Find Maximum Balanced XOR Subarray Length
namespace CompetitiveProgramming.LeetCode.FindMaximumBalancedXORSubarrayLength;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxBalancedSubarray(int[] values)
    {
        int best = 0;
        var seen = new Dictionary<(int x, int p), int>();
        seen.Add((0, 0), -1);
        
        int mask = values[0];
        int parity = values[0] % 2 == 0 ? 1 : -1;
        seen.Add((mask, parity), 0);
        
        for (int i = 1; i < values.Length; i++)
        {
            mask ^= values[i];
            parity += values[i] % 2 == 0 ? 1 : -1;
            var current = (mask, parity);
            
            if (seen.ContainsKey(current))
            {
                best = Math.Max(best, i - seen[current]);
            }
            else
            {
                seen.Add(current, i);
            }
        }
        
        return best;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Maximum Balanced XOR Subarray Length");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}