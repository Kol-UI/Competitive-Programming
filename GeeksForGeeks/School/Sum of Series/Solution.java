/*
    Write a program to find the sum of the given series 1+2+3+ . . . . . .(N terms) 

    Example 1:

    Input:
    N = 1
    Output: 1
    Explanation: For n = 1, sum will be 1.
    Example 2:

    Input:
    N = 5
    Output: 15
    Explanation: For n = 5, sum will be 1 + 2 + 3 + 4 + 5 = 15.
    Y
    our Task:
    Complete the function seriesSum() which takes single integer n,
    as input parameters and returns an integer denoting the answer.
    You don't need to print the answer or take inputs.
*/

class Solution
{
    // function to return sum of  1, 2, ... n
    long seriesSum(int n)
    {
        long n2 = n;
        return n2*(n2+1)/2;
    }
}