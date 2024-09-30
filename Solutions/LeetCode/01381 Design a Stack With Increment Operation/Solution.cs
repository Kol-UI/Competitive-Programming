// Design a Stack With Increment Operation

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DesignaStackWithIncrementOperation
{
    public class CustomStack {
        private int[] stack;
        private int top = -1;

        public CustomStack(int maxSize) {
            stack = new int[maxSize];
        }

        public void Push(int x) {
            if (top < stack.Length - 1) {
                top++;
                stack[top] = x;
            }
        }

        public int Pop() {
            if (top != -1) {
                return stack[top--];
            }
            return -1;
        }

        public void Increment(int k, int val) {
            for (int i = 0; i < Math.Min(k, top + 1); i++) {
                stack[i] += val;
            }
        }
    }
    /**
    * Your CustomStack object will be instantiated and called as such:
    * CustomStack obj = new CustomStack(maxSize);
    * obj.Push(x);
    * int param_2 = obj.Pop();
    * obj.Increment(k,val);
    */
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design a Stack With Increment Operation");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}