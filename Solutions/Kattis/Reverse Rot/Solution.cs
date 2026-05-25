// Reverse Rot
namespace CompetitiveProgramming.Kattis.ReverseRot;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Rotate(ref char c)
    {
        c++;
        if (c == 'Z' + 1) c = '_';
        if (c == '_' + 1) c = '.';
        if (c == '.' + 1) c = 'A';
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split();
            if (input.Length < 2) break;
            
            int rotation = int.Parse(input[0]);
            string s = input[1];
            
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < rotation; i++)
                {
                    Rotate(ref arr[j]);
                }
            }
            
            Console.WriteLine(new string(arr));
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reverse Rot");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}