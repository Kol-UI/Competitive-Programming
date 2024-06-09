// Print 1 To N Without Loop

/*
Print numbers from 1 to N without the help of loops.

Example 1:

Input:
N = 10
Output: 1 2 3 4 5 6 7 8 9 10

Example 2:

Input:
N = 5
Output: 1 2 3 4 5
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.GeeksForGeeks.School.Print1ToNWithoutLoop
{
    class Solution
    {
        public void printNos( int n)
        {
            if (n > 0)
            {
                printNos(n - 1);
                
                Console.Write(n + " ");
            }
        }

    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print 1 To N Without Loop");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.SchoolGFG);
        }
    }
}