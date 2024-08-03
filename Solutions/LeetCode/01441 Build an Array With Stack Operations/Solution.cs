// Build an Array With Stack Operations

/*
You are given an integer array target and an integer n.

You have an empty stack with the two following operations:

"Push": pushes an integer to the top of the stack.
"Pop": removes the integer on the top of the stack.
You also have a stream of the integers in the range [1, n].

Use the two stack operations to make the numbers in the stack (from the bottom to the top) equal to target. You should follow the following rules:

If the stream of the integers is not empty, pick the next integer from the stream and push it to the top of the stack.
If the stack is not empty, pop the integer at the top of the stack.
If, at any moment, the elements in the stack (from the bottom to the top) are equal to target, do not read new integers from the stream and do not do more operations on the stack.
Return the stack operations needed to build target following the mentioned rules. If there are multiple valid answers, return any of them.

 

Example 1:

Input: target = [1,3], n = 3
Output: ["Push","Push","Pop","Push"]
Explanation: Initially the stack s is empty. The last element is the top of the stack.
Read 1 from the stream and push it to the stack. s = [1].
Read 2 from the stream and push it to the stack. s = [1,2].
Pop the integer on the top of the stack. s = [1].
Read 3 from the stream and push it to the stack. s = [1,3].

Example 2:

Input: target = [1,2,3], n = 3
Output: ["Push","Push","Push"]
Explanation: Initially the stack s is empty. The last element is the top of the stack.
Read 1 from the stream and push it to the stack. s = [1].
Read 2 from the stream and push it to the stack. s = [1,2].
Read 3 from the stream and push it to the stack. s = [1,2,3].

Example 3:

Input: target = [1,2], n = 4
Output: ["Push","Push"]
Explanation: Initially the stack s is empty. The last element is the top of the stack.
Read 1 from the stream and push it to the stack. s = [1].
Read 2 from the stream and push it to the stack. s = [1,2].
Since the stack (from the bottom to the top) is equal to target, we stop the stack operations.
The answers that read integer 3 from the stream are not accepted.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.BuildanArrayWithStackOperations
{
    public class Solution
    {
        public static IList<string> BuildArray(int[] target, int n)
        {
            List<string> operations = new List<string>();

            int index = 0;
            for (int i = 1; i <= n && index < target.Length; i++)
            {
                if (i == target[index])
                {
                    operations.Add("Push");
                    index++;
                }
                else
                {
                    operations.Add("Push");
                    operations.Add("Pop");
                }
            }

            return operations;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] target1 = { 1, 3 };
            int[] target2 = { 1, 2, 3 };
            int[] target3 = { 1, 2 };
            IList<string> result1 = new List<string> { "Push","Push","Pop","Push" };
            IList<string> result2 = new List<string> { "Push","Push","Push" };
            IList<string> result3 = new List<string> { "Push","Push" };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.BuildArray(target1, 3), result1),
                ResultTester.CheckResult<IList<string>>(Solution.BuildArray(target2, 3), result2),
                ResultTester.CheckResult<IList<string>>(Solution.BuildArray(target3, 4), result3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Build an Array With Stack Operations");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}