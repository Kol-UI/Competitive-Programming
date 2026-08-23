// Sort Vowels by Frequency
namespace CompetitiveProgramming.LeetCode.SortVowelsbyFrequency;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string SortVowels(string s)
    {
        HashSet<char> vowels = new HashSet<char>("aeiou");
        Dictionary<char, int> frequency = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                if (!frequency.ContainsKey(s[i]))
                    frequency.Add(s[i], 1);
                else
                    frequency[s[i]]++;
            }
        }

        var sort = frequency.Keys.OrderByDescending(c => frequency[c]).ToList();
        List<char> sorted = new List<char>();

        foreach (char c in sort)
        {
            for (int i = 0; i < frequency[c]; i++)
            {
                sorted.Add(c);
            }
        }

        char[] arr = s.ToCharArray();
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (vowels.Contains(arr[i]))
            {
                arr[i] = sorted[index];
                index++;
            }
        }

        return new string(arr);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.SortVowels("leetcode"), "leetcedo"),
            ResultTester.CheckResult<string>(solution.SortVowels("aeiaaioooa"), "aaaaoooiie"),
            ResultTester.CheckResult<string>(solution.SortVowels("baeiou"), "baeiou"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sort Vowels by Frequency");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}