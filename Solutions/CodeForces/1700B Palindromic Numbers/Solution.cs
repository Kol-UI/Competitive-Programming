// Palindromic Numbers
namespace CompetitiveProgramming.CodeForces.PalindromicNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Text;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int len = int.Parse(Console.ReadLine());
            string s = Console.ReadLine()!;
            
            StringBuilder result = new StringBuilder(new string('_', len));
            
            if(s[0] != '9')
            {
                for(int p = 0; p < len; p++)
                {
                    result[p] = (char)('0' + ('9' - s[p]));
                }
            }
            else
            {
                int carry = 0;
                for(int p = len - 1; p >= 0; p--)
                {
                    int a = 1 - carry;
                    int b = s[p] - '0';
                    int diff = a - b;
                    
                    if(diff < 0)
                    {
                        carry = 1;
                        diff += 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    
                    result[p] = (char)(diff + '0');
                }
            }
            
            Console.WriteLine(result.ToString());
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Palindromic Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}