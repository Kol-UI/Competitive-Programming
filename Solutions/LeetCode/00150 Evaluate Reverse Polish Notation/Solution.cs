using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.EvaluateReversePolishNotation
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

    public class Test
    {
        public static bool[] TestEvaluateReversePolishNotation()
        {
            string[] tokens1 = {"2", "1", "+", "3", "*"};
            string[] tokens2 = {"4","13","5","/","+"};
            string[] tokens3 = {"10","6","9","3","+","-11","*","/","*","17","+","5","+"};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.EvalRPN(tokens1), 9),
                ResultTester.CheckResult<int>(Solution.EvalRPN(tokens2), 6),
                ResultTester.CheckResult<int>(Solution.EvalRPN(tokens3), 22)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Evaluate Reverse Polish Notation");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestEvaluateReversePolishNotation());
        }
    }
}