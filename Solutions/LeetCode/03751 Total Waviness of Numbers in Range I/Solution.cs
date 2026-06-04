// Total Waviness of Numbers in Range I
namespace CompetitiveProgramming.LeetCode.TotalWavinessofNumbersinRangeI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TotalWaviness(int num1, int num2)
    {
        int res = 0;

        for (int i = num1; i <= num2; i++)
        {
            var temp = i.ToString();
            int waviness = 0; 
            for (int j = 1; j < temp.Length - 1; j++)
            {
                if (temp[j - 1] < temp[j] && temp[j] > temp[j + 1])
                {
                    waviness++;
                }

                if (temp[j - 1] > temp[j] && temp[j] < temp[j + 1])
                {
                    waviness++;
                }
            }
            res += waviness;
        }
        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.TotalWaviness(120, 130), 3),
            ResultTester.CheckResult<int>(solution.TotalWaviness(198, 202), 3),
            ResultTester.CheckResult<int>(solution.TotalWaviness(4848, 4848), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Total Waviness of Numbers in Range I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}