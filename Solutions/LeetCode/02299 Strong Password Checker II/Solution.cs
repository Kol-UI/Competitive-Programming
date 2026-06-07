// Strong Password Checker II
namespace CompetitiveProgramming.LeetCode.StrongPasswordCheckerII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool StrongPasswordCheckerII(string password)
    {
        if(password.Length < 8) return false;

        bool lc = false, uc = false, d = false, sc = false;
        char prev = ' ';
        foreach(char c in password)
        {
            if(!lc && char.IsLower(c))
            {
               lc = true;    
            }
            else if(!uc && char.IsUpper(c))
            {
               uc = true;
            }
            else if(prev != ' ' && prev == c)
            {
                return false;
            }
            else if(!d && char.IsDigit(c))
            {
                d = true;
            }
            else if(!sc && "!@#$%^&*()-+".Contains(c))
            {
                sc = true;
            } 
     
            prev = c;    
        }

        return lc && uc && d && sc;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.StrongPasswordCheckerII("IloveLe3tcode"), false),
            ResultTester.CheckResult<bool>(solution.StrongPasswordCheckerII("Me+You--IsMyDream"), false),
            ResultTester.CheckResult<bool>(solution.StrongPasswordCheckerII("1aB!"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Strong Password Checker II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}