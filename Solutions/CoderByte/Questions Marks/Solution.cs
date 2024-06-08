// Questions Marks

/*
Have the function QuestionsMarks(str) take the str string parameter, which will contain single digit numbers, letters, and question marks, and check if there are exactly 3 question marks between every pair of two numbers that add up to 10. If so, then your program should return the string true, otherwise it should return the string false. If there aren't any two numbers that add up to 10 in the string, then your program should return false as well.

For example: if str is "arrb6???4xxbl5???eee5" then your program should return true because there are exactly 3 question marks between 6 and 4, and 3 question marks between 5 and 5 at the end of the string.
Examples
Input: "aa6?9"
Output: false
Input: "acc?7??sss?3rr1??????5"
Output: true
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.QuestionsMarks
{
    class MainClass
    {
        public static string QuestionsMarks(string str)
        {
            int digitSum = 0;
            int consecutiveDigits = 0;
            int questionMarkCount = 0;

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    digitSum += digit;

                    if (digitSum == 10)
                    {
                    if (questionMarkCount != 3)
                    {
                        return "false";
                    }
                    }

                    digitSum -= consecutiveDigits > 0 ? (str[consecutiveDigits - 1] - '0') : 0;
                    consecutiveDigits = 0;
                    questionMarkCount = 0;
                }
                else if (c == '?')
                {
                    questionMarkCount++;
                    consecutiveDigits++;
                }
            }

            return "true";
        }

        /*
        static void Main()
        {  
            // keep this function call here
            Console.WriteLine(QuestionsMarks(Console.ReadLine()));
        }
        */

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(MainClass.QuestionsMarks("aa6?9"), "true"),
                ResultTester.CheckResult<string>(MainClass.QuestionsMarks("acc?7??sss?3rr1??????5"), "true"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Questions Marks");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.EasyCBy, Test.TestCases());
        }
    }
}