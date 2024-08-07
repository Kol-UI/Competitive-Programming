using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReducingDishes
{
    /*
        A chef has collected data on the satisfaction level of his n dishes. Chef can cook any dish in 1 unit of time.
        Like-time coefficient of a dish is defined as the time taken to cook that dish including previous dishes multiplied by its satisfaction level i.e. time[i] * satisfaction[i].
        Return the maximum sum of like-time coefficient that the chef can obtain after dishes preparation.
        Dishes can be prepared in any order and the chef can discard some dishes to get this maximum value.

        Example 1:
        Input: satisfaction = [-1,-8,0,5,-9]
        Output: 14
        Explanation: After Removing the second and last dish, the maximum total like-time coefficient will be equal to (-1*1 + 0*2 + 5*3 = 14).
        Each dish is prepared in one unit of time.
        
        Example 2:
        Input: satisfaction = [4,3,2]
        Output: 20
        Explanation: Dishes can be prepared in any order, (2*1 + 3*2 + 4*3 = 20)
        
        Example 3:
        Input: satisfaction = [-1,-4,-5]
        Output: 0
        Explanation: People do not like the dishes. No dish is prepared.
    */
    public class Solution
    {
        public static int MaxSatisfaction(int[] satisfaction) 
        {
            int total = 0;
            int sum = 0;
            Array.Sort(satisfaction, (a,b) => b-a);
            for(int i = 0; i < satisfaction.Length; i++)
            {
                sum += satisfaction[i];
                if(sum <= 0) return total;
                total += sum;
            }
            return total;
        }
    }

    public class Test
    {
        public static bool[] TestReducingDishes()
        {
            // Case 1
            int[] satisfaction1402_1 = { -1 , -8 , 0 , 5 , -9 };
            int result1402_1 = Solution.MaxSatisfaction(satisfaction1402_1);

            // Case 2
            int[] satisfaction1402_2 = { 4, 3, 2 };
            int result1402_2 = Solution.MaxSatisfaction(satisfaction1402_2);

            // Case 3
            int[] satisfaction1402_3 = { -1, -4 , -5 };
            int result1402_3 = Solution.MaxSatisfaction(satisfaction1402_3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1402_1, 14),
                ResultTester.CheckResult<int>(result1402_2, 20),
                ResultTester.CheckResult<int>(result1402_3, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reducing Dishes");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestReducingDishes());
        }
    }
}