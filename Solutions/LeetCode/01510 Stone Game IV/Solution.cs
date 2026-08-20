// Stone Game IV
namespace CompetitiveProgramming.LeetCode.StoneGameIV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public bool WinnerSquareGame(int n) {
        int sq = (int)Math.Sqrt(n);
        if(sq*sq == n)
            return true;

        bool[] valid = new bool[n+1];
        List<int> sqs = new();
        
        for(int i = 1; i <= n; i++)
        {
            if(i <= sq)
            {
                valid[i*i] = true;
                sqs.Add(i*i);
            }

            if(valid[i])
                continue;

            bool isValid = false;
            foreach(int p in sqs)
            {
                if(p >= i)
                    break;

                if(!valid[i-p])
                {
                    isValid = true;
                    break;
                }
            }

            valid[i] = isValid;
        }

        return valid[n];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.WinnerSquareGame(1), true),
            ResultTester.CheckResult<bool>(solution.WinnerSquareGame(2), false),
            ResultTester.CheckResult<bool>(solution.WinnerSquareGame(4), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stone Game IV");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}