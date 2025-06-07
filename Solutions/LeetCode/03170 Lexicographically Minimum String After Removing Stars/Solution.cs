// Lexicographically Minimum String After Removing Stars
namespace CompetitiveProgramming.LeetCode.LexicographicallyMinimumStringAfterRemovingStars;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ClearStars(string s)
    {
        Stack<int>[] charPositions = new Stack<int>[26];
        for (int i = 0; i < 26; i++)
        {
            charPositions[i] = new Stack<int>();
        }

        HashSet<int> indicesToRemove = new HashSet<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                int minCharIndex = FindIndexOfSmallestCharacter(charPositions);
                if (minCharIndex != -1)
                {
                    indicesToRemove.Add(i);
                    indicesToRemove.Add(charPositions[minCharIndex].Pop());
                }
            }
            else
            {
                charPositions[s[i] - 'a'].Push(i);
            }
        }

        StringBuilder resultBuilder = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (!indicesToRemove.Contains(i))
            {
                resultBuilder.Append(s[i]);
            }
        }

        return resultBuilder.ToString();
    }

    private int FindIndexOfSmallestCharacter(Stack<int>[] characterStacks)
    {
        for (int i = 0; i < 26; i++)
        {
            if (characterStacks[i].Any())
            {
                return i;
            }
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.ClearStars("aaba*"), "aab"),
            ResultTester.CheckResult<string>(solution.ClearStars("abc"), "abc"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Minimum String After Removing Stars");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}