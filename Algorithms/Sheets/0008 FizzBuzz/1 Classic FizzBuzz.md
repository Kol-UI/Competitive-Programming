Given an integer n, return _a string array_ answer _(**1-indexed**) where_: 
- answer[i] == "FizzBuzz" if i is divisible by 3 and 5. 
- answer[i] == "Fizz" if i is divisible by 3. 
- answer[i] == "Buzz" if i is divisible by 5. 
- answer[i] == i (as a string) if none of the above conditions are true.
```cs
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
}```