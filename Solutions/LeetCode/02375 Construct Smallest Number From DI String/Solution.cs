// Construct Smallest Number From DI String
namespace CompetitiveProgramming.LeetCode.ConstructSmallestNumberFromDIString;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string SmallestNumber(string pattern)
    {
        var result = new StringBuilder();
        var stack = new Stack<int>();

        for (int i = 0; i <= pattern.Length; i++)
        {
            stack.Push(i + 1);

            if (i == pattern.Length || pattern[i] == 'I')
            {
                while (stack.Count > 0)
                    result.Append(stack.Pop());
            }
        }

        return result.ToString();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.SmallestNumber("IIIDIDDD"), "123549876"),
            ResultTester.CheckResult<string>(solution.SmallestNumber("DDD"), "4321")
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct Smallest Number From DI String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}
