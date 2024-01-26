// Largest Rectangle in Histogram


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LargestRectangleinHistogram
{
    public class Solution
    {
        public static int LargestRectangleArea(int[] heights)
        {
            Stack<(int index, int height)> stack = new Stack<(int, int)>();

            int index = 0, i = 0, maxArea = 0;

            (int index, int height) top;

            stack.Push((0, heights[0]));

            for(i = 1; i < heights.Length; i++)
            {
                index = i;
                while(stack.Count > 0 && stack.Peek().height > heights[i])
                {
                    top = stack.Pop();
                    maxArea = Math.Max(maxArea, (top.height * (i - top.index)));
                    index = top.index;
                }
                stack.Push((index, heights[i]));
            }
            
            while(stack.Count > 0)
            {
                top = stack.Pop();
                maxArea = Math.Max(maxArea, top.height * (heights.Length - top.index));
            }

            return maxArea;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LargestRectangleArea(new int[]{2,1,5,6,2,3}), 10),
                ResultTester.CheckResult<int>(Solution.LargestRectangleArea(new int[]{2,4}), 4),
            };
            return results;
        }
    }
}