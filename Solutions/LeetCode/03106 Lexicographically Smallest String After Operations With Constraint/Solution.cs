// Lexicographically Smallest String After Operations With Constraint
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestStringAfterOperationsWithConstraint;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string GetSmallestString(string s, int k)
    {
        var arr = s.ToCharArray();
        for(int i = 0;i < arr.Length && k > 0;i++)
        {
            int diff = arr[i] - 'a';
            int opDiff = 26 - diff;
            if(opDiff < diff && opDiff <= k)
            {
                arr[i] = 'a';
                k -= Math.Min(k,opDiff);
            }
            else
            {
                arr[i] = (char)(arr[i] - Math.Min(k,diff));
                k -= Math.Min(k,diff);
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
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.GetSmallestString("zbbz", 3), "aaaz"),
            ResultTester.CheckResult<string>(solution.GetSmallestString("xaxcd", 4), "aawcd"),
            ResultTester.CheckResult<string>(solution.GetSmallestString("lol", 0), "lol"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Smallest String After Operations With Constraint");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}