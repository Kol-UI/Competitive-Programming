// Specia Digits

/*
You are given 5 integers - N,A,B,C,D.
Let us say all the integers of length N, having only A or B in their decimal representation are good integers. Also, among all the good integers, all those integers whose sum of digits should contains either C or D or both on it, are best integers.
Find the number of best integers of length N. Since the number of best integers can be huge, print it modulo 109+7.

Example 1:
Input:
N = 2, A = 1, B = 2, C = 3, D = 5
Output: 
2
Explanation: 
The following are good integers:- 
{ 12 , 22 , 11 , 21 }
And the following are best integers:- 
{ 12, 21 } because sum of digits 3 & 5
contains C & D, which is 3 as well as 5.

Example 2:
Input:
N = 1, A = 1, B = 1, C = 2, D = 3
Output: 
0
Explanation: 
The following are good integers: - { 1 }
Since sum of digits is 1 which does not contains
C or D, therefore, answer is 0.

Example 3:
Input:
N = 4, A = 6, B = 7, C = 5, D = 3
Output: 
4
Explanation: 
The following are good integers:- 
{ 6667 , 6676 , 6766 , 7666.....and many more}
out of all these four { 6667 , 6676 , 6766 , 7666}
is best number because sum of all these four 
numbers is 25, which contains C, which is 5.
Your Task:
The task is to complete the function solve() which takes five integers N,A,B,C and D as input parameters and returns the number of best integers modulo 109+7.
*/


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Hard.SpecialDigits
{
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Digits");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.HardGFG);
        }
    }
}