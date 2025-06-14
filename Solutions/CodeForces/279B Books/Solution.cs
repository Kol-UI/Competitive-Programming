// Books
namespace CompetitiveProgramming.CodeForces.Books;
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
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int t = int.Parse(firstLine[1]);
        
        int[] books = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int maxBooks = 0;
        int currentSum = 0;
        int left = 0;
        
        for (int right = 0; right < n; right++)
        {
            currentSum += books[right];
            
            while (currentSum > t)
            {
                currentSum -= books[left];
                left++;
            }
            
            maxBooks = Math.Max(maxBooks, right - left + 1);
        }
        
        Console.WriteLine(maxBooks);
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
        StyleHelper.Title("Books");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1400);
	}
}