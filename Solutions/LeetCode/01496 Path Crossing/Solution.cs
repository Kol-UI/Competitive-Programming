// Path Crossing

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PathCrossing
{
    public class Solution
    {
        public static bool IsPathCrossing(string path) 
        {
            var (v, h) = (0, 0);

            var visited = new HashSet<(int,int)>(path.Length) { (0, 0) };

            foreach(var direction in path)
            {
                var position = direction switch
                {
                    'N' => (++v, h),
                    'E' => (v, ++h),
                    'S' => (--v, h),
                    'W' => (v, --h),
                    _ => throw new NotImplementedException()
                };

                if(!visited.Add(position))
                {
                    return true;                
                }
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsPathCrossing("NES"), false),
                ResultTester.CheckResult<bool>(Solution.IsPathCrossing("NESWW"), true),
            };
            return results;
        }
    }
}