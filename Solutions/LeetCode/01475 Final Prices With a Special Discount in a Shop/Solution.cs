// Final Prices With a Special Discount in a Shop

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FinalPricesWithaSpecialDiscountinaShop
{
    public class Solution
    {
        public int[] FinalPrices(int[] prices)
        {
            int n = prices.Length;
            int[] result = new int[n];
            Array.Copy(prices, result, n);

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[i] <= prices[stack.Peek()])
                {
                    int j = stack.Pop();
                    result[j] = prices[j] - prices[i];
                }
                stack.Push(i);
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(solution.FinalPrices(new int[]{8,4,6,2,3}), new int[]{4,2,4,2,3}),
                ResultTester.CheckResult<int[]>(solution.FinalPrices(new int[]{1,2,3,4,5}), new int[]{1,2,3,4,5}),
                ResultTester.CheckResult<int[]>(solution.FinalPrices(new int[]{10,1,1,6}), new int[]{9,0,1,6}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Final Prices With a Special Discount in a Shop");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}