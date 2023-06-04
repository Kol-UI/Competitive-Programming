// Sort Integers by The Number of 1 Bits

/*
You are given an integer array arr. Sort the integers in the array in ascending order by the number of 1's in their binary representation and in case of two or more integers have the same number of 1's you have to sort them in ascending order.

Return the array after sorting it.

 

Example 1:

Input: arr = [0,1,2,3,4,5,6,7,8]
Output: [0,1,2,4,8,3,5,6,7]
Explantion: [0] is the only integer with 0 bits.
[1,2,4,8] all have 1 bit.
[3,5,6] have 2 bits.
[7] has 3 bits.
The sorted array by bits is [0,1,2,4,8,3,5,6,7]

Example 2:

Input: arr = [1024,512,256,128,64,32,16,8,4,2,1]
Output: [1,2,4,8,16,32,64,128,256,512,1024]
Explantion: All integers have 1 bit in the binary representation, you should just sort them in ascending order.
*/


using System;
namespace CompetitiveProgramming.LeetCode.SortIntegersbyTheNumberof1Bits
{
    public class Solution
    {
        // Selection Sort
        public static int[] SortByBits(int[] arr)
        {
            while (true)
            {
                bool swap = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int sum1 = 0;
                    int sum2 = 0;
                    int n1 = arr[i];
                    int n2 = arr[i + 1];

                    while (n1 > 0)
                    {
                        if ((n1 & 1) == 1) sum1++;
                        n1 = n1 >> 1;
                    }

                    while (n2 > 0)
                    {
                        if ((n2 & 1) == 1) sum2++;
                        n2 = n2 >> 1;
                    }

                    if(sum1 == sum2 && arr[i + 1] < arr[i])
                    {   
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swap = true;        
                    }

                    if (sum1 > sum2)
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swap = true;
                    }
                }
                if (swap == false) break;
            }

            return arr;
        }
    }
}
