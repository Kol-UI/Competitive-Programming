// Smallest Value of the Rearranged Number
namespace CompetitiveProgramming.LeetCode.SmallestValueoftheRearrangedNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long SmallestNumber(long num)
    {
        if (num == 0) return num;
        char[] chars = ("" + Math.Abs(num)).ToArray();

        Array.Sort(chars);
        
        if (num < 0) 
        {
            Array.Reverse(chars);
            string result = new string(chars);   
            return -1 * long.Parse(result);
        }

        int i = 0;
        while (chars[i] == '0') i++;

        chars[0] = (char)(chars[0] ^ chars[i] ^ (chars[i] = chars[0]));

        return long.Parse(new String(chars));
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.SmallestNumber(310), 103),
            ResultTester.CheckResult<long>(solution.SmallestNumber(-7605), -7650),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Value of the Rearranged Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}