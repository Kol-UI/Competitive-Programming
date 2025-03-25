// Binary Matrix
namespace CompetitiveProgramming.CodeForces.BinaryMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Solution {
    //public static void Main() {
    public static void MainSolution() {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0) {
            string[] parts = Console.ReadLine()!.Split();
            int n = int.Parse(parts[0]);
            int m = int.Parse(parts[1]);
            int[,] mat = new int[n, m];
            for (int i = 0; i < n; i++) {
                string s = Console.ReadLine()!.Trim();
                for (int j = 0; j < m; j++) {
                    mat[i, j] = s[j] - '0';
                }
            }
            int[] rows = new int[n];
            int[] cols = new int[m];
            for (int i = 0; i < n; i++) {
                int xor = 0;
                for (int j = 0; j < m; j++) xor ^= mat[i, j];
                rows[i] = xor;
            }
            for (int j = 0; j < m; j++) {
                int xor = 0;
                for (int i = 0; i < n; i++) xor ^= mat[i, j];
                cols[j] = xor;
            }
            int k = 0, l = 0;
            foreach (int x in rows) if (x == 1) k++;
            foreach (int x in cols) if (x == 1) l++;
            Console.WriteLine(Math.Max(k, l));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Binary Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}