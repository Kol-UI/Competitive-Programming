// Basic Mathematical Operations

/*
Your task is to create a function that does four basic mathematical operations.

The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.

Examples(Operator, value1, value2) --> output
('+', 4, 7) --> 11
('-', 15, 18) --> -3
('*', 5, 5) --> 25
('/', 49, 7) --> 7
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.BasicMathematicalOperations
{
    public class Solution
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch(operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
                default:
                    break;
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestBasicMathematicalOperations()
        {
            double result1 = Solution.basicOp('+', 4, 7);
            double result2 = Solution.basicOp('-', 15, 18);
            double result3 = Solution.basicOp('*', 5, 5);
            double result4 = Solution.basicOp('/', 49, 7);

            double expected1 = 11;
            double expected2 = -3;
            double expected3 = 25;
            double expected4 = 7;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1, expected1),
                ResultTester.CheckResult<double>(result2, expected2),
                ResultTester.CheckResult<double>(result3, expected3),
                ResultTester.CheckResult<double>(result4, expected4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Basic Mathematical Operations");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestBasicMathematicalOperations());
        }
    }
}