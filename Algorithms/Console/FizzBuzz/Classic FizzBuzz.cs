namespace CompetitiveProgramming.Algorithms;
public class FizzBuzz
{
    public static List<string> GetFizzBuzz()
    {
        List<string> results = [];
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                results.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                results.Add("Buzz");
            }
            else
            {
                results.Add(i.ToString());
            }
        }
        return results;
    }
}