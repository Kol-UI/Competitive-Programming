// Remove Smallest


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.RemoveSmallest
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void Problem()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);
                string[] input = Console.ReadLine()!.Split(' ');

                int[] arr = new int[n];
                for (int j = 0; j < n; j++)
                    arr[j] = int.Parse(input[j]);

                Array.Sort(arr);

                bool canRemove = true;

                for (int j = 1; j < n; j++)
                {
                    if (arr[j] - arr[j - 1] > 1)
                    {
                        canRemove = false;
                        break;
                    }
                }

                if (canRemove)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}