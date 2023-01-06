using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode._150._Evaluate_Reverse_Polish_Notation
{
    public class Solution
    {
        //Evaluate the value of an arithmetic expression in Reverse Polish Notation.
        //Valid operators are +, -, *, and /. Each operand may be an integer or another expression.
        //Note that division between two integers should truncate toward zero.
        //It is guaranteed that the given RPN expression is always valid. That means the expression would always evaluate to a result,
        //and there will not be any division by zero operation.

        //Example 1:

        //Input: tokens = ["2", "1", "+", "3", "*"]
        //Output: 9
        //Explanation: ((2 + 1) * 3) = 9
        //Example 2:

        //Input: tokens = ["4","13","5","/","+"]
        //Output: 6
        //Explanation: (4 + (13 / 5)) = 6
        //Example 3:

        //Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
        //Output: 22
        //Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
        //= ((10 * (6 / (12 * -11))) + 17) + 5
        //= ((10 * (6 / -132)) + 17) + 5
        //= ((10 * 0) + 17) + 5
        //= (0 + 17) + 5
        //= 17 + 5
        //= 22

        public static int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            foreach (var item in tokens)
            {
                if (int.TryParse(item, out int number))
                {
                    stack.Push(number);
                }
                else
                {
                    var last = stack.Pop();
                    var first = stack.Pop();
                    switch (item.ToString())
                    {
                        case "+":
                            stack.Push(first + last);
                            break;
                        case "-":
                            stack.Push(first - last);
                            break;

                        case "*":
                            stack.Push(first * last);
                            break;

                        case "/":
                            stack.Push(first / last);
                            break;

                        default:
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }
}
