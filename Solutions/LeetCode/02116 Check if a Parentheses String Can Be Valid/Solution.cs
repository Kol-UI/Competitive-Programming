// Check if a Parentheses String Can Be Valid

namespace CompetitiveProgramming.LeetCode.CheckifaParenthesesStringCanBeValid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanBeValid(string s, string locked)
    {
        int size = s.Length;
        int count = 0;
        int brackets = 0;

        if(size % 2 != 0) return false;

        for(int i = 0; i < size; i++)
        {
            if(locked[i] == '0')
            {
                count++;
            }
            else if(s[i] == '(')
            {
                brackets++;
            }
            else 
            {
                brackets--;
            }
            if(count + brackets < 0)
            {
                return false;
            }
        }
        
        count = 0;
        brackets = 0;

        for(int i = size - 1; i >= 0; i--)
        {
            if(locked[i] == '0')
            {
                count++;
            }
            else if(s[i] == ')')
            {
                brackets++;
            }
            else
            {
                brackets--;
            }
            if(count + brackets < 0)
            {
                return false;
            }
        }
        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if a Parentheses String Can Be Valid");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}