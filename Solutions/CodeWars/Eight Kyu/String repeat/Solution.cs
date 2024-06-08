using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Stringrepeat
{
	public class Solution
	{
        // Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
        // Examples (input -> output)
        // 6, "I"     -> "IIIIII"
        // 5, "Hello" -> "HelloHelloHelloHelloHello"

        public static string RepeatStr(int n, string s)
        {
            string result = "";
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result += s;
                }
            }
            return result;
        }

        // Concat
        public static string ConcatRepeatStr(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }

        // Clever
        // StringBuilder
        // Other Ways than StringBuilder : for every loop step a new string must be stored
        public static string StringBuilderRepeatStr(int n, string s)
        {
            return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }
    }

    public class Test
    {
        public static bool[] TestStringrepeat()
        {
            System.Random random = new System.Random();

            // Case 1
            int numberCase1 = 6;
            string stringCase1 = "I";
            string Case1_Result = Solution.RepeatStr(numberCase1, stringCase1);
            string Case1_ResultConcat = Solution.ConcatRepeatStr(numberCase1, stringCase1);
            string Case1_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase1, stringCase1);

            // Case 2
            int numberCase2 = 5;
            string stringCase2 = "Hello";
            string Case2_Result = Solution.RepeatStr(numberCase2, stringCase2);
            string Case2_ResultConcat = Solution.ConcatRepeatStr(numberCase2, stringCase2);
            string Case2_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase2, stringCase2);

            // Case 3
            int numberCase3 = 3;
            string stringCase3 = "*";
            string Case3_Result = Solution.RepeatStr(numberCase3, stringCase3);
            string Case3_ResultConcat = Solution.ConcatRepeatStr(numberCase3, stringCase3);
            string Case3_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase3, stringCase3);

            // Case 4
            int numberCase4 = 5;
            string stringCase4 = "#";
            string Case4_Result = Solution.RepeatStr(numberCase4, stringCase4);
            string Case4_ResultConcat = Solution.ConcatRepeatStr(numberCase4, stringCase4);
            string Case4_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase4, stringCase4);

            // Case 5
            int numberCase5 = 2;
            string stringCase5 = "ha ";
            string Case5_Result = Solution.RepeatStr(numberCase5, stringCase5);
            string Case5_ResultConcat = Solution.ConcatRepeatStr(numberCase5, stringCase5);
            string Case5_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase5, stringCase5);

            // Case 6
            int numberCase6 = random.Next(1, 10);
            string stringCase6 = "random ";
            string Case6_Result = Solution.RepeatStr(numberCase6, stringCase6);
            string Case6_ResultConcat = Solution.ConcatRepeatStr(numberCase6, stringCase6);
            string Case6_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase6, stringCase6);

            // Case 7
            int numberCase7 = 0;
            string stringCase7 = "nothing";
            string Case7_Result = Solution.RepeatStr(numberCase7, stringCase7);
            string Case7_ResultConcat = Solution.ConcatRepeatStr(numberCase7, stringCase7);
            string Case7_ResultStringBuilder = Solution.StringBuilderRepeatStr(numberCase7, stringCase7);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_Result, "IIIIII"),
                ResultTester.CheckResult<string>(Case1_ResultConcat, "IIIIII"),
                ResultTester.CheckResult<string>(Case1_ResultStringBuilder, "IIIIII"),
                ResultTester.CheckResult<string>(Case2_Result, "HelloHelloHelloHelloHello"),
                ResultTester.CheckResult<string>(Case2_ResultConcat, "HelloHelloHelloHelloHello"),
                ResultTester.CheckResult<string>(Case2_ResultStringBuilder, "HelloHelloHelloHelloHello"),
                ResultTester.CheckResult<string>(Case3_Result, "***"),
                ResultTester.CheckResult<string>(Case3_ResultConcat, "***"),
                ResultTester.CheckResult<string>(Case3_ResultStringBuilder, "***"),
                ResultTester.CheckResult<string>(Case4_Result, "#####"),
                ResultTester.CheckResult<string>(Case4_ResultConcat, "#####"),
                ResultTester.CheckResult<string>(Case4_ResultStringBuilder, "#####"),
                ResultTester.CheckResult<string>(Case5_Result, "ha ha "),
                ResultTester.CheckResult<string>(Case5_ResultConcat, "ha ha "),
                ResultTester.CheckResult<string>(Case5_ResultStringBuilder, "ha ha "),
                ResultTester.CheckResult<string>(Case6_Result, Case6_ResultStringBuilder),
                ResultTester.CheckResult<string>(Case6_ResultConcat, Case6_Result),
                ResultTester.CheckResult<string>(Case6_ResultStringBuilder, Case6_ResultConcat),
                ResultTester.CheckResult<string>(Case7_Result, ""),
                ResultTester.CheckResult<string>(Case7_ResultConcat, ""),
                ResultTester.CheckResult<string>(Case7_ResultStringBuilder, ""),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("String repeat");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestStringrepeat());
        }
    }
}