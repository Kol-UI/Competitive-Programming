// Push zeroes to end

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodingBlocks.Pushzeroestoend
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] input = Console.ReadLine()!.Split();

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            PushZeroesToEnd(arr, n);

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void PushZeroesToEnd(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];
                }
            }

            while (count < n)
            {
                arr[count++] = 0;
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Push zeroes to end");
            ResultTester.SpecialTestCase(ProblemOrigin.CodingBlocks, ProblemCategory.EasyCBl);
        }
    }
}