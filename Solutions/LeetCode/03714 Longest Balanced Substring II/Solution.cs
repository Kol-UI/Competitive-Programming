// Longest Balanced Substring II
namespace CompetitiveProgramming.LeetCode.LongestBalancedSubstringII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestBalanced(string s)
    {
        int len = FindOneDistinct(s);

        len = Math.Max(len, FindTwoDistinct('a', 'b', 'c', s));
        len = Math.Max(len, FindTwoDistinct('a', 'c', 'b', s));
        len = Math.Max(len, FindTwoDistinct('b', 'c', 'a', s));

        len = Math.Max(len, FindThreeDistinct(s));

        return len;
    }

    int FindOneDistinct(string s)
    {
        int n = s.Length;
        int len = 0;
        int count = 1;
        for (int i = 1; i < n; i++)
        {
            if (s[i] == s[i - 1]) count++;
            else count = 1;
            len = Math.Max(len, count);
        }

        return Math.Max(len, count);
    }

    int FindTwoDistinct(char a, char b, char c, string s)
    {
        int n = s.Length;
        int len = 0;
        int count = 0;
        Dictionary<int, int> map = [];
        map[count] = -1;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == c)
            {
                count = 0;
                map.Clear();
                map[count] = i;
                continue;
            }
            if (s[i] == a) count++;
            else if (s[i] == b) count--;
            if (map.TryGetValue(count, out int value)) len = Math.Max(len, i - value);
            else map[count] = i;
        }

        return len;
    }

    int FindThreeDistinct(string s)
    {
        int len = 0;
        int n = s.Length;
        int[] count = new int[3];
        Dictionary<(int, int), int> map = [];
        map[(0, 0)] = -1;
        for (int i = 0; i < n; i++)
        {
            count[s[i] - 'a']++;
            var key = (count[0] - count[1], count[1] - count[2]);
            if (map.TryGetValue(key, out int value)) len = Math.Max(len, i - value);
            else map[key] = i;
        }

        return len;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Balanced Substring II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}