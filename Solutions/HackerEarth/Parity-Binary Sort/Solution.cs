// Parity-Binary Sort
namespace CompetitiveProgramming.HackerEarth.ParityBinarySort;
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
        String line = Console.ReadLine();
        int T = Convert.ToInt32(line);
        
        for(int t = 0; t < T; t++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            List<int> evenBits = new List<int>();
            List<int> oddBits = new List<int>();
            
            foreach(int num in A)
            {
                int setBits = 0;
                int temp = num;
                while(temp > 0)
                {
                    if((temp & 1) == 1) setBits++;
                    temp >>= 1;
                }
                
                if(setBits % 2 == 0)
                {
                    evenBits.Add(num);
                }
                else
                {
                    oddBits.Add(num);
                }
            }
            
            evenBits.Sort();
            oddBits.Sort();
            
            List<int> result = new List<int>();
            result.AddRange(evenBits);
            result.AddRange(oddBits);
            
            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString()).ToArray()));
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
        StyleHelper.Title("Parity-Binary Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}