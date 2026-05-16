// Yoda
namespace CompetitiveProgramming.Kattis.Yoda;
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
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();
        Array.Reverse(arr1);
        Array.Reverse(arr2);

        string rev1 = new string(arr1);
        string rev2 = new string(arr2);

        while (rev1.Length < rev2.Length) rev1 += '0';
        while (rev1.Length > rev2.Length) rev2 += '0';

        string t1 = "";
        string t2 = "";

        for (int i = 0; i < rev1.Length; i++)
        {
            if (rev1[i] >= rev2[i]) t1 += rev1[i];
            if (rev2[i] >= rev1[i]) t2 += rev2[i];
        }

        while (t1.Length > 1 && t1[t1.Length - 1] == '0') t1 = t1.Substring(0, t1.Length - 1);
        while (t2.Length > 1 && t2[t2.Length - 1] == '0') t2 = t2.Substring(0, t2.Length - 1);

        char[] t1Arr = t1.ToCharArray();
        char[] t2Arr = t2.ToCharArray();
        Array.Reverse(t1Arr);
        Array.Reverse(t2Arr);

        string res1 = new string(t1Arr);
        string res2 = new string(t2Arr);

        Console.WriteLine(res1.Length > 0 ? res1 : "YODA");
        Console.WriteLine(res2.Length > 0 ? res2 : "YODA");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Yoda");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}