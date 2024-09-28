// Brain's Photos

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BrainsPhotos
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int[] dimensions = ReadInts();
            int rows = dimensions[0];
            int columns = dimensions[1];

            char[][] photo = ReadPhoto(rows, columns);

            if (IsColored(photo))
            {
                Console.WriteLine("#Color");
            }
            else
            {
                Console.WriteLine("#Black&White");
            }
        }

        private static char[][] ReadPhoto(int rows, int columns)
        {
            char[][] photo = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                photo[i] = Console.ReadLine()!.Replace(" ", "").ToCharArray();
            }
            return photo;
        }

        private static bool IsColored(char[][] photo)
        {
            foreach (var row in photo)
            {
                if (row.Any(pixel => pixel == 'C' || pixel == 'M' || pixel == 'Y'))
                {
                    return true;
                }
            }
            return false;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Brain's Photos");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}