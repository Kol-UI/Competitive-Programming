// Divide a String Into Groups of Size k
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DivideaStringIntoGroupsofSizek;

public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        var r = new string[(s.Length + k - 1) / k];

        for(var i = r.Length-2; i >=0; i--)
        {
            r[i] = s.Substring(i * k, k);
        }

        r[r.Length-1] =  s.Substring((r.Length-1) * k).PadRight(k, fill);

        return r;
    }
}

public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divide a String Into Groups of Size k");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }