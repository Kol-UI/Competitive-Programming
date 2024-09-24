namespace CompetitiveProgramming.Algorithms
{
    public class FibonacciSequence
    {
        private static int CalculateFibonacciSequence(int n)
        {
            if (n < 0)
                throw new ArgumentException("Can't be negative");

            if (n == 0) return 0;
            if (n == 1) return 1;

            return CalculateFibonacciSequence(n - 1) + CalculateFibonacciSequence(n - 2);
        }

        private static double CalculateFibonacciUsingBinet(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (1 + sqrt5) / 2;
            double psi = (1 - sqrt5) / 2;

            return (Math.Pow(phi, n) - Math.Pow(psi, n)) / sqrt5;
        }
    }
}