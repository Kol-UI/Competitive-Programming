// Check if Number Has Equal Digit Count and Digit Value
namespace CompetitiveProgramming.LeetCode.CheckifNumberHasEqualDigitCountandDigitValue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool DigitCount(string num)
    {
        Dictionary<int,int> unique = new();
        for(int i = 0; i < num.Length; i++)
        {
            int intVal = num[i]-'0';
            if(unique.ContainsKey(intVal))
            {
                unique[intVal] += 1;
            }
            else unique[intVal] = 1;
        }
        for(int i = 0; i < num.Length; i++)
        {
            int intVal = num[i]-'0';
            if(intVal == 0)
            {
                if(unique.ContainsKey(i)) return false; 
            }
            else
            {
                if(!unique.ContainsKey(i)) return false;
                if(intVal != unique[i]) return false;
            }
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
            ResultTester.CheckResult<bool>(solution.DigitCount("1210"), true),
            ResultTester.CheckResult<bool>(solution.DigitCount("030"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Number Has Equal Digit Count and Digit Value");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}