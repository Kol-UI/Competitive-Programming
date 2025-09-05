// Minimum Operations to Make the Integer Zero
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMaketheIntegerZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MakeTheIntegerZero(int num1, int num2)
    { 
       for (int k = 1; k <= 60; k++)
       {
            long target = (long)num1 - (long)k * num2;

            if (target < 0) continue;

            int bits = BitCount(target);

            if (bits <= k && k <= target) 
                return k;  
        }
        return -1;
    }

    private int BitCount(long n)
    {
       int count = 0;
       while (n > 0)
       {
            count += (int)(n & 1);
            n >>= 1;
        }
       return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MakeTheIntegerZero(3, -2), 3),
            ResultTester.CheckResult<int>(solution.MakeTheIntegerZero(5, 7), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make the Integer Zero");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}