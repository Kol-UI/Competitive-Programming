// Validate Stack Sequences

/*

Given two integer arrays pushed and popped each with distinct values, return true if this could have been the result of a sequence of push and pop operations on an initially empty stack, or false otherwise.

Example 1:
Input: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]
Output: true
Explanation: We might do the following sequence:
push(1), push(2), push(3), push(4),
pop() -> 4,
push(5),
pop() -> 5, pop() -> 3, pop() -> 2, pop() -> 1

Example 2:
Input: pushed = [1,2,3,4,5], popped = [4,3,5,1,2]
Output: false
Explanation: 1 cannot be popped before 2.

*/

using System;
namespace CompetitiveProgramming.LeetCode.ValidateStackSequences
{
    public class Solution
    {
        public static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var i = 0;
            var j = 0;
            var stack = new Stack<int>();

            while (j < popped.Length)
            {
                if (stack.Any() && stack.Peek() == popped[j])
                {
                    stack.Pop();
                    j++;
                    continue;
                }

                if (i < pushed.Length)
                {
                    stack.Push(pushed[i]);
                    i++;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}