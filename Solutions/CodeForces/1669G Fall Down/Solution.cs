// Fall Down
namespace CompetitiveProgramming.CodeForces.FallDown;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long nr = long.Parse(firstLine[0]);
            long nc = long.Parse(firstLine[1]);
            
            char[][] v = new char[nr][];
            for (long row = 0; row < nr; row++)
            {
                v[row] = Console.ReadLine().ToCharArray();
            }
            
            for (long col = 0; col < nc; col++)
            {
                long b = nr - 1;
                for (long row = nr - 1; row >= 0; row--)
                {
                    if (v[row][col] == '*')
                    {
                        v[row][col] = '.';
                        v[b][col] = '*';
                        b--;
                    }
                    else if (v[row][col] == 'o')
                    {
                        b = row - 1;
                    }
                }
            }
            
            for (long row = 0; row < nr; row++)
            {
                Console.WriteLine(new string(v[row]));
            }
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
        StyleHelper.Title("Fall Down");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}