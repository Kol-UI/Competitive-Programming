// Jump Game V
namespace CompetitiveProgramming.LeetCode.JumpGameV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8618
public class Solution
{
    private int[] arr;
    private int d;
    private int[] memo;
    public int MaxJumps(int[] arr, int d) {
        this.arr = arr;
        this.d = d;
        int n = arr.Length;
        memo = new int[n];
        int answer = 1;

        for (int i = 0; i < n; i++){
            answer = Math.Max(answer, DFS(i));
        }
        return answer;
    }

    private int DFS(int index)
    {
        if (memo[index] != 0) return memo[index];
        int best = 1;

        for (int i = index - 1; i >= Math.Max(0, index - d); i--){
            if (arr[i] >= arr[index]) break;
            best = Math.Max(best, 1 + DFS(i));
        }

        for (int i = index + 1; i <= Math.Min(arr.Length - 1, index + d); i++){
            if (arr[i] >= arr[index]) break;
            best = Math.Max(best, 1 + DFS(i));
        }
        return memo[index] = best;
    }
}
#pragma warning restore CS8618

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxJumps([6,4,14,6,8,13,9,7,10,6,12], 2), 4),
            ResultTester.CheckResult<int>(solution.MaxJumps([3,3,3,3,3], 3), 1),
            ResultTester.CheckResult<int>(solution.MaxJumps([7,6,5,4,3,2,1], 1), 7),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jump Game V");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}