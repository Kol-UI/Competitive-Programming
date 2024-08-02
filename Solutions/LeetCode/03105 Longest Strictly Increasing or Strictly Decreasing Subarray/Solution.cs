// Longest Strictly Increasing or Strictly Decreasing Subarray



using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestStrictlyIncreasingorStrictlyDecreasingSubarray
{
    public class Solution 
    {
        public static int LongestMonotonicSubarray(int[] nums) 
        {
            int result = 0; 
            var stack = new Stack<int>();
            
            foreach(var i in nums)
            {
                if(stack.Count == 1 && stack.Peek() == i) stack.Clear();

                if(stack.Count > 1)
                {
                    var x = stack.Pop();
                    var y = stack.Peek();
                    if(!((y < x && x < i)|| (y > x && x > i))) stack.Clear();
                    stack.Push(x); 
                }

                stack.Push(i);
                result = Math.Max(result,stack.Count);
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LongestMonotonicSubarray(new int[] {1,4,3,3,2}), 2),
                ResultTester.CheckResult<int>(Solution.LongestMonotonicSubarray(new int[] {3,3,3,3}), 1),
                ResultTester.CheckResult<int>(Solution.LongestMonotonicSubarray(new int[] {3,2,1}), 3),

            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Longest Strictly Increasing or Strictly Decreasing Subarray");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}