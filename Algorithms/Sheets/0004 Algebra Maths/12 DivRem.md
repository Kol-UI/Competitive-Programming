Perform a division by returning the Quotient and the Remainder at the same time.
```cs
public static class DivRem
{
    public static (int Quotient, int Remainder) GetDivRem(int a, int b)
    {
        int quotient = a / b;
        int remainder = a - (quotient * b);
        return (quotient, remainder);
    }

    public static (int Quotient, int Remainder) BuiltInDivRem(int a, int b)
    {
        // Version moderne qui retourne les deux valeurs d'un coup
        int remainder;
        int quotient = Math.DivRem(a, b, out remainder);
        return (quotient, remainder);
    }
}```