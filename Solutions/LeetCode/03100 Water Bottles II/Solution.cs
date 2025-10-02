// Water Bottles II
namespace CompetitiveProgramming.LeetCode.WaterBottlesII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        int totalDrunk = numBottles;
        int empty = numBottles;

        while (empty >= numExchange)
        {
            empty -= numExchange;
            totalDrunk += 1;
            empty += 1;
            numExchange += 1;
        }

        return totalDrunk;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Water Bottles II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}