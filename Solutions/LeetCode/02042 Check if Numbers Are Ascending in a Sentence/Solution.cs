// Check if Numbers Are Ascending in a Sentence
namespace CompetitiveProgramming.LeetCode.CheckifNumbersAreAscendinginaSentence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public bool AreNumbersAscending(string s)
    {
        var arr = s.Split(' ');
        var a = false;
        var list = new List<int>();
        var x = 0;
        for(int i = 0;i < arr.Length; i++)
        {
            a = int.TryParse(arr[i],out x);
            if(a) list.Add(x);
            if(list.Count > 1 && list[list.Count-1] <= list[list.Count-2]) return false;
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.AreNumbersAscending("1 box has 3 blue 4 red 6 green and 12 yellow marbles"), true),
            ResultTester.CheckResult<bool>(solution.AreNumbersAscending("sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s"), false),
            ResultTester.CheckResult<bool>(solution.AreNumbersAscending("hello world 5 x 5"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Numbers Are Ascending in a Sentence");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}