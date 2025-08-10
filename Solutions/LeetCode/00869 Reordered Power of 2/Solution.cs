// Reordered Power of 2
namespace CompetitiveProgramming.LeetCode.ReorderedPowerof2;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ReorderedPowerOf2(int n)
    {
        string target = SortDigits(n);
        
        for (int i = 0; i < 31; i++)
        { 
            int pow = 1 << i;
            if (target == SortDigits(pow))
            {
                return true;
            }
        }
        return false;
    }
    
    private string SortDigits(int num)
    {
        char[] arr = num.ToString().ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reordered Power of 2");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}