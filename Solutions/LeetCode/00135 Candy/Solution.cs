// Candy

/*
There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.

You are giving candies to these children subjected to the following requirements:

Each child must have at least one candy.
Children with a higher rating get more candies than their neighbors.
Return the minimum number of candies you need to have to distribute the candies to the children.

 

Example 1:

Input: ratings = [1,0,2]
Output: 5
Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.

Example 2:

Input: ratings = [1,2,2]
Output: 4
Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
The third child gets 1 candy because it satisfies the above two conditions.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Candy
{
    public class Solution 
    {
        public static int Candy(int[] ratings) 
        {
            var partialChilds = new int[ratings.Length];

            for(int i = 1; i < ratings.Length; i++)
            {
                if(ratings[i] > ratings[i - 1])
                {
                partialChilds[i] = partialChilds[i - 1] + 1;
                }
            }

            for(int i = ratings.Length - 2; i >= 0; i--)
            {
                if(ratings[i] > ratings[i + 1])
                {
                partialChilds[i] = Math.Max(partialChilds[i + 1] + 1, partialChilds[i]);
                }
            }

            var total = ratings.Length;
            for(int i = 0; i < partialChilds.Length; i++)
            {
                total += partialChilds[i];
            }
            
            return total;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] ratings1 = {1,0,2};
            int[] ratings2 = {1,2,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.Candy(ratings1), 5),
                ResultTester.CheckResult<int>(Solution.Candy(ratings2), 4),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candy");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}