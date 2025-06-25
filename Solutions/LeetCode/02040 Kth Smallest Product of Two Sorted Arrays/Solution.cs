// Kth Smallest Product of Two Sorted Arrays
namespace CompetitiveProgramming.LeetCode.KthSmallestProductofTwoSortedArrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    private void Parition(int[] nums1, int[] nums2, out int posLen1, out int negLen1, out int posLen2, out int negLen2, 
        out int[] pos1, out int[] neg1, out int[] pos2, out int[] neg2, out bool isResultPositive, ref long k)
    {
        posLen1 = 0; negLen1 = 0; posLen2 = 0; negLen2 = 0;

        foreach (int num in nums1)
        {
            if (num < 0) negLen1++;
            else posLen1++;
        }

        foreach (int num in nums2)
        {
            if (num < 0) negLen2++;
            else posLen2++;
        }

        int numNegatives = posLen1 * negLen2 + posLen2 * negLen1;
        isResultPositive = k > numNegatives;

        pos1 = new int[posLen1]; neg1 = new int[negLen1];
        pos2 = new int[posLen2]; neg2 = new int[negLen2];

        int iPos = 0, iNeg = 0;
        foreach (int num in nums1)
        {
            if (num < 0)
                neg1[iNeg++] = num;
            else 
                pos1[iPos++] = num;
        }

        iPos = 0; iNeg = 0;
        foreach (int num in nums2)
        {
            if (num < 0)
                neg2[iNeg++] = num;
            else 
                pos2[iPos++] = num;
        }
        
        if (isResultPositive)
        {
            k -= numNegatives;
            Array.Reverse(neg1);
            Array.Reverse(neg2);
        }
        else
        {
            Array.Reverse(pos1);
            Array.Reverse(pos2);
        }
    }

    private long GetValidNumberCount(int[] arr1, int[] arr2, long val)
    {
        int i = 0, j = arr2.Length-1;
        long count = 0L;

        while (i < arr1.Length && j >= 0)
        {
            if (((long)arr1[i] * (long)arr2[j]) <= val)
            {
                count += (long)(j+1);
                i++;
            }
            else
            {
                j--;
            }
        }

        return count;
    }

    public long KthSmallestProduct(int[] nums1, int[] nums2, long k) 
    {
        Parition(nums1, nums2, out int posLen1, out int negLen1, out int posLen2, out int negLen2, out int[] pos1, 
                    out int[] neg1, out int[] pos2, out int[] neg2, out bool isResultPositive, ref k);
        
        long low = -(long)Math.Pow(10, 10) - 1;
        long high =  (long)Math.Pow(10, 10) + 1;

        while (low < high)
        {
            long mid = low + (high - low)/2;
            long count = isResultPositive ? GetValidNumberCount(pos1, pos2, mid) + GetValidNumberCount(neg1, neg2, mid)
                : GetValidNumberCount(pos1, neg2, mid) + GetValidNumberCount(pos2, neg1, mid);
            
            if (count >= k)
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return high;
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Kth Smallest Product of Two Sorted Arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
	}
}