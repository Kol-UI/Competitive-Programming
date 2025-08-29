// Find Resultant Array After Removing Anagrams
namespace CompetitiveProgramming.LeetCode.FindResultantArrayAfterRemovingAnagrams;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        var prev = string.Empty;
        var result = new List<string>();

        foreach (var word in words)
            if (prev != (prev = string.Concat(word.Order())))
                result.Add(word);

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        IList<string> list1 = new List<string> { "abba", "cd" };
        IList<string> list2 = new List<string> { "a","b","c","d","e" };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<IList<string>>(solution.RemoveAnagrams(new string[]{"abba","baba","bbaa","cd","cd"}), list1),
            ResultTester.CheckResult<IList<string>>(solution.RemoveAnagrams(new string[]{"a","b","c","d","e"}), list2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Resultant Array After Removing Anagrams");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}