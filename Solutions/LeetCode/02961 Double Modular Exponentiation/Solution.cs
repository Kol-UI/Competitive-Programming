// Double Modular Exponentiation
namespace CompetitiveProgramming.LeetCode.DoubleModularExponentiation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> GetGoodIndices(int[][] variables, int target)
    {
        var result = new List<int>();
        for (var i = 0; i < variables.Length; i++)
        {
            var a = variables[i][0];
            var b = variables[i][1];
            var c = variables[i][2];
            var d = variables[i][3];

            if (d <= target)
                continue;

            var first = a;
            for (var j = 0; j < b - 1; j++)
            {
                if (first > 10)
                    first = first % 10;
                first *= a;
            }

            var sec = first % 10;

            if (sec % d == 0 && target == 0)
            {
                result.Add(i);
                continue;
            }

            var third = sec;
            for (var j = 1; j < c; j++)
            {
                third *= sec;
                while (third > d)
                    third -= d;
            }

            if (target == third % d)
                result.Add(i);
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Double Modular Exponentiation");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}