// Group the People Given the Group Size They Belong To

/*
There are n people that are split into some unknown number of groups. Each person is labeled with a unique ID from 0 to n - 1.

You are given an integer array groupSizes, where groupSizes[i] is the size of the group that person i is in. For example, if groupSizes[1] = 3, then person 1 must be in a group of size 3.

Return a list of groups such that each person i is in a group of size groupSizes[i].

Each person should appear in exactly one group, and every person must be in a group. If there are multiple answers, return any of them. It is guaranteed that there will be at least one valid solution for the given input.

 

Example 1:

Input: groupSizes = [3,3,3,3,3,1,3]
Output: [[5],[0,1,2],[3,4,6]]
Explanation: 
The first group is [5]. The size is 1, and groupSizes[5] = 1.
The second group is [0,1,2]. The size is 3, and groupSizes[0] = groupSizes[1] = groupSizes[2] = 3.
The third group is [3,4,6]. The size is 3, and groupSizes[3] = groupSizes[4] = groupSizes[6] = 3.
Other possible solutions are [[2,1,6],[5],[0,4,3]] and [[5],[0,6,2],[4,3,1]].


Example 2:

Input: groupSizes = [2,1,3,3,3,2]
Output: [[1],[0,5],[2,3,4]]
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.GroupthePeopleGiventheGroupSizeTheyBelongTo
{
    public class Solution 
    {
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var result = new List<IList<int>>();
            var lenght = groupSizes.Length;
            var buffer = new List<int>[lenght + 1];
            
            for (var i = 0; i < lenght; ++i)
            {
                var personId = i;
                var groupSize = groupSizes[i];
                
                if (buffer[groupSize] == null)
                {
                    buffer[groupSize] = new List<int>();
                }

                var group = buffer[groupSize];
                group.Add(personId);
                
                if (group.Count == groupSize)
                {
                    result.Add(group);
                    buffer[groupSize] = null!;
                }
            }

            foreach (var item in buffer)
            {
                if (item != null)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] groupSizes1 = {3,3,3,3,3,1,3};
            int[] groupSizes2 = {2,1,3,3,3,2};
            IList<IList<int>> result1 = new List<IList<int>>
            {
                new List<int> { 0, 1, 2 },
                new List<int> { 5 },
                new List<int> { 3, 4, 6 }
            };
            IList<IList<int>> result2 = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 2, 3, 4 },
                new List<int> { 0, 5 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.GroupThePeople(groupSizes1), result1),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.GroupThePeople(groupSizes2), result2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Group the People Given the Group Size They Belong To");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}