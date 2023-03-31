using System;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.EvenSwap
{
	public class Solution
	{
        public static int[] LexicographicallyLargest(int[] arr, int n)
        {
            int i = 0;
            while(i < n)
            {
                int j;
                for( j = i + 1; j < n && arr[j] % 2 == arr[j-1] % 2; j++)
                {
                    
                }
                Help_sort_primitive(arr, i, j);
                i = j;
            }
            return arr;
        }
        private static void Help_sort_primitive(int[] arr, int i, int j)
        {
            Array.Sort(arr, i, j);
            while(i<j)
            {
                j--;
                int temp = arr[i]; arr[i] = arr[j];
                arr[j] = temp;
                i++; 
            }
        }
    }
}