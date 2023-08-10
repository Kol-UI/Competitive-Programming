// Convolution

using System;
namespace CompetitiveProgramming.AtCoder.FConvolution
{
    class Program
    {
        const int MOD = 998244353;

        public static void FConvolutionMain()
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int len = N + M - 1;
            int[] c = new int[len];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    c[i + j] = (c[i + j] + (int)((long)a[i] * b[j] % MOD)) % MOD;
                }
            }

            Console.WriteLine(string.Join(" ", c));
        }
    }

}
