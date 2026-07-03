// Process String with Special Operations II
namespace CompetitiveProgramming.LeetCode.ProcessStringwithSpecialOperationsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public char ProcessStr(string s, long k) 
    {
        long len = 0;

        foreach(char c in s)
        {
            switch(c)
            {
                case '*':
                    if(len > 0)
                        len--;
                    break;
                case '#':
                    len *= 2;
                    break;
                case '%':
                    break;
                default:
                    len++;
                    break;
            }
        }

        if(k + 1 > len)
            return '.';
        
        for(int i = s.Length - 1; i >= 0; i--)
        {
            char c = s[i];

            switch(c)
            {
                case '*':
                    len++;
                    break;
                case '#':
                    long prevLen = len/2;
                    k %= prevLen;
                    len = prevLen;
                    break;
                case '%':
                    k = len-k-1;
                    break;
                default:
                    if(k == len-1)
                        return c;
                    len--;
                    break;
            }
        }
        return '.';
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<char>(solution.ProcessStr("a#b%*", 1), 'a'),
            ResultTester.CheckResult<char>(solution.ProcessStr("cd%#*#", 3), 'd'),
            ResultTester.CheckResult<char>(solution.ProcessStr("z*#", 0), '.'),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Process String with Special Operations II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}