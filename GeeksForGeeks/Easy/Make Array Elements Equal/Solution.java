

// User function Template for Java

class Solution
{
    public long minOperations(int N)
    {
        long result = 0;
        result = N/2;
        result *= (N + 1) /2;
        return result;
    }
}