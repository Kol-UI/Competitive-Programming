// Petr and Book
namespace CompetitiveProgramming.CodeForces.PetrandBook;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        const int numDays = 7;
        int numPages = int.Parse(Console.ReadLine());
        int[] weekPages = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int total = 0;

        foreach (int pages in weekPages)
        {
            total += pages;
        }

        numPages %= total;
        if (numPages == 0)
        {
            numPages = total;
        }

        for (int k = 0; k <= numDays; k++)
        {
            if (numPages <= 0)
            {
                Console.WriteLine(k);
                break;
            }
            numPages -= weekPages[k];
        }
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
        StyleHelper.Title("Petr and Book");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}
