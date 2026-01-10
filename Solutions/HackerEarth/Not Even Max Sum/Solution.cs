// Not Even Max Sum
namespace CompetitiveProgramming.HackerEarth.NotEvenMaxSum;
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
        String line = Console.ReadLine();
        int T = Convert.ToInt32(line);
        
        for(int t = 0; t < T; t++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            long totalSum = 0;
            int smallestOdd = int.MaxValue;
            
            foreach(int num in A)
            {
                totalSum += num;
                if(num % 2 == 1 && num < smallestOdd)
                {
                    smallestOdd = num;
                }
            }
            
            if(totalSum % 2 == 1)
            {
                Console.WriteLine(totalSum);
            }
            else if(smallestOdd == int.MaxValue)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(totalSum - smallestOdd);
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Not Even Max Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}