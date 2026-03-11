// Huge Pile
namespace CompetitiveProgramming.CodeForces.HugePile;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0];
            long k = input[1];
            
            SortedDictionary<long, long> map = new SortedDictionary<long, long>();
            map[n] = 0;
            
            long answer = n != k ? -1 : 0;
            
            while(map.Count > 0)
            {
                var last = map.Last();
                long value = last.Key;
                long count = last.Value;
                
                long half1 = value / 2;
                long half2 = (value + 1) / 2;
                long newCount = count + 1;
                
                if(half1 == k)
                {
                    if(answer < 0 || newCount < answer) answer = newCount;
                }
                else if(half1 > k)
                {
                    if(!map.ContainsKey(half1) || map[half1] > newCount)
                    {
                        map[half1] = newCount;
                    }
                }
                
                if(half2 == k)
                {
                    if(answer < 0 || newCount < answer) answer = newCount;
                }
                else if(half2 > k)
                {
                    if(!map.ContainsKey(half2) || map[half2] > newCount)
                    {
                        map[half2] = newCount;
                    }
                }
                
                map.Remove(value);
            }
            
            Console.WriteLine(answer);
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
        StyleHelper.Title("Huge Pile");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}