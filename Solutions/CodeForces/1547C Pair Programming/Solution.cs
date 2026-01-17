// Pair Programming
namespace CompetitiveProgramming.CodeForces.PairProgramming;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Text;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            Console.ReadLine();
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = firstLine[0];
            int n = firstLine[1];
            int m = firstLine[2];
            
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            StringBuilder res = new StringBuilder();
            int ta = 0, tb = 0;
            int lines = k;
            bool possible = true;
            
            while(ta < n || tb < m)
            {
                if(ta < n && a[ta] == 0)
                {
                    res.Append("0 ");
                    lines++;
                    ta++;
                }
                else if(tb < m && b[tb] == 0)
                {
                    res.Append("0 ");
                    lines++;
                    tb++;
                }
                else if(ta < n && a[ta] <= lines)
                {
                    res.Append(a[ta].ToString() + " ");
                    ta++;
                }
                else if(tb < m && b[tb] <= lines)
                {
                    res.Append(b[tb].ToString() + " ");
                    tb++;
                }
                else
                {
                    possible = false;
                    break;
                }
            }
            
            if(!possible)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(res.ToString().Trim());
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
        StyleHelper.Title("Pair Programming");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}