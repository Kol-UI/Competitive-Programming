// Radio Station
namespace CompetitiveProgramming.CodeForces.RadioStation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        
        Dictionary<string, string> sl = new Dictionary<string, string>();
        
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split();
            string name = data[0];
            string ip = data[1];
            sl[ip] = name;
        }
        
        for (int i = 0; i < m; i++)
        {
            string[] data = Console.ReadLine().Split();
            string command = data[0];
            string ip = data[1];
            string ipWithoutSemicolon = ip.Substring(0, ip.Length - 1);
            Console.WriteLine($"{command} {ip} #{sl[ipWithoutSemicolon]}");
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
        StyleHelper.Title("Radio Station");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}