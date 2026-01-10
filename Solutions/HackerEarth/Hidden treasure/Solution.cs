// Hidden treasure
namespace CompetitiveProgramming.HackerEarth.Hiddentreasure;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class HelloWorld
{
    static public void Main()
    {
        String line;
        line = Console.ReadLine();
        int n = Convert.ToInt32(line);
        line = Console.ReadLine();
        int[] nums = new int[n];
        nums = line.Split().Select(str => int.Parse(str)).ToArray();

        long out_ = solve(n, nums);
        Console.Out.WriteLine(out_);
    }
static long solve(int n, int[] nums)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        long count = 0;
        
        foreach(int num in nums)
        {
            int sum = 0;
            int temp = Math.Abs(num);
            while(temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            
            if(freq.ContainsKey(sum))
            {
                count += freq[sum];
                freq[sum]++;
            }
            else
            {
                freq[sum] = 1;
            }
        }
        
        return count;
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hidden treasure");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.MediumHE);
    }
}