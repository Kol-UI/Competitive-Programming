import java.util.Map;
import java.util.TreeMap;

// Maximum Intersecting Lines
// User function Template for Java

class Solution
{
    public int maxIntersections(int[][] lines, int N)
    {
        TreeMap<Integer, Integer> mp = new TreeMap<>();
        int result = 0;
        int tempo = 0;
        
        for(int[] x : lines)
        {
            int start = x[0];
            int end = x[1] + 1;
            mp.put(start, mp.getOrDefault(start, 0) + 1);
            mp.put(end, mp.getOrDefault(end, 0) - 1);
            
        }
        
        for(Map.Entry<Integer, Integer> entry : mp.entrySet())
        {
            tempo += entry.getValue();
            result = Math.max(result, tempo);
        }
        
        return result;
    }
}