// Accessing characters of a String

/*
Write a program that does the following

Declare a string variable txt and initialize it to the value "Programming"
Print the 3rd and 5th Characters from txt in separate lines.
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.UserInputUsrs1
{
    public class Solution
    {
        public static void Anwser()
        {
            string v = Console.ReadLine()!;
            Console.WriteLine( v );
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("User Input");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}