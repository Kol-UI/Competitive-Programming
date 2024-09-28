// Good Kid

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Goodkid
{
    public class ProblemSolution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                int[] digits = ReadInts();
                
                int maxProduct = CalculateMaxProduct(digits);
                results.Add(maxProduct);
            }

            PrintResults(results);
        }

        public static int CalculateMaxProduct(int[] digits)
        {
            int maxProduct = ProductOfArray(digits);

            for (int i = 0; i < digits.Length; i++)
            {
                int[] modifiedDigits = (int[])digits.Clone();
                modifiedDigits[i] = digits[i] + 1;
                int modifiedProduct = ProductOfArray(modifiedDigits);
                if (modifiedProduct > maxProduct)
                {
                    maxProduct = modifiedProduct;
                }
            }

            return maxProduct;
        }

        public static int ProductOfArray(int[] arr)
        {
            int product = 1;
            foreach (int num in arr)
            {
                product *= num;
            }
            return product;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split().Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Good Kid");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}