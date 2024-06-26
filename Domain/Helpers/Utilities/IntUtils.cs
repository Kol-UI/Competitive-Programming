namespace CompetitiveProgramming.Helpers
{
    public class IntUtils
    {
        // 5 => 1 + 2 + 3 + 4 + 5 = 15
        public static int SumOfFirstNIntegers(int n)
        {
            return n * (n + 1) / 2;
        }

        // Check if prime
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // Find next prime
        public static int NextPrime(int n)
        {
            int next = n + 1;
            while (!IsPrime(next))
            {
                next++;
            }
            return next;
        }
    }
}