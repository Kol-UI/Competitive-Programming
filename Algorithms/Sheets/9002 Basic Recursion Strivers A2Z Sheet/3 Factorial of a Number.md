
Problem Statement: Given a number X,  print its factorial.

To obtain the factorial of a number, it has to be multiplied by all the whole numbers preceding it.

More precisely X! = X*(X-1)*(X-2) … 1.

Note: X is always a positive number.


```cs

// Iterative Approch - (int) 0! to 13!
public class FactorialofaNumber_Iterative
{
    public int GetFactorialofaNumber(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        
        return result;
    }
}

// Recursive Approch - (int) 0! to 13!
public class FactorialofaNumber_Recursive
{
    public int GetFactorialofaNumber(int n)
    {
        if(n == 0) return 1;
        return n * GetFactorialofaNumber(n - 1);
    }
}

// Iterative Approch - (long) 0! to 20!
public class FactorialofaNumber_Long_Iterative
{
    public long GetFactorialofaNumber(int n)
    {
        long result = 1;

        if (n < 0) return 0; 
        if (n > 20) 
        {
            throw new System.OverflowException("Overflow !");
        }

        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        
        return result;
    }
}

// Recursive Approch - (long) 0! to 20!
public class FactorialofaNumber_Recursive_Long
{    public long GetFactorialofaNumber(int n)
    {
        if (n < 0) return 0;
        if (n == 0) return 1;
        if (n > 20) 
        {
            throw new System.OverflowException("Overflow !");
        }

        return (long)n * GetFactorialofaNumber(n - 1);
    }
}

// Iterative Approch - (BigInteger) +21!
public class FactorialofaNumber_BigInteger_Iterative
{
    public BigInteger GetFactorialofaNumber(int n)
    {
        if (n < 0) return 0;
        BigInteger result = 1;

        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        
        return result;
    }
}

// Recursive Approch - (BigInteger) +21!
public class FactorialofaNumber_BigInteger_Recursive
{
    public BigInteger GetFactorialofaNumber(int n)
    {
        if (n < 0) return 0;
        if (n == 0) return 1;
        return (BigInteger)n * GetFactorialofaNumber(n - 1);
    }
}
```