// Delete Columns to Make Sorted II
namespace CompetitiveProgramming.LeetCode.DeleteColumnstoMakeSortedII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int rows = strs.Length;
        int cols = strs[0].Length;

        bool[] sorted = new bool[rows - 1];
        int deletions = 0;

        for (int col = 0; col < cols; col++)
        {
            bool needDelete = false;

            for (int row = 0; row < rows - 1; row++)
            {
                if (!sorted[row] && strs[row][col] > strs[row + 1][col])
                {
                    needDelete = true;
                    break;
                }
            }

            if (needDelete)
            {
                deletions++;
            }
            else
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (strs[row][col] < strs[row + 1][col])
                    {
                        sorted[row] = true;
                    }
                }
            }
        }

        return deletions;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinDeletionSize(["ca","bb","ac"]), 1),
            ResultTester.CheckResult<int>(solution.MinDeletionSize(["xc","yb","za"]), 0),
            ResultTester.CheckResult<int>(solution.MinDeletionSize(["zyx","wvu","tsr"]), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Delete Columns to Make Sorted II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}