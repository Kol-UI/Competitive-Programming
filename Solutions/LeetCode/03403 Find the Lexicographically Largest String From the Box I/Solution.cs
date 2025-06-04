// Find the Lexicographically Largest String From the Box I
namespace CompetitiveProgramming.LeetCode.FindtheLexicographicallyLargestStringFromtheBoxI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;


public class Solution {
    public string AnswerString(string word, int numFriends) {
        int L = word.Length - numFriends + 1;
        if (L == word.Length) {
            return word;
        }

        char c = word[0];
        string ans = word.Substring(0, L);

        for (int i = 1; i < word.Length; i++) {
            if (word[i] > c) {
                c = word[i];
                string sub = word.Substring(i, Math.Min(L, word.Length - i));
                if (sub.CompareTo(ans) > 0) {
                    ans = sub;
                }
            } else if (word[i] == c) {
                string sub = word.Substring(i, Math.Min(L, word.Length - i));
                if (sub.CompareTo(ans) > 0) {
                    ans = sub;
                }
            }
        }
        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.AnswerString("dbca", 2), "dbc"),
            ResultTester.CheckResult<string>(solution.AnswerString("gggg", 4), "g")
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Lexicographically Largest String From the Box I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}