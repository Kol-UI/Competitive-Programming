using System;
namespace CompetitiveProgramming.GeeksForGeeks.School.SumofSeries
{
	public class Solution
	{
        public static long SeriesSum(int n)
        {
            long n2 = n;
            return n2*(n2+1)/2;
        }
    }
}