using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ImplementQueueusingStacks
{
	public class Solution
	{
        public class MyQueue
        {
            // Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

            //Implement the MyQueue class:

            //void push(int x) Pushes element x to the back of the queue.
            //int pop() Removes the element from the front of the queue and returns it.
            //int peek() Returns the element at the front of the queue.
            //boolean empty() Returns true if the queue is empty, false otherwise.

            //Notes:
            //You must use only standard operations of a stack,
            //which means only push to top, peek/pop from top, size, and is empty operations are valid.
            //Depending on your language, the stack may not be supported natively.
            //You may simulate a stack using a list or deque(double-ended queue) as long as you use only a stack's standard operations.
 
            //Example :

            //Input
            //["MyQueue", "push", "push", "peek", "pop", "empty"]
            //[[], [1], [2], [], [], []]
            //Output
            //[null, null, null, 1, 1, false]

            //Explanation
            //MyQueue myQueue = new MyQueue();
            //myQueue.push(1);
            // queue is: [1]
            //myQueue.push(2);
            // queue is: [1, 2] (leftmost is front of the queue)
            //myQueue.peek();
            // return 1
            //myQueue.pop();
            // return 1, queue is [2]
            //myQueue.empty();
            // return false

            private readonly Stack<int> stack1;

            public MyQueue()
            {
                stack1 = new Stack<int>();
            }

            // Pushes element x to the back of the queue
            public void Push(int x)
            {
                if (stack1.Count == 0)
                {
                    stack1.Push(x);
                }
                else
                {
                    var stack2 = new Stack<int>();
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                    stack1.Push(x);
                    while (stack2.Count > 0)
                    {
                        stack1.Push(stack2.Pop());
                    }
                }
            }

            // Removes the element from the front of the queue and returns it
            public int Pop()
            {
                return stack1.Pop();
            }

            // Returns the element at the front of the queue
            public int Peek()
            {
                return stack1.Peek();
            }

            // Returns true if the queue is empty, false otherwise
            public bool Empty()
            {
                return stack1.Count == 0;
            }
        }

        /**
         * Your MyQueue object will be instantiated and called as such:
         * MyQueue obj = new MyQueue();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Peek();
         * bool param_4 = obj.Empty();
         */
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Queue using Stacks");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}