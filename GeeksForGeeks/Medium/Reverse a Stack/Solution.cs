using System;
using System.Linq;
using System.Text;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.ReverseaStack
{
	public class Solution
	{
        public static void ReverseStack(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int item = stack.Pop();
                ReverseStack(stack);
                InsertAtBottom(stack, item);
            }
        }

        public static void InsertAtBottom(Stack<int> stack, int item)
        {
            if (stack.Count == 0)
            {
                stack.Push(item);
                return;
            }

            int temp = stack.Pop();
            InsertAtBottom(stack, item);
            stack.Push(temp);
        }
    }
}