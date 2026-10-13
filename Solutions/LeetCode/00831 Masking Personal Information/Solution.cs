// Masking Personal Information
namespace CompetitiveProgramming.LeetCode.MaskingPersonalInformation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public string MaskPII(string s) {

        string result = "";

        if (s.Contains('@'))
        {
            string[] workArr = s.Split('@');

            if (workArr[0].Length == 1)
            {
                result = workArr[0] + "*****";
            }

            result = workArr[0][0] + "*****" + workArr[0][workArr[0].Length - 1];

            result = result + "@";

            result = result + workArr[1];

        }
        else
        {
            s = s.Replace("(", "").Replace(")", "").Replace("-", "").Replace("+", "").Replace(" ", "");
                
            int nLeng = s.Length;

            result = s.Substring(nLeng - 4);

            if (nLeng == 10)
            {
                result = "***-***-" + result;
            }

            if (nLeng == 11)
            {
                result = "+*-***-***-" + result;
            }

            if (nLeng == 12)
            {
                result = "+**-***-***-" + result;
            }

            if (nLeng == 13)
            {
                result = "+***-***-***-" + result;
            }
        }

        return result.ToLower();
        
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MaskPII("LeetCode@LeetCode.com"), "l*****e@leetcode.com"),
            ResultTester.CheckResult<string>(solution.MaskPII("AB@qq.com"), "a*****b@qq.com"),
            ResultTester.CheckResult<string>(solution.MaskPII("1(234)567-890"), "***-***-7890"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Masking Personal Information");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}