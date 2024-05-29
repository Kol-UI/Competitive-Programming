// Codeland Username Validation

/*
Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:

1. The username is between 4 and 25 characters.
2. It must start with a letter.
3. It can only contain letters, numbers, and the underscore character.
4. It cannot end with an underscore character.

If the username is valid then your program should return the string true, otherwise return the string false.
Examples
Input: "aa_"
Output: false
Input: "u__hello_world123"
Output: true
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.CodelandUsernameValidation
{
    class MainClass
    {
        public static string CodelandUsernameValidation(string str)
        {
            if (str.Length < 4 || str.Length > 25)
            {
            return "false";
            }

            if (!char.IsLetter(str[0]))
            {
            return "false";
            }

            foreach (char c in str)
            {
            if (!char.IsLetterOrDigit(c) && c != '_')
            {
                return "false";
            }
            }

            if (str[str.Length - 1] == '_')
            {
            return "false";
            }

            return "true";
        }

        /*
        static void Main()
        {
            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()!));
        }
        */
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(MainClass.CodelandUsernameValidation("aa_"), "false"),
                ResultTester.CheckResult<string>(MainClass.CodelandUsernameValidation("u__hello_world123"), "true"),
                ResultTester.CheckResult<string>(MainClass.CodelandUsernameValidation("aaaaaaaaaa"), "true"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Codeland Username Validation");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.EasyCB, Test.TestCases());
        }
    }
}