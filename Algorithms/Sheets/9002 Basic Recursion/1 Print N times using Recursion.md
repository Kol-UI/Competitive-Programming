Input: N = 3

Output: Test Test Test


Input: N = 1

Output: Test



```cs
public class PrintNtimesusingRecursion()
{
    public string GetNTimesRecursive(int n)
    {
        if (n <= 0) return "";
        string value = "Test ";
        return value + GetNTimesRecursive(n - 1);
    }
}
```