// Longest Nice Substring
namespace CompetitiveProgramming.LeetCode.LongestNiceSubstring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string LongestNiceSubstring(string s)
    {
        int n = s.Length;
        string result = "";
        HashSet<char> totalUnique = new HashSet<char>();
        foreach (char c in s) totalUnique.Add(char.ToLower(c));
        int maxUniqueTarget = totalUnique.Count;

        for (int target = 1; target <= maxUniqueTarget; target++)
        {
            int start = 0, end = 0;
            int uniqueCount = 0;
            int niceCount = 0;

            int[] lower = new int[26];
            int[] upper = new int[26];

            while (end < n)
            {
                int idxEnd = char.ToLower(s[end]) - 'a';
                if (lower[idxEnd] == 0 && upper[idxEnd] == 0) uniqueCount++;

                if (char.IsLower(s[end])) lower[idxEnd]++;
                else upper[idxEnd]++;

                if (char.IsLower(s[end]) && lower[idxEnd] == 1 && upper[idxEnd] > 0) niceCount++;
                else if (char.IsUpper(s[end]) && upper[idxEnd] == 1 && lower[idxEnd] > 0) niceCount++;

                while (uniqueCount > target)
                {
                    int idxStart = char.ToLower(s[start]) - 'a';

                    if (lower[idxStart] > 0 && upper[idxStart] > 0)
                    {
                        if ((char.IsLower(s[start]) && lower[idxStart] == 1) || (char.IsUpper(s[start]) && upper[idxStart] == 1))
                            niceCount--;
                    }

                    if (char.IsLower(s[start])) lower[idxStart]--;
                    else upper[idxStart]--;

                    if (lower[idxStart] == 0 && upper[idxStart] == 0) uniqueCount--;
                    start++;
                }

                if (uniqueCount == target && uniqueCount == niceCount)
                {
                    if (end - start + 1 > result.Length)
                    {
                        result = s.Substring(start, end - start + 1);
                    }
                }
                end++;
            }
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.LongestNiceSubstring("YazaAay"), "aAa"),
            ResultTester.CheckResult<string>(solution.LongestNiceSubstring("Bb"), "Bb"),
            ResultTester.CheckResult<string>(solution.LongestNiceSubstring("c"), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Nice Substring");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}