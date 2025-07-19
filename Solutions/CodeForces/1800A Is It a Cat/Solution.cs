// Is It a Cat
namespace CompetitiveProgramming.CodeForces.IsItaCat;
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
        string cs = "meow";
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int idx = 0;
            bool iscat = s[0] == 'm' || s[0] == 'M';
            
            for (int p = 0; iscat && p < s.Length; p++)
            {
                if ('A' <= s[p] && s[p] <= 'Z')
                {
                    s = s.Substring(0, p) + (char)(s[p] + 32) + s.Substring(p + 1);
                }
                
                if (s[p] == cs[idx]) continue;
                else if (idx + 1 < cs.Length && s[p] == cs[idx + 1]) idx++;
                else iscat = false;
            }
            
            iscat = iscat && (idx == 3);
            Console.WriteLine(iscat ? "YES" : "NO");
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
        StyleHelper.Title("Is It a Cat?");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}