// Distance Between Bus Stops

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DistanceBetweenBusStops
{
    public class Solution
    {
        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            var min = Math.Min(start, destination);
            var max = Math.Max(start, destination);
            var sum = distance[min..max].Sum();
            return Math.Min(sum, distance.Sum() - sum);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistanceBetweenBusStops(new int[] {1,2,3,4}, 0, 1), 1),
                ResultTester.CheckResult<int>(Solution.DistanceBetweenBusStops(new int[] {1,2,3,4}, 4, 2), 3),
                ResultTester.CheckResult<int>(Solution.DistanceBetweenBusStops(new int[] {1,2,3,4}, 0, 3), 4),

            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1184");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}