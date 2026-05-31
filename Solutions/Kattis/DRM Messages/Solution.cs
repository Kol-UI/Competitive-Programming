// DRM Messages
namespace CompetitiveProgramming.Kattis.DRMMessages;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int half = s.Length / 2;
        string a = s.Substring(0, half);
        string b = s.Substring(half);
        
        int fst = a.Sum(c => c - 'A');
        int lst = b.Sum(c => c - 'A');
        
        char[] aRot = a.Select(c => (char)((c - 'A' + fst) % 26 + 'A')).ToArray();
        char[] bRot = b.Select(c => (char)((c - 'A' + lst) % 26 + 'A')).ToArray();
        
        char[] result = new char[half];
        for (int i = 0; i < half; i++)
        {
            result[i] = (char)((aRot[i] - 'A' + bRot[i] - 'A') % 26 + 'A');
        }
        
        Console.WriteLine(new string(result));
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("DRM Messages");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}