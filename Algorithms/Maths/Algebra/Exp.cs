namespace CompetitiveProgramming.Algorithms;
public static class Exp
{
    public static double GetExp(double x)
    {
        // Summing the series: 1 + x + x^2/2! + x^3/3!...
        double result = 1.0;
        double term = 1.0;

        for (int i = 1; i <= 20; i++)
        {
            term *= x / i;
            result += term;
        }

        return result;
    }

    public static double BuiltInExp(double x) => Math.Exp(x);
}