// Weighted Word Mapping
namespace CompetitiveProgramming.LeetCode.WeightedWordMapping;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        int length = words.Length;
        char[] word = new char[length];
        for (int i = 0; i < length; i++)
        {
            (int wLength, int sum) = (words[i].Length, 0);
            for (int j = 0; j < wLength; j++)
            {
                sum += weights[words[i][j] - 'a'];
            }

            word[i] = (char)('a' + 25 - sum % 26);
        }

        return new string(word);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MapWordWeights(["abcd","def","xyz"], [5,3,12,14,1,2,3,2,10,6,6,9,7,8,7,10,8,9,6,9,9,8,3,7,7,2]), "rij"),
            ResultTester.CheckResult<string>(solution.MapWordWeights(["a","b","c"], [1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]), "yyy"),
            ResultTester.CheckResult<string>(solution.MapWordWeights(["abcd"], [7,5,3,4,3,5,4,9,4,2,2,7,10,2,5,10,6,1,2,2,4,1,3,4,4,5]), "g"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Weighted Word Mapping");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}