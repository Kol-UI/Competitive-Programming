using System;
using System.Linq;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse a Stack");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG);
        }
    }
}