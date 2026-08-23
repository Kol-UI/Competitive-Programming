// Majority Frequency Characters
namespace CompetitiveProgramming.LeetCode.MajorityFrequencyCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System.Text;

public class Solution
{
    public string MajorityFrequencyGroup(string s)
    {
        int[] freq = new int[26];

        for(int i = 0; i < s.Length; i++)
            freq[s[i] - 'a']++;

        Dictionary<int, StringBuilder> dic = new Dictionary<int, StringBuilder>();

        for (int i = 0; i < 26; i++)
        {
            if (!dic.ContainsKey(freq[i]))
                dic[freq[i]] = new StringBuilder();
            if (freq[i] != 0)
                dic[freq[i]].Append((char) ('a' + i));
        }

        int max = 0;
        int maxkey = 0;

        foreach (int key in dic.Keys)
        {
            if (dic[key].Length > max)
            {
                maxkey = key;
                max = dic[key].Length;
            }
            else if (dic[key].Length == max && key > maxkey)
            {
                maxkey = key;
                max = dic[key].Length;
            }
        }

        return dic[maxkey].ToString();

    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MajorityFrequencyGroup("aaabbbccdddde"), "ab"),
            ResultTester.CheckResult<string>(solution.MajorityFrequencyGroup("abcd"), "abcd"),
            ResultTester.CheckResult<string>(solution.MajorityFrequencyGroup("pfpfgi"), "fp"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Majority Frequency Characters");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}