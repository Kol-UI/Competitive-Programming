using System.Text;

namespace CompetitiveProgramming.Algorithms;
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
}