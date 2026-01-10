// Hamming Sort
namespace CompetitiveProgramming.HackerEarth.HammingSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class HelloWorld
{
    static public void Main()
    {
        String line;
        line = Console.ReadLine();
        int T = Convert.ToInt32(line);

        for(int t_i = 0; t_i < T; t_i++)
        {
            String[] custom_input_1 = Console.ReadLine().Split(" ");
            int N = Convert.ToInt32(custom_input_1[0]);
            int K = Convert.ToInt32(custom_input_1[1]);
            line = Console.ReadLine();
            int[] A = new int[N];
            A = line.Split().Select(str => int.Parse(str)).ToArray();

            int[] out_ = solve(N, K, A);
            Console.Out.WriteLine(string.Join(" ", out_.Select(x => x.ToString()).ToArray()));

        }
    }

    static int[] solve(int N, int K, int[] A)
    {
        List<Tuple<int, int, int>> list = new List<Tuple<int, int, int>>();
        
        for(int i = 0; i < N; i++)
        {
            int hamming = 0;
            int xor = A[i] ^ K;
            while(xor > 0)
            {
                if((xor & 1) == 1) hamming++;
                xor >>= 1;
            }
            list.Add(new Tuple<int, int, int>(hamming, A[i], i));
        }
        
        list.Sort((a, b) => {
            if(a.Item1 != b.Item1) return a.Item1.CompareTo(b.Item1);
            if(a.Item2 != b.Item2) return a.Item2.CompareTo(b.Item2);
            return a.Item3.CompareTo(b.Item3);
        });
        
        int[] result = new int[N];
        for(int i = 0; i < N; i++)
        {
            result[i] = list[i].Item2;
        }
        
        return result;
    }

}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hamming Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}