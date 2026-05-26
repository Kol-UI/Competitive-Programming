// Encoded Message
namespace CompetitiveProgramming.Kattis.EncodedMessage;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            int size = (int)Math.Sqrt(s.Length);
            
            char[][] v = new char[size][];
            for (int j = 0; j < size; j++)
            {
                v[j] = new char[size];
                for (int k = 0; k < size; k++)
                {
                    v[j][k] = s[j * size + k];
                }
            }
            
            for (int j = size - 1; j >= 0; j--)
            {
                for (int k = 0; k < size; k++)
                {
                    Console.Write(v[k][j]);
                }
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Encoded Message");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}