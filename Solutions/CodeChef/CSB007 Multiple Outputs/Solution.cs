// CSB007 Multiple Outputs

/*
We can add as many Console.Write() statements as we want.
Write a program which does the following

Output: 3 + 4
Output: 2 + 1.
Note - Notice that in the output they are printed together without any space between them.
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CSB007MultipleOutputs
{
    class Program
    {
        // static void Main(string[] args)
        public static void Solution()
        {
            Console.Write(3 + 4);
            Console.Write(2 + 1);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiple Outputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}