// Minor Reduction
namespace CompetitiveProgramming.CodeForces.MinorReduction;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Text;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            bool done = false;
            StringBuilder sb = new StringBuilder(s);
            
            for(int p = sb.Length - 1; p >= 1; p--)
            {
                int sum = (sb[p - 1] - '0') + (sb[p] - '0');
                if(sum > 9)
                {
                    sb[p - 1] = (char)('0' + sum / 10);
                    sb[p] = (char)('0' + sum % 10);
                    done = true;
                    break;
                }
            }
            
            if(done)
            {
                Console.WriteLine(sb.ToString());
                continue;
            }
            
            int firstSum = (s[0] - '0') + (s[1] - '0');
            Console.Write((char)(firstSum + '0'));
            Console.WriteLine(s.Substring(2));
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
        StyleHelper.Title("Minor Reduction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}