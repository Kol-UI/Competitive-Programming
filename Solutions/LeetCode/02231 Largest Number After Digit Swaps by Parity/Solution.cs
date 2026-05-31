// Largest Number After Digit Swaps by Parity
namespace CompetitiveProgramming.LeetCode.LargestNumberAfterDigitSwapsbyParity;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LargestInteger(int num)
    {
        string number1 = Convert.ToString(num);
        var number = number1.ToCharArray();
        for (int i = 0; i < number.Length; i++)
        {
            for(int j = i + 1; j< number.Length; j++)
            {
                if ((number[i] - '0') % 2 == (number[j] - '0') % 2 && number[i] < number[j])
                {
                    char temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }
            }
        }
        return int.Parse(new string(number));    
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LargestInteger(1234), 3412),
            ResultTester.CheckResult<int>(solution.LargestInteger(65875), 87655),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Number After Digit Swaps by Parity");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}