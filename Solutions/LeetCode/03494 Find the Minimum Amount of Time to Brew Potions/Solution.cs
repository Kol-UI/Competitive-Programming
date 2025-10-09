// Find the Minimum Amount of Time to Brew Potions
namespace CompetitiveProgramming.LeetCode.FindtheMinimumAmountofTimetoBrewPotions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinTime(int[] skill, int[] mana)
    {
        int n = skill.Length;
        int m = mana.Length;
        long[] done = new long[n + 1];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                done[j + 1] = Math.Max(done[j + 1], done[j]) + (long)mana[i] * skill[j];

            for (int k = n - 1; k > 0; k--)
                done[k] = done[k + 1] - (long)mana[i] * skill[k];
        }

        return done[n];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Minimum Amount of Time to Brew Potions");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}