// Special Binary String
namespace CompetitiveProgramming.LeetCode.SpecialBinaryString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System.Collections.Generic;

public class Solution
{
    public string MakeLargestSpecial(string s)
    {
        List<string> parts = new List<string>();

        int count = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1') count++;
            else count--;
            if (count == 0)
            {
                string inner = MakeLargestSpecial(s.Substring(start + 1, i - start - 1));
                parts.Add("1" + inner + "0");
                start = i + 1;
            }
        }

        parts.Sort((a, b) => string.Compare(b, a));
        return string.Join("", parts);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MakeLargestSpecial("11011000"), "11100100"),
            ResultTester.CheckResult<string>(solution.MakeLargestSpecial("10"), "10")
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Special Binary String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}