// Prime Arrangements

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PrimeArrangements
{
    public class Solution
    {
        public static int NumPrimeArrangements(int n)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int primesCount= primes.Count(p => p <= n);

            long f1 = fact(n - primesCount) ;
            long f2 = fact(primesCount);

            return (int)((f1 * f2 ) % 1000000007);

            static long fact(int n) => n > 1?(n * fact(n - 1)) % 1000000007: 1; 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IEnumerable<string> names = new string[] { "Ryan", "Mark" };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumPrimeArrangements(5), 12),
                ResultTester.CheckResult<int>(Solution.NumPrimeArrangements(100), 682289015),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Prime Arrangements");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}