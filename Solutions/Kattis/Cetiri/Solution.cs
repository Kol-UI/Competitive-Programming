// Cetiri
namespace CompetitiveProgramming.Kattis.Cetiri;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool Works(List<int> v, int n)
    {
        List<int> temp = new List<int>(v);
        temp.Add(n);
        temp.Sort();
        
        for (int i = 0; i < temp.Count - 2; i++)
        {
            if (temp[i + 1] - temp[i] != temp[i + 2] - temp[i + 1])
                return false;
        }
        return true;
    }
    
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        List<int> v = new List<int> { int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]) };
        v.Sort();
        
        List<int> possible = new List<int>();
        int diff1 = v[2] - v[1];
        int diff2 = v[1] - v[0];
        
        possible.Add(v[0] + diff1);
        possible.Add(v[1] + diff1);
        possible.Add(v[2] + diff1);
        possible.Add(v[0] - diff1);
        possible.Add(v[1] - diff1);
        possible.Add(v[2] - diff1);
        possible.Add(v[0] + diff2);
        possible.Add(v[1] + diff2);
        possible.Add(v[2] + diff2);
        possible.Add(v[0] - diff2);
        possible.Add(v[1] - diff2);
        possible.Add(v[2] - diff2);
        
        foreach (int i in possible)
        {
            if (Works(v, i))
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cetiri");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}