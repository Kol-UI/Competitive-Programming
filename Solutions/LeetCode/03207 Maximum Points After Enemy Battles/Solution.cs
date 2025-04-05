// Maximum Points After Enemy Battles
namespace CompetitiveProgramming.LeetCode.MaximumPointsAfterEnemyBattles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaximumPoints(int[] enemyEnergies, int currentEnergy)
    {
        var (sum, min) = GetAuxiliaryData(enemyEnergies);
        if (min > currentEnergy) return 0;
        var totalEnergy = currentEnergy + sum;
        var rs = totalEnergy / min;
        return rs;
    }
    
    private (long sum, int min) GetAuxiliaryData(int[] enemyEnergies)
    {
        long sum = enemyEnergies[0];
        var min = enemyEnergies[0];
        for (int i = 1; i < enemyEnergies.Length; i++)
        {
            sum += enemyEnergies[i];
            min = Math.Min(min, enemyEnergies[i]);
        }
        return (sum - min, min);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Points After Enemy Battles");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}