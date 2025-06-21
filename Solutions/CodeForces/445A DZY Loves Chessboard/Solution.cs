// DZY Loves Chessboard
namespace CompetitiveProgramming.CodeForces.DZYLovesChessboard;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        string s = "BW";

        for (int i = 0; i < n; i++)
        {
            int toggle = 0;
            string line = Console.ReadLine()!;
            for (int j = 0; j < m; j++)
            {
                char x = line[j];
                if (x != '-')
                {
                    x = s[toggle % 2];
                }
                toggle++;
                Console.Write(x);
            }
            char[] chars = s.ToCharArray();
            char temp = chars[0];
            chars[0] = chars[1];
            chars[1] = temp;
            s = new string(chars);
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("DZY Loves Chessboard");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}