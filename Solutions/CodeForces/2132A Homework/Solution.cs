// Homework
namespace CompetitiveProgramming.CodeForces.Homework;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string w = Console.ReadLine();
            
            string leftPart = "";
            string rightPart = "";
            
            for (int i = 0; i < m; i++)
            {
                if (w[i] == 'V')
                {
                    leftPart += b[i];
                }
                else
                {
                    rightPart += b[i];
                }
            }
            
            char[] leftArray = leftPart.ToCharArray();
            Array.Reverse(leftArray);
            leftPart = new string(leftArray);
            
            Console.WriteLine(leftPart + a + rightPart);
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
        StyleHelper.Title("Homework");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}