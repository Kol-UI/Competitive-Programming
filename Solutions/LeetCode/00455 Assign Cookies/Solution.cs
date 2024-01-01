// Assign Cookies




using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.AssignCookies
{
    public class Solution
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int childIndex = g.Length - 1;
            int cookieIndex = s.Length - 1;

            int cookiesGiven = 0;

            while (childIndex >= 0 && cookieIndex >= 0)
            {
                if (g[childIndex] > s[cookieIndex])
                {
                    childIndex--;
                }
                else
                {
                    childIndex--;
                    cookieIndex--;
                    cookiesGiven++;
                }
            }

            return cookiesGiven;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindContentChildren(new int[]{1,2,3}, new int[]{1,1}), 1),
                ResultTester.CheckResult<int>(Solution.FindContentChildren(new int[]{1,2}, new int[]{1,2,3}), 2),
            };
            return results;
        }
    }
}

