Returns the angle whose tangent is the quotient of two specified numbers.
```cs
public static class Atan2
{
    public static double GetAtan2(double y, double x)
    {
        // Returns the angle in radians between the x-axis and the point (x, y).
        // Handles quadrants and division by zero automatically. Range: (-PI, PI].
        return Math.Atan2(y, x);
    }
}```