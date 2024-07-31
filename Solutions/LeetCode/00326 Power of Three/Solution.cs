// Power of Three

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PowerofThree
{

    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if(n == 0)
                return false;
            
            while(n != 1)
            {
                if(n %3 != 0)
                    return false;
                n = n/3;
            }
            
            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Three");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}