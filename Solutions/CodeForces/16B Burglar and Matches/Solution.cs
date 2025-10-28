// Burglar and Matches
namespace CompetitiveProgramming.CodeForces.BurglarandMatches;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Container
{
    public long boxes;
    public long matches;
}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);
        List<Container> contVec = new List<Container>();
        for (long k = 0; k < m; k++)
        {
            string[] data = Console.ReadLine().Split();
            contVec.Add(new Container 
            { 
                boxes = long.Parse(data[0]), 
                matches = long.Parse(data[1]) 
            });
        }
        contVec = contVec.OrderBy(x => x.matches).ToList();
        long capacity = n;
        long output = 0;
        for (long k = m - 1; k >= 0; k--)
        {
            if (capacity > contVec[(int)k].boxes)
            {
                output += contVec[(int)k].boxes * contVec[(int)k].matches;
                capacity -= contVec[(int)k].boxes;
            }
            else
            {
                output += capacity * contVec[(int)k].matches;
                break;
            }
        }
        Console.WriteLine(output);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Burglar and Matches");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}