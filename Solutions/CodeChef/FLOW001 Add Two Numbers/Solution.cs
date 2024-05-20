using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

/*
Problem Statement
The task is very simple: given two integers A and B, write a program to add these two numbers and output it.

Input Format
The first line contains an integer T, the total number of test cases. Then follow T lines, each line contains two Integers A and B.

Output Format
For each test case, add A and B and display the sum in a new line.

Everything your program prints is considered “output”, so if you output some debugging statements like “Please enter T”, this will be considered as part of your answer, and because it does not satisfy the output format, it will be marked wrong, even if your answer is otherwise correct!
Constraints
1 ≤ T ≤ 1000
0 ≤ A,B ≤ 10000
Sample 1:
Input
Output
3
1 2
100 200
10 40
3
300
50
*/

namespace CompetitiveProgramming.CodeChef.AddTwoNumbers
{
    public class Solution
    {
        /*
        public static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] lines = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(lines[0])+int.Parse(lines[1]));
            }
        }
        */
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}