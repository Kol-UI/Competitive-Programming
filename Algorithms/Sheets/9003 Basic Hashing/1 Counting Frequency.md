Counting Frequency

Given an array, we have to found the number of occurrences of each element in the array.

```cs
public class CountingFrequency()
{
    public Dictionary<int, int> GetFrequency(int[] nums)
    {
        Dictionary<int, int> frequencies = new();

        foreach (int number in nums)
        {
            if (frequencies.ContainsKey(number))
            {
                frequencies[number]++;
            }
            else
            {
                frequencies[number] = 1;
            }
        }

        //foreach (var pair in frequencies) Console.WriteLine($"Element {pair.Key} : {pair.Value} times");
        return frequencies;
    }

    public int GetSpecificFrequency(int[] nums, int targetNumber)
    {
        Dictionary<int, int> frequencies = GetFrequency(nums);
        if (frequencies.ContainsKey(targetNumber))
        {
            return frequencies[targetNumber];
        }
        else return 0;
    }
}
```