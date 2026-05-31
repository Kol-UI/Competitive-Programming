namespace CompetitiveProgramming.Algorithms;
public class FizzBuzzExtensibleBazz
{
    public static List<string> GetExtensibleFizzBuzzBazz(int limit = 100)
    {
        var rules = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" },
            { 7, "Bazz" },
            { 11, "Luzz" }
        };

        List<string> results = [];

        for (int i = 1; i <= limit; i++)
        {
            string current = "";

            foreach (var rule in rules)
            {
                if (i % rule.Key == 0) 
                    current += rule.Value;
            }

            results.Add(string.IsNullOrEmpty(current) ? i.ToString() : current);
        }
        
        return results;
    }
}