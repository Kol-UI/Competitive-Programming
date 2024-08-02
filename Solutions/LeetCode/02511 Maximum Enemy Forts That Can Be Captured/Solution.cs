// Maximum Enemy Forts That Can Be Captured


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumEnemyFortsThatCanBeCaptured
{
    public class Solution
    {
        private const int emptySpot = 0;
        private const int enemyFort = -1;
        private const int myFort = 1; 
        
        public static int CaptureForts(int[] forts)
        {
            int maxCaptures = 0, noOfEmptySpots = 0, prev = 0;
            for(int i = 0; i < forts.Length; i++)
            {
                if(forts[i] == emptySpot)
                {
                    noOfEmptySpots++;
                    continue;
                } 
                if(prev + forts[i] == 0)
                {
                    maxCaptures = Math.Max(maxCaptures, noOfEmptySpots);
                }
            
                prev = forts[i];
                noOfEmptySpots = 0;
            }

            return maxCaptures;
            
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CaptureForts(new int[] {1,0,0,-1,0,0,0,0,1}), 4),
                ResultTester.CheckResult<int>(Solution.CaptureForts(new int[] {0,0,1,-1}), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Enemy Forst That Can Be Captured");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}