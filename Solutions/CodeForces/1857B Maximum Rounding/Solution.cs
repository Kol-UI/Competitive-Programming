// Maximum Rounding
namespace CompetitiveProgramming.CodeForces.MaximumRounding;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            int idx = s.Length;
            bool carry = false;
            
            for(int p = s.Length - 1; p >= 0; p--)
            {
                if(s[p] >= '5' || (s[p] == '4' && carry))
                {
                    idx = p;
                    carry = true;
                }
                else
                {
                    carry = false;
                }
            }
            
            if(idx == s.Length)
            {
                Console.WriteLine(s);
                continue;
            }
            
            if(idx == 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write(s.Substring(0, idx - 1));
                Console.Write((char)(s[idx - 1] + 1));
            }
            
            for(int p = idx; p < s.Length; p++)
            {
                Console.Write("0");
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Rounding");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}