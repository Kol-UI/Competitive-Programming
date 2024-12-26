/*
    Given two integers N and K, the task is to count the number of ways to divide N into groups of positive integers. Such that each group shall have K elements and their sum is N. Also the number of elements in the groups follows a non-decreasing order (i.e. group[i] <= group[i+1]). Find the number of such groups

    Example 1:

    Input:
    N = 8
    K = 4
    Output:
    5
    Explanation:
    There are 5 groups such that their sum is 8 
    and the number of positive integers in each 
    group is 4. The 5 groups are [1, 1, 1, 5], 
    [1, 1, 2, 4], [1, 1, 3, 3], [1, 2, 2, 3] and 
    [2, 2, 2, 2].
    
    Example 2:

    Input: 
    N = 4
    K = 3
    Output:
    1
    Explanation: 
    The only possible grouping is {1, 1, 2}. Hence,
    the answer is 1 in this case.
    Your Task:
    Complete the function countWaystoDivide() which takes the integers N and K as the input parameters, and returns the number of ways to divide the sum N into K groups.
*/

import java.util.Arrays;

// User function Template for Java

class Solution
{
    int mod = 1000000007; 
    int dp[][][];
    public int countWaystoDivide(int n, int k)
    {
        dp = new int[n+1][k+1][n+1];
        for(int x[][]:dp)
        {
           for(int y[] :x)
           Arrays.fill(y,-1);
        }
         return solve(n, k, n);
    }
    
    int solve(int n, int k, int last)
    {
    	if (k == 0)
    	{
    		return (n == 0)? 1:0;
    	}
    	if(dp[n][k][last] != -1)
    	{
    	    return dp[n][k][last];
    	}
    	
    	int answer = 0;
    
    	for (int s = 1; s <= Math.min(n, last); s++)
    	{
    		answer += solve(n - s, k - 1, s);
    		answer = answer % mod;
    	}
    
    	return dp[n][k][last] = answer;
    }
}