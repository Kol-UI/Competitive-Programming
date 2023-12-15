// Diagonal Difference

// Given a square matrix, calculate the absolute difference between the sums of its diagonals.

using System;
namespace CompetitiveProgramming.HackerRank.DiagonalDifference
{
    public class Solution
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count;
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i][i];
                secondaryDiagonalSum += arr[i][n - 1 - i];
            }

            int absoluteDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            return absoluteDifference;
        }

        /*
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        */
    }
}