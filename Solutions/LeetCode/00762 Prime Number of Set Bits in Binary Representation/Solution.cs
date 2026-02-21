// Prime Number of Set Bits in Binary Representation
namespace CompetitiveProgramming.LeetCode.PrimeNumberofSetBitsinBinaryRepresentation;

using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountPrimeSetBits(int left, int right)
    {
        HashSet<int> primes = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19 };
        int result = 0;

        for (int i = left; i <= right; i++)
        {
            int bitCount = BitOperations.PopCount((uint)i);
            if (primes.Contains(bitCount))
                result++;
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountPrimeSetBits(6, 10), 4),
            ResultTester.CheckResult<int>(solution.CountPrimeSetBits(10, 15), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Prime Number of Set Bits in Binary Representation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}