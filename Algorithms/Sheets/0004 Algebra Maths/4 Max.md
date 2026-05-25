Return biggest value between two values
```cs
public static class Max
{
    public static double GetMax(double val1, double val2)
    {
        // Returns the larger of two numbers.
        // If they are equal, returns val1.
        return (val1 >= val2) ? val1 : val2;
    }

    public static double BuiltInMax(double val1, double val2) => Math.Max(val1, val2);
}```