import java.util.Arrays;

// Dominant Pairs
class Solution
{
    public static int dominantPairs(int n, int[] arr)
    {
        Arrays.sort(arr, 0, n/2);
        Arrays.sort(arr, n/2, n);
        
        int result = 0;
        int j = n /2;
        
        for(int i = 0; i < n/2; i++)
        {
            while(j < n && arr[i] >= 5 * arr[j])
            {
                j++;
            } 
            result += j - n/2;
        }

        return result;
    }
}
        