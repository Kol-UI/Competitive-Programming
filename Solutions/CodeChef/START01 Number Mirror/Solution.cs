// Number Mirror
/*
Problem
Write a program that takes a number N as the input, and prints it to the output.

Input Format
The only line contains a single integer.

Output Format
Output the answer in a single line.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.NumberMirror
{
    public class Test
    {
        /*
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine(num);
        }
        */
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number Mirror");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC);
        }
    }
}