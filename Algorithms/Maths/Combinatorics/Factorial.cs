namespace CompetitiveProgramming.Algorithms
{
    public class Factorial
    {
        private static int CalculateFactorial(int n)
        {
            if (n < 0)
                return -1;

            return (n == 0) ? 1 : n * CalculateFactorial(n - 1);
        }
    }
}