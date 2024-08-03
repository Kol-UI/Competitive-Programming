// Avoid Flood in The City

/*
Your country has an infinite number of lakes. Initially, all the lakes are empty, but when it rains over the nth lake, the nth lake becomes full of water. If it rains over a lake that is full of water, there will be a flood. Your goal is to avoid floods in any lake.

Given an integer array rains where:

rains[i] > 0 means there will be rains over the rains[i] lake.
rains[i] == 0 means there are no rains this day and you can choose one lake this day and dry it.
Return an array ans where:

ans.length == rains.length
ans[i] == -1 if rains[i] > 0.
ans[i] is the lake you choose to dry in the ith day if rains[i] == 0.
If there are multiple valid answers return any of them. If it is impossible to avoid flood return an empty array.

Notice that if you chose to dry a full lake, it becomes empty, but if you chose to dry an empty lake, nothing changes.

 

Example 1:

Input: rains = [1,2,3,4]
Output: [-1,-1,-1,-1]
Explanation: After the first day full lakes are [1]
After the second day full lakes are [1,2]
After the third day full lakes are [1,2,3]
After the fourth day full lakes are [1,2,3,4]
There's no day to dry any lake and there is no flood in any lake.

Example 2:

Input: rains = [1,2,0,0,2,1]
Output: [-1,-1,2,1,-1,-1]
Explanation: After the first day full lakes are [1]
After the second day full lakes are [1,2]
After the third day, we dry lake 2. Full lakes are [1]
After the fourth day, we dry lake 1. There is no full lakes.
After the fifth day, full lakes are [2].
After the sixth day, full lakes are [1,2].
It is easy that this scenario is flood-free. [-1,-1,1,2,-1,-1] is another acceptable scenario.

Example 3:

Input: rains = [1,2,0,1,2]
Output: []
Explanation: After the second day, full lakes are  [1,2]. We have to dry one lake in the third day.
After that, it will rain over lakes [1,2]. It's easy to prove that no matter which lake you choose to dry in the 3rd day, the other one will flood.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AvoidFloodinTheCity
{
    public class Solution
    {
        public static int[] AvoidFlood(int[] rains) 
        {
            var zeros = new List<int>();
            var prev = new Dictionary<int, int>();
            var result = Enumerable.Repeat(-1, rains.Length).ToArray();
            
            for(int i = 0; i < rains.Length; i++)
            {
                var lake = rains[i];
                if(rains[i] == 0)
                {
                    zeros.Add(i);
                    result[i] = 1;
                }
                else
                {
                    if(!prev.ContainsKey(lake))
                        prev[lake] = i;
                    else
                    {
                        var prevIndex =  prev[lake];
                        var index = zeros.BinarySearch(prevIndex + 1);
                        if(index < 0)
                            index = ~index;
                        if(index == zeros.Count)
                            return new int[0];
                        prev[lake] = i;
                        result[zeros[index]] = lake;
                        zeros.RemoveAt(index);
                    }
                }
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] rains1 = {1,2,3,4};
            int[] rains2 = {1,2,0,0,2,1};
            int[] expected1 = {-1,-1,-1,-1};
            int[] expected2 = {-1,-1,2,1,-1,-1};
            int[] result1 = Solution.AvoidFlood(rains1);
            int[] result2 = Solution.AvoidFlood(rains2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Avoid Flood in The City");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}