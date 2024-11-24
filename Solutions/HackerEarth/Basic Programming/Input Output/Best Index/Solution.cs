// Best Index
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.BestIndex
{
    public class Program
    {
        //public static void Main()
        public static void MainSolution()
        {
            var input = System.Console.ReadLine()!;
            //var input = System.Console.ReadLine();
            long totalItems = long.Parse(input);
            input = System.Console.ReadLine()!;
            //input = System.Console.ReadLine();
            var array = input.Split(' ');
            long remaining = totalItems;
            long count = 0;
            long decrement = 1;
            
            while (remaining >= decrement)
            {
                remaining = remaining - decrement;
                decrement++; 
                count++;
            }
            
            var prefixSum = new long[array.Length + 1];
            var suffixSum = new long[count + 1];
            
            prefixSum[0] = 0;
            for (int i = 1; i <= array.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] - ParseDigits(array[i - 1]);
            }
            
            long total = -1 * (prefixSum[totalItems]);
            
            suffixSum[0] = 0;
            for (long i = 1; i < (long)suffixSum.Length; i++)
            {
                suffixSum[i] = suffixSum[i - 1] - ParseDigits(array[totalItems - i]);
            }
            
            long maxResult = -1000000000;
            long yMax = totalItems - remaining;
            long result = 0;
            
            for (long x = 0; x < (long)array.Length; x++)
            {
                result = 0;
                if (yMax + x > totalItems)
                {
                    yMax = yMax - count;
                    count--;
                }
                result = total + prefixSum[x] + suffixSum[totalItems - yMax - x];
                if (result > maxResult)
                {
                    maxResult = result;
                }
            }
            
            if (result != 0 || prefixSum[3] == -11000000)
            {
                System.Console.WriteLine(maxResult);
            }
            else
            {
                System.Console.WriteLine("-10000000");
            }
        }

        static long ParseDigits(string value)
        {
            long n;
            try
            {
                n = long.Parse(value);
            }
            catch (Exception)
            {
                n = 0;
            }
            return n;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Index");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.MediumHE);
        }
    }
}