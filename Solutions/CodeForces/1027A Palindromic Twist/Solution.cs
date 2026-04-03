// Palindromic Twist
namespace CompetitiveProgramming.CodeForces.PalindromicTwist;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine()!;
            bool possible = true;
            
            for (int p = 0; 2 * p < n; p++)
            {
                char left = s[p];
                char right = s[n - 1 - p];
                int diff = Math.Abs(left - right);
                
                if (diff != 0 && diff != 2)
                {
                    possible = false;
                    break;
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Palindromic Twist");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}