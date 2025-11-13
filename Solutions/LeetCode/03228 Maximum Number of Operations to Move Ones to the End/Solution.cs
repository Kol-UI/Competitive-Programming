// Maximum Number of Operations to Move Ones to the End
namespace CompetitiveProgramming.LeetCode.MaximumNumberofOperationstoMoveOnestotheEnd;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxOperations(string s)
    {
        int result = 0;
        int ones = 0;
        int i = 0;
        while (i < s.Length)
        {
            if (s[i] == '1') ones++;
            else
            {
                i++;
                while (i < s.Length)
                {
                    if (s[i] == '1') break;
                    i++;
                }
                i--;
                result += ones;
            }
            i++;
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
            ResultTester.CheckResult<int>(solution.MaxOperations("1001101"), 4),
            ResultTester.CheckResult<int>(solution.MaxOperations("00111"), 0)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Operations to Move Ones to the End");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}