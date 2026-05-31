Problem Statement: Given a non-empty array of integers arr, every element appears twice except for one. Find that single one.


Examples : 


Example 1:

Input Format: arr[] = {2,2,1}

Result: 1

Explanation: In this array, only the element 1 appear once and so it is the answer.


Example 2:

Input Format: arr[] = {4,1,2,1,2}

Result: 4

Explanation: In this array, only element 4 appear once and the other elements appear twice. So, 4 is the answer.


Approch Hashing :
```cs
public class FindTheNumberThatAppearsOnceAndTheOtherNumbersTwice
{
    public int FindSingleNumberUsingDictionary(int[] arr)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts.Add(num, 1);
            }
        }

        foreach (var entry in counts)
        {
            if (entry.Value == 1)
            {
                return entry.Key;
            }
        }

        return -1;
    }
}
```