```cs
public class Combinatorics
{
    private static long _mod = 1000000007;
    private static long[]? _fact;
    private static long[]? _invFact;

    #region Public Methods
    // At the start of Main if many modular queries
    public static void PreCompute(int maxN, long mod = 1000000007)
    {
        _mod = mod;
        _fact = new long[maxN + 1];
        _invFact = new long[maxN + 1];

        _fact[0] = 1;
        for (int i = 1; i <= maxN; i++)
            _fact[i] = _fact[i - 1] * i % _mod;

        // Extended GCD
        _invFact[maxN] = GetInverse(_fact[maxN], _mod);

        if (_invFact[maxN] == 0 && _fact[maxN] != 0 && _mod > 1)
        {
            _invFact = null;
            return;
        }

        for (int i = maxN - 1; i >= 0; i--)
            _invFact[i] = _invFact[i + 1] * (i + 1) % _mod;
    }

    // Combinations (nCr) (group without order)
    public static BigInteger GetCombination(int n, int k, bool isModular = false)
    {
        if (k < 0 || k > n) return 0;
        if (k == 0 || k == n) return 1;

        if (isModular)
        {
            if (_fact != null && _invFact != null && n < _fact.Length)
            {
                long num = _fact[n];
                long den = (long)((BigInteger)_invFact[k] * _invFact[n - k] % _mod);
                return (long)((BigInteger)num * den % _mod);
            }
            return GetModularInternal(n, k);
        }

        return GetBigInternal(n, k);
    }

    // Permutations (nPk) (group with order)
    public static BigInteger GetPermutation(int n, int k, bool isModular = false)
    {
        if (k < 0 || k > n) return 0;
        if (isModular)
        {
            if (_fact != null && _invFact != null && n < _fact.Length)
                return (long)((BigInteger)_fact[n] * _invFact[n - k] % _mod);
            
            long res = 1;
            for (int i = 0; i < k; i++) res = res * (n - i) % _mod;
            return res;
        }
        
        BigInteger result = 1;
        for (int i = 0; i < k; i++) result *= n - i;
        return result;
    }
    #endregion
    
    #region Private Methods
    private static BigInteger GetBigInternal(int n, int k)
    {
        if (k > n / 2) k = n - k;
        BigInteger result = 1;
        for (int i = 1; i <= k; i++)
            result = result * (n - i + 1) / i;
        return result;
    }

    private static long GetModularInternal(int n, int k)
    {
        BigInteger exact = GetBigInternal(n, k);
        return (long)(exact % _mod);
    }

    private static long GetInverse(long a, long m)
    {
        if (m == 0) return 0;
        long m0 = m;
        long y = 0, x = 1;
        if (m == 1) return 0;

        while (a > 1)
        {
            if (m == 0) return 0;
            long q = a / m;
            long t = m;

            m = a % m;
            a = t;
            t = y;

            y = x - q * y;
            x = t;
        }
        if (x < 0) x += m0;
        return x;
    }
    #endregion
}

public class TheNumberOfPairs
{
    public static void GetResult(List<int> ints)
    {
        int k = 2;
        int ones = 0;
        int twos = 0;
        foreach (int value in ints)
        {
            if (value == 1) ones++;
            else if (value == 2) twos++;
        }
        Console.WriteLine(Combinatorics.GetCombination(ones, k) + Combinatorics.GetCombination(twos, k));
    }
}

public class SelectionOfPersonel
{
    public static void GetResult(int n)
    {
        long group5 = (long)Convert.ToDouble(Combinatorics.GetCombination(n, 5));
        long group6 = (long)Convert.ToDouble(Combinatorics.GetCombination(n, 6));
        long group7 = (long)Convert.ToDouble(Combinatorics.GetCombination(n, 7));
        long result = group5 + group6 + group7;
        Console.WriteLine(result);
    }
}

/*
public class Combinatoires_Tests
{
    [Fact]
    public void Test_Pairs()
    {
        // Choisir 2 parmi 3 (Pomme, Banane, Orange) -> 3 duos
        Assert.Equal(3, Combinatoires.GetCombination(3, 2));

        // Choisir 2 parmi 10 (La formule N*(N-1)/2) -> 45
        Assert.Equal(45, Combinatoires.GetCombination(10, 2));
    }

    [Fact]
    public void Test_Trios()
    {
        // Choisir 3 parmi 10 -> 120
        Assert.Equal(120, Combinatoires.GetCombination(10, 3));
    }

    [Fact]
    public void Test_EdgeCases()
    {
        // Choisir 0 parmi 10 -> Toujours 1 seule façon (ne rien prendre)
        Assert.Equal(1, Combinatoires.GetCombination(10, 0));

        // Choisir 10 parmi 10 -> 1 seule façon (prendre tout le monde)
        Assert.Equal(1, Combinatoires.GetCombination(10, 10));

        // Choisir 5 parmi 3 -> Impossible, doit retourner 0
        Assert.Equal(0, Combinatoires.GetCombination(3, 5));
    }

    [Fact]
    public void Test_LargeSymmetry()
    {
        // L'astuce du k = n - k : 
        // Choisir 98 parmi 100 est identique à choisir 2 parmi 100
        BigInteger result98 = Combinatoires.GetCombination(100, 98);
        BigInteger result2 = Combinatoires.GetCombination(100, 2);

        Assert.Equal(4950, result98);
        Assert.Equal(result98, result2);
    }

    [Fact]
    public void Test_ModuloClassicMath()
    {
        BigInteger res2 = Combinatoires.GetCombination(100, 50);
        BigInteger expected = BigInteger.Parse("100891344545564193334812497256");
        Assert.Equal(expected, res2);
    }

    [Fact]
    public void Test_PreCompute()
    {
        // RESET state to standard modulo
        Combinatoires.PreCompute(1000, 1000000007);
        BigInteger res1 = Combinatoires.GetCombination(1000, 500, true);
        Assert.Equal((BigInteger)159835829, res1);
    }

    [Fact]
    public void Test_NonPrimeModulo()
    {
        Combinatoires.PreCompute(0, 10);
        BigInteger result = Combinatoires.GetCombination(7, 2, true);
        Assert.Equal((BigInteger)1, result);
    }

    [Fact]
    public void Test_ExtendedGcd_Inverse()
    {
        Combinatoires.PreCompute(10, 11);
        BigInteger res = Combinatoires.GetCombination(3, 1, true);
        Assert.Equal((BigInteger)3, res);
    }
}
*/
```