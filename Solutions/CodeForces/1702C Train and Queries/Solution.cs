// Train and Queries
namespace CompetitiveProgramming.CodeForces.TrainandQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            Console.ReadLine();
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = firstLine[0];
            int k = firstLine[1];
            
            int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Dictionary<int, int> first = new Dictionary<int, int>();
            Dictionary<int, int> last = new Dictionary<int, int>();
            
            for(int p = 0; p < n; p++)
            {
                last[s[p]] = p;
                if(!first.ContainsKey(s[p]))
                {
                    first[s[p]] = p;
                }
            }
            
            for(int q = 0; q < k; q++)
            {
                var query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = query[0];
                int y = query[1];
                
                bool res = first.ContainsKey(x) && last.ContainsKey(y) && first[x] <= last[y];
                Console.WriteLine(res ? "YES" : "NO");
            }
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
        StyleHelper.Title("Train and Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}