// Jump Game III

/*
Given an array of non-negative integers arr, you are initially positioned at start index of the array. When you are at index i, you can jump to i + arr[i] or i - arr[i], check if you can reach to any index with value 0.

Notice that you can not jump outside of the array at any time.

 

Example 1:

Input: arr = [4,2,3,0,3,1,2], start = 5
Output: true
Explanation: 
All possible ways to reach at index 3 with value 0 are: 
index 5 -> index 4 -> index 1 -> index 3 
index 5 -> index 6 -> index 4 -> index 1 -> index 3 


Example 2:

Input: arr = [4,2,3,0,3,1,2], start = 0
Output: true 
Explanation: 
One possible way to reach at index 3 with value 0 is: 
index 0 -> index 4 -> index 1 -> index 3


Example 3:

Input: arr = [3,0,2,1,2], start = 2
Output: false
Explanation: There is no way to reach at index 1 with value 0.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.JumpGameIII
{
    public class Solution
    {
        public static HashSet<int> seen = new();
        public static Queue<int> queue = new();
        public static bool CanReach(int[] arr, int start)
        {
            queue.Enqueue(start);
            seen.Add(start);

            while(queue.Count > 0)
            {
                int index = queue.Dequeue();
                if(arr[index] == 0)
                {
                    return true;
                }

                int forward = index + arr[index];
                int backward = index - arr[index];

                if(forward < arr.Length && seen.Contains(forward) == false)
                {
                    queue.Enqueue(forward);
                    seen.Add(forward);
                }

                if(backward >= 0 && seen.Contains(backward) == false)
                {
                    queue.Enqueue(backward);
                    seen.Add(backward);
                }
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestJumpGameIII()
        {
            int[] arr1 = {4,2,3,0,3,1,2}; int start1 = 5;
            int[] arr2 = {4,2,3,0,3,1,2}; int start2 = 0;
            int[] arr3 = {3,0,2,1,2}; int start3 = 2;
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CanReach(arr1, start1), true),
                ResultTester.CheckResult<bool>(Solution.CanReach(arr2, start2), false),
                ResultTester.CheckResult<bool>(Solution.CanReach(arr3, start3), false)
            };
            
            Solution.seen.Clear();
            Solution.queue.Clear();
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Jump Game III");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestJumpGameIII());
        }
    }
}