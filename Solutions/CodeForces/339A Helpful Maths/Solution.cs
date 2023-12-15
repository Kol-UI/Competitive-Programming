// Helpful Maths

/*
Xenia the beginner mathematician is a third year student at elementary school. She is now learning the addition operation.

The teacher has written down the sum of multiple numbers. Pupils should calculate the sum. To make the calculation easier, the sum only contains numbers 1, 2 and 3. Still, that isn't enough for Xenia. She is only beginning to count, so she can calculate a sum only if the summands follow in non-decreasing order. For example, she can't calculate sum 1+3+2+1 but she can calculate sums 1+1+2 and 3+3.

You've got the sum that was written on the board. Rearrange the summans and print the sum in such a way that Xenia can calculate the sum.

Input
The first line contains a non-empty string s — the sum Xenia needs to count. String s contains no spaces. It only contains digits and characters "+". Besides, string s is a correct sum of numbers 1, 2 and 3. String s is at most 100 characters long.

Output
Print the new sum that Xenia can count.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.HelpfulMaths
{
    // Solution
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string sum = Console.ReadLine();
            int[] numbers = sum.Split('+').Select(int.Parse).ToArray();
            Array.Sort(numbers);
            string newSum = string.Join("+", numbers);
            Console.WriteLine(newSum);
        }
    }
    */

    // Test
    public class Test
    {
        private static string TestHelpfulMaths(string sum)
        {
            int[] numbers = sum.Split('+').Select(int.Parse).ToArray();
            Array.Sort(numbers);
            string newSum = string.Join("+", numbers);
            return newSum;
        }

        public static bool[] TestCases()
        {
            string case1 = "3+2+1";
            string result1 = "1+2+3";
            string case2 = "1+1+3+1+3";
            string result2 = "1+1+1+3+3";
            string case3 = "2";
            string result3 = "2";
            string case4 = "2+2+1+1+3";
            string result4 = "1+1+2+2+3";
            string case5 = "2+1+2+2+2+3+1+3+1+2";
            string result5 = "1+1+1+2+2+2+2+2+3+3";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Test.TestHelpfulMaths(case1), result1),
                ResultTester.CheckResult<string>(Test.TestHelpfulMaths(case2), result2),
                ResultTester.CheckResult<string>(Test.TestHelpfulMaths(case3), result3),
                ResultTester.CheckResult<string>(Test.TestHelpfulMaths(case4), result4),
                ResultTester.CheckResult<string>(Test.TestHelpfulMaths(case5), result5),
            };
            return results;
        }
    }
}