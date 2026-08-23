
Problem Statement: Given two integers N1 and N2, find their greatest common divisor.

The Greatest Common Divisor of any two integers is the largest number that divides both integers.



Example 1:

Input:N1 = 9, N2 = 12

Output:3

Explanation:Factors of 9: 1, 3 and 9

Factors of 12: 1, 2, 3, 4, 6, 12

Common Factors: 1, 3 out of which 3 is the greatest hence it is the GCD.



				
Example 2:

Input:N1 = 20, N2 = 15

Output: 5

Explanation:Factors of 20: 1, 2, 4, 5

Factors of 15: 1, 3, 5

Common Factors: 1, 5 out of which 5 is the greatest hence it is the GCD.



```cs

// Brute Force Approch
public class FindGCDoftwonumbers_BruteForce()
{
    public int GetGCD(int a, int b)
    {
        // For 0 and negatives
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0 && b == 0) return 0;
        if (a == 0) return b;
        else if (b == 0) return a;

        int gcd = 1;
        int min = Math.Min(a, b);
        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                gcd = i;
            }
        }
        return gcd;
    }
}

// Brute Force Optimized Approch (starts from highest to lower)
public class FindGCDoftwonumbers_BetterBruteForce()
{
    public int GetGCD(int n1, int n2) 
    {
        int a = Math.Abs(n1);
        int b = Math.Abs(n2);
        
        if (a == 0 && b == 0) return 0;
        else if (a == 0) return b;
        else if (b == 0) return a;
        
        int min = Math.Min(a, b);
        
        for(int i = min; i > 0; i--) 
        {
            if(a % i == 0 && b % i == 0) 
            {
                return i;
            }
        }
        
        return 1;
    }
}

// Euclidean Algorithm
public class FindGCDoftwonumbers_EuclideanAlgorithm()
{
    public int GetGCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0 && b == 0) return 0;

        while(a > 0 && b > 0) 
        {
            if(a > b) 
            {
                a %= b; // Update a to the remainder of a divided by b
            }
            else 
            {
                b %= a; // Update b to the remainder of b divided by a
            }
        }
        if(a == 0) return b;
        return a;
    }
}
```