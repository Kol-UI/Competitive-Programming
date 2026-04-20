// Rooms and Staircases
namespace CompetitiveProgramming.CodeForces.RoomsandStaircases;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            int firstOne = s.IndexOf('1');
            int lastOne = s.LastIndexOf('1');
            
            if (firstOne == -1)
            {
                Console.WriteLine(n);
            }
            else
            {
                int maxFromLeft = (lastOne + 1) * 2;
                int maxFromRight = (n - firstOne) * 2;
                Console.WriteLine(Math.Max(maxFromLeft, maxFromRight));
            }
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
        StyleHelper.Title("Rooms and Staircases");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}