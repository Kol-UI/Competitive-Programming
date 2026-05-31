Same as FizzBuzz but without using Modulo.
```cs
public class NoModuloFizzBuzz
{
    public static List<string> GetFizzBuzzNoModulo()
    {
        List<string> results = [];
        int count3 = 0;
        int count5 = 0;

        for (int i = 1; i <= 100; i++)
        {
            count3++;
            count5++;
            string current = "";
            if (count3 == 3)
            {
                current += "Fizz";
                count3 = 0;
            }
            if (count5 == 5)
            {
                current += "Buzz";
                count5 = 0;
            }
            results.Add(string.IsNullOrEmpty(current) ? i.ToString() : current);
        }
        return results;
    }
}```