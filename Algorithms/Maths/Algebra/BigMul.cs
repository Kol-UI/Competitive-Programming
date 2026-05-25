namespace CompetitiveProgramming.Algorithms;
public static class BigMul
{
    public static long GetBigMul(int a, int b)
    {
        // Cast one operand to long to ensure the multiplication 
        // happens in 64-bit space, preventing 32-bit overflow.
        return (long)a * b;
    }

    public static long BuiltInBigMul(int a, int b) => Math.BigMul(a, b);
}