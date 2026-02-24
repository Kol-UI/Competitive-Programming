// Strange List
namespace CompetitiveProgramming.CodeForces.StrangeList;
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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int x = input[1];
            
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Queue<(int value, int count)> queue = new Queue<(int, int)>();
            
            for(int p = 0; p < n; p++)
            {
                queue.Enqueue((arr[p], 1));
            }
            
            long result = 0;
            bool add = true;
            
            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                int val = current.value;
                int cnt = current.count;
                result += (long)val * cnt;
                
                if(val % x == 0 && add)
                {
                    queue.Enqueue((val / x, x * cnt));
                }
                else
                {
                    add = false;
                }
            }
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Strange List");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}