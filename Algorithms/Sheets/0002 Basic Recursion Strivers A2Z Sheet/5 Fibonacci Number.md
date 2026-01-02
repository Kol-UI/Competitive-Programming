
Problem Statement: Given an integer N. Print the Fibonacci series up to the Nth term.


Fibonacci :

Starts at 0,1 then we add last 2 until total of values = N


Example 1:

Input: N = 5

Output: 0 1 1 2 3 5

Explanation: 0 1 1 2 3 5 is the fibonacci series up to 5th term.(0 based indexing)



Example 2:

Input: 6

Output: 0 1 1 2 3 5 8

Explanation: 0 1 1 2 3 5 8 is the fibonacci series upto 6th term.(o based indexing)


```cs

// Brute Force Approch
public class FibonacciNumber_BruteForce
{
    public int GetFibonacci(int n)
    {
        if (n <= 1) return n;

        int previous = 0;
        int current = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = previous + current;
            previous = current;
            current = next;
        }

        return current;
    }
}

// List Approch (RAM!)
public class FibonacciNumber_List
{
    public int GetFibonacci(int n)
    {
        List<int> results = new List<int> { 0, 1 };
        for (int i = 2; i <= n; i++)
        {
            results.Add(results[i - 1] + results[i - 2]);
        }
        return results[n];
    }
}

// Math (Binet Formula) Approch
public class FibonacciNumber_Binet
{
    public int GetFibonacci(int n)
    {
        double phi = (1 + Math.Sqrt(5)) / 2;
        return (int)Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
    }
}

// Recursive Approch
public class FibonacciNumber_Recursive
{
    public int GetFibonacci(int n)
    {
        if (n <= 1) return n;
        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }
}

// Memoization Approch (+ Recursive)
public class FibonacciNumber_Memoization
{
    private Dictionary<int, long> cache = [];

    public long GetFibonacci(int n)
    {
        if (n <= 1) return n;
        
        if (cache.ContainsKey(n)) return cache[n];

        cache[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        return cache[n];
    }
}
```