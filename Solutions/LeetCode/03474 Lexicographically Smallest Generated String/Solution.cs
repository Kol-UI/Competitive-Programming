// Lexicographically Smallest Generated String
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestGeneratedString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string GenerateString(string str1, string str2)
    {
        int n = str1.Length;
        int m = str2.Length;
        int len = n + m - 1;
        char[] ans = new char[len];

        for (int i = 0; i < n; i++)
        {
            if (str1[i] == 'T')
            {
                for (int j = 0; j < m; j++)
                {
                    if (ans[i + j] != '\0' && ans[i + j] != str2[j])
                    {
                        return "";
                    }
                    ans[i + j] = str2[j];
                }
            }
        }

        for (int i = 0; i < len; i++)
        {
            if (ans[i] == '\0')
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    ans[i] = c;
                    bool valid = true;

                    int start = Math.Max(0, i - m + 1);
                    int end = Math.Min(n - 1, i);

                    for (int j = start; j <= end; j++)
                    {
                        if (str1[j] == 'F')
                        {
                            bool match = true;
                            for (int k = 0; k < m; k++)
                            {
                                if (ans[j + k] != str2[k])
                                {
                                    match = false;
                                    break;
                                }
                            }
                            if (match)
                            {
                                valid = false;
                                break;
                            }
                        }
                    }

                    if (valid)
                    {
                        break;
                    }
                    else
                    {
                        ans[i] = '\0';
                    }
                }

                if (ans[i] == '\0') return "";
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (str1[i] == 'F')
            {
                bool match = true;
                for (int j = 0; j < m; j++)
                {
                    if (ans[i + j] != str2[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return "";
            }
        }

        return new string(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Smallest Generated String");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}