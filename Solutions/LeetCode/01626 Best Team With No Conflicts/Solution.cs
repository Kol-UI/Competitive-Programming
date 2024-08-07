using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BestTeamWithNoConflicts
{
    public class Solution
    {
        // You are the manager of a basketball team. For the upcoming tournament, you want to choose the team with the highest overall score. The score of the team is the sum of scores of all the players in the team.
        // However, the basketball team is not allowed to have conflicts. A conflict exists if a younger player has a strictly higher score than an older player. A conflict does not occur between players of the same age.
        // Given two lists, scores and ages, where each scores[i] and ages[i] represents the score and age of the ith player, respectively, return the highest overall score of all possible basketball teams.

        // Example 1:

        // Input: scores = [1,3,5,10,15], ages = [1,2,3,4,5]
        // Output: 34
        // Explanation: You can choose all the players.

        // Example 2:

        // Input: scores = [4,5,6,5], ages = [2,1,2,1]
        // Output: 16
        // Explanation: It is best to choose the last 3 players. Notice that you are allowed to choose multiple people of the same age.

        // Example 3:

        // Input: scores = [1,2,3,5], ages = [8,9,10,1]
        // Output: 6
        // Explanation: It is best to choose the first 3 players. 

        public static int BestTeamScore(int[] scores, int[] ages)
        {
            int n = ages.Length;
            int[][] candidate = new int[n][];

            for(int k = 0; k < n; k++)
            {
                candidate[k] = new int[2];
            }
            
            for(int i = 0; i < n; i++)
            {
                candidate[i][0] = ages[i];
                candidate[i][1] = scores[i];
            }

            Array.Sort(candidate, (a,b) => a[0] == b[0] ? a[1]-b[1] : a[0]-b[0]);
            int[] dp = new int[n];
            dp[0] = candidate[0][1];
            int max = dp[0];  

            for(int i = 1; i < n; i++)
            {      
                dp[i] = candidate[i][1];  
                for(int j = 0; j < i; j++)
                {
                    if(candidate[j][1] <= candidate[i][1])
                    {
                        dp[i] = Math.Max(dp[i], candidate[i][1] + dp[j]);
                    }  
                }
                max = Math.Max(dp[i], max);
            }
            return max; 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] scores1 = {1,3,5,10,15}; int[] ages1 = {1,2,3,4,5};
            int[] scores2 = {4,5,6,5}; int[] ages2 = {2,1,2,1};
            int[] scores3 = {1,2,3,5}; int[] ages3 = {8,9,10,1};
            int result1 = Solution.BestTeamScore(scores1, ages1);
            int result2 = Solution.BestTeamScore(scores1, ages1);
            int result3 = Solution.BestTeamScore(scores1, ages1);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, result1),
                ResultTester.CheckResult<int>(result2, result2),
                ResultTester.CheckResult<int>(result3, result3)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Best Team With No Conflicts");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}