// N-Queens II
namespace CompetitiveProgramming.LeetCode.NQueensII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TotalNQueens(int n)
    {
        int count = 0;
        bool[] cols = new bool[n];
        bool[] diag1 = new bool[2 * n - 1];
        bool[] diag2 = new bool[2 * n - 1];
        
        void Backtrack(int row)
        {
            if (row == n)
            {
                count++;
                return;
            }
            
            for (int col = 0; col < n; col++)
            {
                if (cols[col] || diag1[row + col] || diag2[row - col + n - 1])
                    continue;
                
                cols[col] = diag1[row + col] = diag2[row - col + n - 1] = true;
                
                Backtrack(row + 1);
                
                cols[col] = diag1[row + col] = diag2[row - col + n - 1] = false;
            }
        }
        
        Backtrack(0);
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.TotalNQueens(4), 2),
            ResultTester.CheckResult<int>(solution.TotalNQueens(1), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("N-Queens II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}