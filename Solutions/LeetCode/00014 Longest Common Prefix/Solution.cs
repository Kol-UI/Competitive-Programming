// Longest Common Prefix
namespace CompetitiveProgramming.LeetCode.LongestCommonPrefix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    // Horizontal Scanning
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        string longestCommonPrefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(longestCommonPrefix) != 0)
            {
                longestCommonPrefix = longestCommonPrefix.Substring(0, longestCommonPrefix.Length - 1);
                if (longestCommonPrefix == "") return "";
            }
        }
        return longestCommonPrefix;
    }
}

public class Solution2
{
    // Vertical Scanning
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != c)
                    return strs[0].Substring(0, i);
            }
        }
        return strs[0];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        Solution2 solution2 = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.LongestCommonPrefix(new string[]{"flower","flow","flight"}), "fl"),
            ResultTester.CheckResult<string>(solution.LongestCommonPrefix(new string[]{"dog","racecar","car"}), ""),
            ResultTester.CheckResult<string>(solution2.LongestCommonPrefix(new string[]{"flower","flow","flight"}), "fl"),
            ResultTester.CheckResult<string>(solution2.LongestCommonPrefix(new string[]{"dog","racecar","car"}), ""),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Common Prefix");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}