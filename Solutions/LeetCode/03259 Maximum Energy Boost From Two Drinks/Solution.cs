// Maximum Energy Boost From Two Drinks
namespace CompetitiveProgramming.LeetCode.MaximumEnergyBoostFromTwoDrinks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxEnergyBoost(int[] energyDrinkA, int[] energyDrinkB)
    {
        var dic = new Dictionary<(int index, int drink), long>();
        var resultA = MaxEnergyBoost((0, 0), dic, energyDrinkA, energyDrinkB);
        var resultB = MaxEnergyBoost((0, 1), dic, energyDrinkA, energyDrinkB);
        var result = Math.Max(resultA, resultB);
        return result;
    }
    private long MaxEnergyBoost((int index, int drink) key, Dictionary<(int index, int drink), long> dic, int[] energyDrinkA, int[] energyDrinkB)
    {
        var result = 0L;
        if (key.index >= energyDrinkA.Length) return result;
        if (dic.ContainsKey(key)) return dic[key];
        if (key.drink == 0)
        {
            result = energyDrinkA[key.index];
            var resultA = MaxEnergyBoost((key.index + 1, 0), dic, energyDrinkA, energyDrinkB);
            var resultB = MaxEnergyBoost((key.index + 2, 1), dic, energyDrinkA, energyDrinkB);
            result += Math.Max(resultA, resultB);
        }
        else
        {
            result = energyDrinkB[key.index];
            var resultA = MaxEnergyBoost((key.index + 2, 0), dic, energyDrinkA, energyDrinkB);
            var resultB = MaxEnergyBoost((key.index + 1, 1), dic, energyDrinkA, energyDrinkB);
            result += Math.Max(resultA, resultB);
        }
        if (!dic.ContainsKey(key)) dic.Add(key, result);
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxEnergyBoost([1,3,1], [3,1,1]), 5),
            ResultTester.CheckResult<long>(solution.MaxEnergyBoost([4,1,1], [1,1,3]), 7),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Energy Boost From Two Drinks");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}