// Taxi
namespace CompetitiveProgramming.CodeForces.Taxi;
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
        int n = int.Parse(Console.ReadLine());
        List<int> v = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        v.Sort((a, b) => b.CompareTo(a));
        int cnt = 0;
        int left = 0;
        int right = v.Count - 1;
        
        while (left <= right)
        {
            if (v[left] == 4)
            {
                cnt++;
                left++;
            }
            else
            {
                int sum = v[left];
                while (left < right && sum + v[right] <= 4)
                {
                    sum += v[right];
                    right--;
                }
                cnt++;
                left++;
            }
        }
        
        Console.WriteLine(cnt);
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
        StyleHelper.Title("Taxi");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
	}
}