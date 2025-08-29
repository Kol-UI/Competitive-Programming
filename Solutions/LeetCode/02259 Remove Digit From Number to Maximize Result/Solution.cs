// Remove Digit From Number to Maximize Result
namespace CompetitiveProgramming.LeetCode.RemoveDigitFromNumbertoMaximizeResult;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string RemoveDigit(string number, char digit)
    {
        for(int i = 0; i < number.Length - 1; i++)
        {
            if(number[i] == digit && number[i + 1] > digit)
            {
                return number.Remove(i, 1);
            }
        }
        for(int i = number.Length - 1; i >= 0; i--)
        {
            if(number[i] == digit)
            {
                return number.Remove(i, 1);
            }
        }

        return "-1"; 
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.RemoveDigit("123", '3'), "12"),
            ResultTester.CheckResult<string>(solution.RemoveDigit("1231", '1'), "231"),
            ResultTester.CheckResult<string>(solution.RemoveDigit("551", '5'), "51"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Digit From Number to Maximize Result");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}