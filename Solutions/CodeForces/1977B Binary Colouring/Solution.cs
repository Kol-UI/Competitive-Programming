// Binary Colouring
namespace CompetitiveProgramming.CodeForces.BinaryColouring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            long x = long.Parse(Console.ReadLine());
            List<long> bits = new List<long>();
            
            while(x > 0)
            {
                bits.Add(x % 2);
                x /= 2;
            }
            
            bool carry = false;
            for(int p = 1; p < bits.Count; p++)
            {
                if(bits[p - 1] == 1 && bits[p] == 1)
                {
                    bits[p - 1] = -1;
                    bits[p] = 0;
                    carry = true;
                }
                else if(bits[p] == 1 && carry)
                {
                    bits[p] = 0;
                }
                else if(bits[p] == 1)
                {
                    continue;
                }
                else if(carry)
                {
                    bits[p] = 1;
                    carry = false;
                }
            }
            
            if(carry)
            {
                bits.Add(1);
            }
            
            Console.WriteLine(bits.Count);
            Console.WriteLine(string.Join(" ", bits.Select(x => x.ToString()).ToArray()));
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Binary Colouring");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}