// Taking Maximum Energy From the Mystic Dungeon
namespace CompetitiveProgramming.LeetCode.TakingMaximumEnergyFromtheMysticDungeon;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumEnergy(int[] energy, int k)
    {
        int n = energy.Length;
        int[] ans = new int[n];
        int m = energy[n-1];
        for (int i = (n-1); i >(n-1-k);i--)
        {
            ans[i] = energy[i];
            m = Math.Max(m, ans[i]);
        }
        for (int i = (n-1-k) ; i >= 0; i--)
        {
            ans[i] = energy[i] + ans[i+k];
            m = Math.Max(m, ans[i]);
        }
        return m;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Taking Maximum Energy From the Mystic Dungeon");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}