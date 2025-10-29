// Smallest Number With All Set Bits
namespace CompetitiveProgramming.LeetCode.SmallestNumberWithAllSetBits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SmallestNumber(int n)
    {
        int x = 1;
        while (!(x >= n) || !IsAllSetBits(x))
        {
            x = NextAllSetBitsNumber(x);
            // x = NextAllSetBitsNumber_BitManipulation(x);
        }
        return x;
    }

    private static int NextAllSetBitsNumber(int x) => x * 2 + 1;
    private static int NextAllSetBitsNumber_BitManipulation(int x) => (x << 1) | 1;
    private static bool IsAllSetBits(int x) => x > 0 && (x & (x + 1)) == 0;
}

public class Solution2
{
    public int SmallestNumber(int n)
    {
        int x = 1;
        while (!(x >= n) || !IsAllSetBits(x))
        {
            x = NextAllSetBitsNumber_BitManipulation(x);
        }
        return x;
    }

    private static int NextAllSetBitsNumber(int x) => x * 2 + 1;
    private static int NextAllSetBitsNumber_BitManipulation(int x) => (x << 1) | 1;
    private static bool IsAllSetBits(int x) => x > 0 && (x & (x + 1)) == 0;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        Solution2 solution2 = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SmallestNumber(5), 7),
            ResultTester.CheckResult<int>(solution.SmallestNumber(10), 15),
            ResultTester.CheckResult<int>(solution.SmallestNumber(3), 3),
            ResultTester.CheckResult<int>(solution2.SmallestNumber(5), 7),
            ResultTester.CheckResult<int>(solution2.SmallestNumber(10), 15),
            ResultTester.CheckResult<int>(solution2.SmallestNumber(3), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Number With All Set Bits");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}