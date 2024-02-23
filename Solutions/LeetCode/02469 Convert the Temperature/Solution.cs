// Convert the Temperature


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConverttheTemperature
{
    public class Solution
    {
        public static double[] ConvertTemperature(double celsius)
        {
            double[] ans = { celsius + 273.15, celsius * 1.80 + 32.00 };
            return ans;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double[]>(Solution.ConvertTemperature(36.50), new double[]{309.65000,97.70000}),
                ResultTester.CheckResult<double[]>(Solution.ConvertTemperature(122.11), new double[]{395.26000,251.79800}),
            };
            return results;
        }
    }
}