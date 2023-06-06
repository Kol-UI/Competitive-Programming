// A Very Big Sum

/*
n this challenge, you are required to calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

Function Description

Complete the aVeryBigSum function in the editor below. It must return the sum of all array elements.

aVeryBigSum has the following parameter(s):

int ar[n]: an array of integers .
Return

long: the sum of all array elements
Input Format

The first line of the input consists of an integer .
The next line contains n space-separated integers contained in the array.

Output Format

Return the integer sum of the elements in the array.

Sample Input

5
1000000001 1000000002 1000000003 1000000004 1000000005
Output

5000000015
*/

using System;
namespace CompetitiveProgramming.HackerRank.AVeryBigSum
{
    public class Result
    {

        /*
        * Complete the 'aVeryBigSum' function below.
        *
        * The function is expected to return a LONG_INTEGER.
        * The function accepts LONG_INTEGER_ARRAY ar as parameter.
        */

        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (long num in ar)
            {
                sum += num;
            }
            return sum;
        }

    }
    
    /*  
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
    */
}