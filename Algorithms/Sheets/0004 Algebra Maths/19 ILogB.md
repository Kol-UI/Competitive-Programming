Returns the base 2 integer logarithm of a specified number.
```cs
public static class ILogB
{
    public static int GetILogB(double x)
    {
        if (x <= 0) 
        {
            if (x == 0) return int.MinValue;
            return int.MinValue;
        }

        // kind of Floor for Log2
        return (int)Math.Floor(Math.Log2(x));
    }

    public static int BuiltInILogB(double x) => Math.ILogB(x);
}```