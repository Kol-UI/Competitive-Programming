// Even Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.EvenArray
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < t; i++)
            {
                int n = ReadInt();
                int[] a = ReadInts();
                results.Add(MinMovesToMakeArrayGood(n, a));
            }

            PrintResults(results);
        }

        private static int MinMovesToMakeArrayGood(int n, int[] a)
        {
            int oddIndexEvenNum = 0;
            int evenIndexOddNum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if (a[i] % 2 != 0)
                    {
                        evenIndexOddNum++;
                    }
                }
                else
                {
                    if (a[i] % 2 == 0)
                    {
                        oddIndexEvenNum++;
                    }
                }
            }

            if (oddIndexEvenNum == evenIndexOddNum)
            {
                return oddIndexEvenNum;
            }
            else
            {
                return -1;
            }
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result!.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even Array");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}