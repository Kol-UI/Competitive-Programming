import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;

// Count Special Numbers

// User function Template for Java

class Solution
{
    public int countSpecialNumbers(int n, int arr[])
    {
        Map<Integer, Integer> freq = new HashMap<>();
        HashSet<Integer> uniq = new HashSet<Integer>();
        int max = 0;
        for (int i = 0; i < n; i++) 
        {
            freq.put(arr[i], freq.getOrDefault(arr[i], 0) + 1);
            uniq.add(arr[i]);
            max = Math.max(arr[i], max);
        }
        
        HashSet<Integer> special= new HashSet<Integer>();
        for(int z : uniq)
        {
            for (int i = 2 * z; i <= max; i += z)
            {
                if (uniq.contains(i))
                {
                    special.add(i);
                }
            }
        }
        
        int result = 0;
        for (Map.Entry<Integer, Integer> x : freq.entrySet()) 
        {
            if (x.getValue() > 1)
            {
                result += x.getValue();
            } 
            else if (special.contains(x.getKey()))
            {
                result++;
            }
        }
         
        return result; 
    }
}