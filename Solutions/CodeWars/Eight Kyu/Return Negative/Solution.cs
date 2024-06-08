using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.ReturnNegative
{
	public class Solution
	{
        // In this simple assignment you are given a number and have to make it negative.
        // But maybe the number is already negative?

        // Examples:
        //Kata.MakeNegative(1);  // return -1
        //Kata.MakeNegative(-5); // return -5
        //Kata.MakeNegative(0);  // return 0

        public static int MakeNegative(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                bool positive = number > 0;
                if (positive)
                {
                    return number - (number * 2);
                }
                else
                {
                    return number;
                }
            }
        }

        // Using Math
        public static int MakeNegativeMath(int number)
        {
            return -Math.Abs(number);
        }

        // One Line
        public static int MakeNegativeOneLine(int number)
        {
            return number > 0 ? -number : number;
        }
    }

    public class Test
    {
        public static bool[] TestReturnNegative()
        {
            System.Random random = new System.Random();

            // Case 1
            int valueCase1 = random.Next();
            int resultCase1 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase1);

            // Case 2
            int valueCase2 = 1;
            int resultCase2 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase2);

            // Case 3
            int valueCase3 = -5;
            int resultCase3 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase3);

            // Case 4
            int valueCase4 = 0;
            int resultCase4 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase4);

            // Using Math
            // Case 1
            int resultCase1Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase1);

            // Case 2
            int resultCase2Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase2);

            // Case 3
            int resultCase3Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase3);

            // Case 4
            int resultCase4Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase4);

            // One Line
            // Case 1
            int resultCase1OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase1);

            // Case 2
            int resultCase2OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase2);

            // Case 3
            int resultCase3OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase3);

            // Case 4
            int resultCase4OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1, resultCase1Math),
                ResultTester.CheckResult<int>(resultCase2, -1),
                ResultTester.CheckResult<int>(resultCase3, -5),
                ResultTester.CheckResult<int>(resultCase4, 0),
                ResultTester.CheckResult<int>(resultCase1Math, resultCase1OneLine),
                ResultTester.CheckResult<int>(resultCase2Math, -1),
                ResultTester.CheckResult<int>(resultCase3Math, -5),
                ResultTester.CheckResult<int>(resultCase4Math, 0),
                ResultTester.CheckResult<int>(resultCase1OneLine, resultCase1),
                ResultTester.CheckResult<int>(resultCase2OneLine, -1),
                ResultTester.CheckResult<int>(resultCase3OneLine, -5),
                ResultTester.CheckResult<int>(resultCase4OneLine, 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return Negative");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestReturnNegative());
        }
    }
}