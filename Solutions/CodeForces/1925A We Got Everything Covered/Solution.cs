// We Got Everything Covered


using System;
using System.Text;
namespace CompetitiveProgramming.CodeForces.WeGotEverythingCovered
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                Solve();
            }
        }
        */

        static void Solve()
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (char ch = 'a'; ch < 'a' + k; ch++)
                {
                    sb.Append(ch);
                }
            }
            Console.WriteLine(sb);
        }
    }
}