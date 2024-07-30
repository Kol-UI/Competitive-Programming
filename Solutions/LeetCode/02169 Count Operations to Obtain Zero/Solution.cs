// Count Operations to Obtain Zero

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountOperationstoObtainZero
{
    public class Solution
    {
        public int CountOperations(int num1, int num2) 
        {
            int count = 0;

            while (num1 != 0 && num2 != 0)
            {
                if (num1 >= num2) num1 -= num2;
                else num2 -= num1;
                
                count++;
            }
            
            return count;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Operations to Obtain Zero");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}