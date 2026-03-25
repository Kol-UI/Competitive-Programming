// Deck of Cards
namespace CompetitiveProgramming.CodeForces.DeckofCards;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            
            string s = Console.ReadLine()!;
            
            int countZero = s.Count(c => c == '0');
            int countOne = s.Count(c => c == '1');
            int countTwo = s.Count(c => c == '2');
            
            char[] w = new char[n];
            for(int p = 0; p < n; p++)
            {
                w[p] = '+';
            }
            
            for(int p = 0; p < n; p++)
            {
                if(p < countZero + countTwo || p + countOne + countTwo >= n)
                {
                    w[p] = '?';
                }
                if(p < countZero || p + countOne >= n || k == n)
                {
                    w[p] = '-';
                }
            }
            
            Console.WriteLine(new string(w));
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
        StyleHelper.Title("Deck of Cards");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}