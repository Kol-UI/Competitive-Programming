// Intersection of Multiple Arrays
namespace CompetitiveProgramming.LeetCode.IntersectionofMultipleArrays;

using System.Collections;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8605

public class Solution
{
    public IList<int> Intersection(int[][] nums)
    {
        Hashtable ht = new Hashtable();
        List<int> outputList = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0;  j < nums[i].Length; j++)
            {
                int curr = nums[i][j];
                if (ht.Contains(curr))
                    ht[curr] = (int)ht[curr] + 1;
                else
                    ht.Add(curr, 1);
            }
        }
        foreach (var item in ht.Keys)
        {
            if ((int)ht[item] == nums.Count())
            {
                outputList.Add((int)item);
            }

        }
        outputList.Sort();
        return outputList;
    }
}

#pragma warning restore CS8605

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.Intersection([[3,1,2,4,5],[1,2,3,4],[3,4,5,6]]), [3,4]),
            ResultTester.CheckResult<IList<int>>(solution.Intersection([[1,2,3],[4,5,6]]), []),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Intersection of Multiple Arrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}