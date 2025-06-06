// Using a Robot to Print the Lexicographically Smallest String
namespace CompetitiveProgramming.CodeForces.UsingaRobottoPrinttheLexicographicallySmallestString;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int[] frequency = new int[26];

    public string RobotWithString(string s)
    {
        Stack<char> stack = new();
        StringBuilder answer = new();

        foreach (char c in s)
            frequency[c - 'a']++;

        foreach (char c in s)
        {
            stack.Push(c);
            frequency[c - 'a']--;
            char smallest = smallestRemainingChar();
            while (stack.Count > 0 && stack.Peek() <= smallest)
                answer.Append(stack.Pop());
        }

        return answer.ToString();
    }

    private char smallestRemainingChar()
    {
        for (int i = 0; i < 26; i++)
        {
            if (frequency[i] > 0)
                return (char)(i + 'a');
        }
        return 'z';
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Using a Robot to Print the Lexicographically Smallest String");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
	}
}