// Check if Every Row and Column Contains All Numbers
namespace CompetitiveProgramming.LeetCode.CheckifEveryRowandColumnContainsAllNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckValid(int[][] matrix)
    {
        List<HashSet<int>> rowSeen = new List<HashSet<int>>();
        List<HashSet<int>> colSeen = new List<HashSet<int>>();

        for (int i = 0; i < matrix.Length; i++)
        {
            rowSeen.Add(new HashSet<int>());
            colSeen.Add(new HashSet<int>());
        }

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                int value = matrix[row][col];
                if (rowSeen[row].Contains(value) || colSeen[col].Contains(value))
                {
                    return false;
                }
                rowSeen[row].Add(value);
                colSeen[col].Add(value);
            }
        }

        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[][] matrix1 = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {3, 1, 2},
            new int[] {2, 3, 1}
        };
        int[][] matrix2 = new int[][]
        {
            new int[] {1, 1, 1},
            new int[] {1, 2, 3},
            new int[] {1, 2, 3}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.CheckValid(matrix1), true),
            ResultTester.CheckResult<bool>(solution.CheckValid(matrix2), false)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Every Row and Column Contains All Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}