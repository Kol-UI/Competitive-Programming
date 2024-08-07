// Kids With the Greatest Number of Candies

/*
There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

Note that multiple kids can have the greatest number of candies.

 
Example 1:

Input: candies = [2,3,5,1,3], extraCandies = 3
Output: [true,true,true,false,true] 
Explanation: If you give all extraCandies to:
- Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.

Example 2:

Input: candies = [4,2,1,1,2], extraCandies = 1
Output: [true,false,false,false,false] 
Explanation: There is only 1 extra candy.
Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
Example 3:

Input: candies = [12,1,12], extraCandies = 10
Output: [true,false,true]
*/

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KidsWiththeGreatestNumberofCandies
{
    public class Solution
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandies = candies.Max();
            // Find the maximum number of candies among all kids
            IList<bool> result = new List<bool>();
            foreach (int numCandies in candies)
            {
                if (numCandies + extraCandies >= maxCandies)
                {
                    result.Add(true);
                    // This kid will have the greatest number of candies after receiving extra candies
                }
                else
                {
                    result.Add(false);
                    // This kid will not have the greatest number of candies after receiving extra candies
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestKidsWiththeGreatestNumberofCandies()
        {
            // Case 1
            int[] candies1 = {2,3,5,1,3};
            int extraCandies1 = 3;
            IList<bool> result1 = Solution.KidsWithCandies(candies1, extraCandies1);

            // Case 1
            int[] candies2 = {4,2,1,1,2};
            int extraCandies2 = 1;
            IList<bool> result2 = Solution.KidsWithCandies(candies2, extraCandies2);

            IList<bool> firstList = new List<bool> { true, false, false, false, false };
            IList<bool> secondList = new List<bool> { true, false, true };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<bool>>(result1, firstList),
                ResultTester.CheckResult<IList<bool>>(result2, secondList)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1431");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestKidsWiththeGreatestNumberofCandies());
        }
    }
}