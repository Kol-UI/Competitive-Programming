// Busy Schedule
namespace CompetitiveProgramming.Kattis.BusySchedule;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int TimeVal(string s)
    {
        string[] parts = s.Split();
        string timePart = parts[0];
        string apm = parts[1];
        
        string[] hm = timePart.Split(':');
        int h = int.Parse(hm[0]) % 12;
        int m = int.Parse(hm[1]);
        
        if (apm[0] == 'p')
            h += 12;
        
        return h * 60 + m;
    }
    
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;
            
            List<string> times = new List<string>();
            for (int i = 0; i < n; i++)
                times.Add(Console.ReadLine());
            
            times = times.OrderBy(t => TimeVal(t)).ToList();
            
            foreach (string t in times)
                Console.WriteLine(t);
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Busy Schedule");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}