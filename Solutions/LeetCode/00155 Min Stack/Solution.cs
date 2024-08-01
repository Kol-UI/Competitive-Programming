// Min Stack

/*
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

MinStack() initializes the stack object.
void push(int val) pushes the element val onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
You must implement a solution with O(1) time complexity for each function.

 

Example 1:

Input
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinStack
{
    public class MinStack
    {
        private int[] stackVals;
        private int _st;
        private int[] _min;

        public MinStack()
        {
            stackVals = new int[3000];
            _min = new int[3000];
            _st = -1;
        }
        
        public void Push(int val)
        {
            if (isEmpty())
            {
                _st = 0;
                _min[0] = val;
                stackVals[0] = val;
                return;
            }

            else if (isFull()) return;
            else 
            {
                _st ++;
                stackVals[_st] = val;
                if (val<_min[_st - 1]) _min[_st] = val;
                else _min[_st] = _min[_st - 1];
            }
        }
        
        public void Pop() 
        {
            if (isEmpty()) return;
            else _st --;  
        }
        
        public int Top()
        {
            return stackVals[_st];
        }
        
        public int GetMin()
        {
            return _min[_st];
        }

        public bool isFull()
        {
            if (_st == 2999) return true;
            else return false;
        }

        public bool isEmpty() 
        {
            if (_st == -1) return true;
            else return false;
        }
    }

    /**
    * Your MinStack object will be instantiated and called as such:
    * MinStack obj = new MinStack();
    * obj.Push(val);
    * obj.Pop();
    * int param_3 = obj.Top();
    * int param_4 = obj.GetMin();
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Stack");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}