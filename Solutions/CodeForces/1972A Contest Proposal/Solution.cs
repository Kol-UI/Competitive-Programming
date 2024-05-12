// 1972A - Contest Proposal

using System;
using System.Text;
namespace CompetitiveProgramming.CodeForces.ContestProposal
{
    public class Program
    {
        // Main()
        public static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);
                int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int cnt = 0, idx = 0;
                for (int p = 0; p < n; p++)
                {
                    if (b[p] < a[idx]) cnt++;
                    else idx++;
                }

                Console.WriteLine(cnt);
            }
        }
    }

}