// Course Schedule

/*
There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.

For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return true if you can finish all courses. Otherwise, return false.


Example 1:

Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0. So it is possible.

Example 2:

Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
Output: false
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.
*/


using System;
namespace CompetitiveProgramming.LeetCode.CourseSchedule
{
    public class Solution
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var dic = new Dictionary<int, HashSet<int>>();

            foreach (var item in prerequisites)
            {
                if (!dic.ContainsKey(item[0])) dic.Add(item[0], new HashSet<int>());
                if (!dic.ContainsKey(item[1])) dic.Add(item[1], new HashSet<int>());

                dic[item[0]].Add(item[1]);
            }

            var change = true;
            while (change)
            {
                change = false;
                var courses = dic.Where(x => !x.Value.Any()).ToList();
                
                foreach (var afterItem in courses)
                {
                    foreach (var item in dic) item.Value.Remove(afterItem.Key);

                    change = true;
                    dic.Remove(afterItem.Key);
                }
            }

            if (dic.Any()) return false;

            return true;
        }
    }
}
