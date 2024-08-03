// Last Moment Before All Ants Fall Out of a Plank

/*
We have a wooden plank of the length n units. Some ants are walking on the plank, each ant moves with a speed of 1 unit per second. Some of the ants move to the left, the other move to the right.

When two ants moving in two different directions meet at some point, they change their directions and continue moving again. Assume changing directions does not take any additional time.

When an ant reaches one end of the plank at a time t, it falls out of the plank immediately.

Given an integer n and two integer arrays left and right, the positions of the ants moving to the left and the right, return the moment when the last ant(s) fall out of the plank.

 

Example 1:


Input: n = 4, left = [4,3], right = [0,1]
Output: 4
Explanation: In the image above:
-The ant at index 0 is named A and going to the right.
-The ant at index 1 is named B and going to the right.
-The ant at index 3 is named C and going to the left.
-The ant at index 4 is named D and going to the left.
The last moment when an ant was on the plank is t = 4 seconds. After that, it falls immediately out of the plank. (i.e., We can say that at t = 4.0000000001, there are no ants on the plank).


Example 2:


Input: n = 7, left = [], right = [0,1,2,3,4,5,6,7]
Output: 7
Explanation: All ants are going to the right, the ant at index 0 needs 7 seconds to fall.


Example 3:


Input: n = 7, left = [0,1,2,3,4,5,6,7], right = []
Output: 7
Explanation: All ants are going to the left, the ant at index 7 needs 7 seconds to fall.
 
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LastMomentBeforeAllAntsFallOutofaPlank
{
    public class Solution
    {
        public static int GetLastMoment(int n, int[] left, int[] right)
        {
            int maxLeft = left.Length == 0 ? 0 : left.Max();
            int minRight = right.Length == 0 ? n : right.Min();
            return Math.Max(maxLeft, n - minRight);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 4;
            int[] left1 = {4,3};
            int[] right1 = {0,1};
            int n2 = 7;
            int[] left2 = Array.Empty<int>();
            int[] right2 = {0,1,2,3,4,5,6,7};
            int n3 = 7;
            int[] left3 = {0,1,2,3,4,5,6,7};
            int[] right3 = Array.Empty<int>();
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.GetLastMoment(n1, left1, right1), 4),
                ResultTester.CheckResult<int>(Solution.GetLastMoment(n2, left2, right2), 7),
                ResultTester.CheckResult<int>(Solution.GetLastMoment(n3, left3, right3), 7),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Last Moment Before All Ants Fall Out of a Plank");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}