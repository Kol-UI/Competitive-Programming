// Average Waiting Time

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AverageWaitingTime
{
    public class Solution
    {
        public double AverageWaitingTime(int[][] customers) 
        {
            int chef = 0;
            var totalWait = .0;

            for(int i = 0 ; i < customers.Length ; i++)
            {
                if(chef < customers[i][0])
                {
                    chef = customers[i][0];
                }
                
                chef += customers[i][1];
                totalWait += chef - customers[i][0];         
            }
            return totalWait/customers.Length;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Average Waiting Time");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}