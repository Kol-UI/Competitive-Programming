// Unique Morse Code Words
namespace CompetitiveProgramming.LeetCode.UniqueMorseCodeWords;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public sealed class Solution 
{
    private static readonly string[] d = new string[] { ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.." };

    public int UniqueMorseRepresentations(string[] words) 
    {
        var s = new HashSet<string>();
        var sb = new StringBuilder();

        for(int i = 0; i < words.Length; i++)
        {
            for(int j = 0; j < words[i].Length; j++)
            {
                sb.Append(d[words[i][j] - 97]);
            }

            s.Add(sb.ToString());

            sb.Clear();
        }

        return s.Count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.UniqueMorseRepresentations(["gin","zen","gig","msg"]), 2),
            ResultTester.CheckResult<int>(solution.UniqueMorseRepresentations(["a"]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unique Morse Code Words");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}