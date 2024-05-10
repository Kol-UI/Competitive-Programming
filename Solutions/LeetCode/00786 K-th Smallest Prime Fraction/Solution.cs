// K-th Smallest Prime Fraction

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthSmallestPrimeFraction
{
    public class Solution
    {
        public static int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            var factors = new SortedDictionary<double, int[]>();

            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    double fraction = (double)arr[i] / arr[j];
                    factors[fraction] = new int[] { arr[i], arr[j] };
                }
            }

            var key = factors.Keys.ElementAt(k - 1);

            return factors[key];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.KthSmallestPrimeFraction(new int[]{1,2,3,5}, 3), new int[]{2,5}),
                ResultTester.CheckResult<int[]>(Solution.KthSmallestPrimeFraction(new int[]{1,7}, 1), new int[]{1,7}),
            };
            return results;
        }
    }
}