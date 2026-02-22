namespace CompetitiveProgramming.Algorithms.Maths;

public class SieveOfEratoasthenes
{
    // Get all prime numbers until n
    // Index represent the number
    // true = is prime
    public bool[] Sieve(int n)
    {
        bool[] isPrime = new bool[n + 1];
        Array.Fill(isPrime, true);

        if (n >= 0) isPrime[0] = false;
        if (n >= 1) isPrime[1] = false;

        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }
        return isPrime;
    }

    // Count primes until n
    public int CountPrimes(int n)
    {
        if (n <= 2) return 0;
        
        bool[] isPrime = new bool[n];
        Array.Fill(isPrime, true);
        int count = 0;

        for (int p = 2; p * p < n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i < n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        for (int i = 2; i < n; i++)
        {
            if (isPrime[i]) count++;
        }

        return count;
    }

}