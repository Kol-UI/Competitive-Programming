// Fun House
namespace CompetitiveProgramming.Kattis.FunHouse;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        int h_ptr = 1;
        
        while (true)
        {
            string[] firstLine = Console.ReadLine().Split();
            int m = int.Parse(firstLine[0]);
            int n = int.Parse(firstLine[1]);
            
            if (m + n == 0) break;
            
            char[][] a = new char[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine().ToCharArray();
            }
            
            int si = 0, sj = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i][j] == '*')
                    {
                        si = i;
                        sj = j;
                        break;
                    }
                }
                if (a[si][sj] == '*') break;
            }
            
            int di = (si == 0) ? 1 : (si == n - 1) ? -1 : 0;
            int dj = (sj == 0) ? 1 : (sj == m - 1) ? -1 : 0;
            
            while (a[si][sj] != 'x')
            {
                si += di;
                sj += dj;
                
                if (a[si][sj] == '/')
                {
                    if (di == 1) { di = 0; dj = -1; }
                    else if (di == -1) { di = 0; dj = 1; }
                    else if (dj == 1) { di = -1; dj = 0; }
                    else if (dj == -1) { di = 1; dj = 0; }
                }
                else if (a[si][sj] == '\\')
                {
                    if (di == 1) { di = 0; dj = 1; }
                    else if (di == -1) { di = 0; dj = -1; }
                    else if (dj == 1) { di = 1; dj = 0; }
                    else if (dj == -1) { di = -1; dj = 0; }
                }
            }
            
            a[si][sj] = '&';
            
            Console.WriteLine($"HOUSE {h_ptr}");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(a[i]));
            }
            h_ptr++;
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fun House");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}