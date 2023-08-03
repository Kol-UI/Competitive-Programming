// Simple Array Sum


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.SimpleArraySum
{
    public class Result
    {

        /*
        * Complete the 'simpleArraySum' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts INTEGER_ARRAY ar as parameter.
        */

        public static int simpleArraySum(List<int> ar)
        {
            int i = 0;
            int result = 0;
            foreach(int number in ar)
            {
                result += ar.ElementAt(i);
                i++;
            }
            
            return result;
        }

    }

    /*
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
    */

    public class Test
    {
        public static bool[] TestSimpleArraySum()
        {
            List<int> ar = new List<int> {1, 2, 3, 4, 10, 11};
            int case1 = Result.simpleArraySum(ar);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(case1, 31)
            };
            return results;
        }
    }
}
