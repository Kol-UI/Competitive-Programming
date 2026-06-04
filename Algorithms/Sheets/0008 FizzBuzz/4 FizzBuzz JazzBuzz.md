As Classic FizzBuzz but instead of a fixed logic for 3 and 5, the system must handle an arbitrary number of rules that can overlap.
The Rules If a number is divisible by 3, append "Fizz".
If a number is divisible by 5, append "Buzz". If a number is divisible by 7, append "Jazz" (or Bazz).
The Multiplier Rule: If a number is divisible by multiple factors (e.g., 105 is divisible by 3, 5, and 7), the words must be concatenated in order: "FizzBuzzJazz".
The Default Rule: If no rules match, return the number itself as a string.
```cs
public class FizzBuzzJazz
{
    private static readonly (int Divisor, string Word)[] Rules = 
    {
        (3, "Fizz"),
        (5, "Buzz"),
        (7, "Jazz")
    };

    public static List<string> GetFizzBuzzJazzBuzz(int limit)
    {
        List<string> results = new(limit);
        StringBuilder sb = new();

        for (int i = 1; i <= limit; i++)
        {
            sb.Clear(); // reset at each number

            foreach (var rule in Rules)
            {
                if (i % rule.Divisor == 0)
                {
                    sb.Append(rule.Word);
                }
            }

            // if StringBuilder is empty we add number, otherwise the word
            results.Add(sb.Length == 0 ? i.ToString() : sb.ToString());
        }

        return results;
    }
}```