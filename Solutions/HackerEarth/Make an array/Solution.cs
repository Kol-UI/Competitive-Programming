namespace CompetitiveProgramming.HackerEarth.Makeanarray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.IO;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        String line;
        line = Console.ReadLine();
        int T = Convert.ToInt32(line);

        for(int t_i = 0; t_i < T; t_i++)
        {
            line = Console.ReadLine();
            int N = Convert.ToInt32(line);
            line = Console.ReadLine();
            int[] A = new int[N];
            A = line.Split().Select(str => int.Parse(str)).ToArray();

            int out_ = solve(N, A);
            Console.Out.WriteLine(out_);
        }
    }
    
    static int solve(int N, int[] A)
    {
        long sum = 0;
        long max = 0;
        foreach(int num in A)
        {
            sum += num;
            if(num > max) max = num;
        }
        if(sum % (N-1) != 0) return -1;
        long ops = sum / (N-1);
        if(ops < max) return -1;
        return (int)ops;
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make an array");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}