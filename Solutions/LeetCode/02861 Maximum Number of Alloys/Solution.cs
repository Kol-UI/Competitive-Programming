// Maximum Number of Alloys
namespace CompetitiveProgramming.LeetCode.MaximumNumberofAlloys;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int MaxNumberOfAlloys(int n, int k, int budget, IList<IList<int>> composition, IList<int> stock, IList<int> cost) {
        var result = 0;
        for (int i = 0; i < composition.Count; i++)
        {
            var result0 = MaxNumberOfAlloys(budget, composition[i].ToList(), stock, cost);
            if (result < result0) result = result0;
        }
        return result;
    }

    private int MaxNumberOfAlloys(int budget, List<int> composition, IList<int> stock, IList<int> cost)
    {
        var index0 = 0;
        var index1 = int.MaxValue;
        while (index1 - index0 > 1)
        {
            var indexMid = (index0 + index1) / 2;
            var totalCost = GetTotalCost(indexMid, composition, stock, cost);
            if (totalCost <= budget)
            {
                index0 = indexMid;
            }
            else
            {
                index1 = indexMid;
            }
        }
        return index0;
    }
    
    private long GetTotalCost(int indexMid, List<int> composition, IList<int> stock, IList<int> cost)
    {
        var totalCost = 0L;
        for (int i = 0; i < composition.Count; i++)
        {
            long metalI = indexMid * (long)composition[i] - stock[i];
            long costI = metalI > 0 ? metalI * cost[i] : 0;
            totalCost += costI;
        }
        return totalCost;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Alloys");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}