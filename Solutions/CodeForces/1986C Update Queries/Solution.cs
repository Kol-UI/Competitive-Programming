// Update Queries
namespace CompetitiveProgramming.CodeForces.UpdateQueries;


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0], m = nm[1];
            char[] s = Console.ReadLine().ToCharArray();
            HashSet<int> positions = new HashSet<int>();
            
            int[] x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int pos in x) positions.Add(pos - 1);
            
            char[] r = Console.ReadLine().ToCharArray();
            Array.Sort(r);
            
            int idx = 0;
            foreach (int pos in positions.OrderBy(p => p))
            {
                s[pos] = r[idx++];
            }
            
            Console.WriteLine(new string(s));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Update Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}