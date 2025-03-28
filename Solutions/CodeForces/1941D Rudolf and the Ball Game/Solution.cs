// Rudolf and the Ball Game
namespace CompetitiveProgramming.CodeForces.RudolfandtheBallGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] nmx = Console.ReadLine()!.Split();
            int n = int.Parse(nmx[0]);
            int m = int.Parse(nmx[1]);
            int x = int.Parse(nmx[2]);
            
            HashSet<int> currentPositions = new HashSet<int>();
            currentPositions.Add(x);
            
            for (int i = 0; i < m; i++)
            {
                string[] move = Console.ReadLine()!.Split();
                int r = int.Parse(move[0]);
                char c = move[1][0];
                
                HashSet<int> newPositions = new HashSet<int>();
                
                foreach (int pos in currentPositions)
                {
                    if (c == '0' || c == '?')
                    {
                        int newPos = pos + r;
                        if (newPos > n) newPos -= n;
                        newPositions.Add(newPos);
                    }
                    if (c == '1' || c == '?')
                    {
                        int newPos = pos - r;
                        if (newPos < 1) newPos += n;
                        newPositions.Add(newPos);
                    }
                }
                
                currentPositions = newPositions;
            }
            
            Console.WriteLine(currentPositions.Count);
            Console.WriteLine(string.Join(" ", currentPositions.OrderBy(p => p)));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rudolf and the Ball Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}