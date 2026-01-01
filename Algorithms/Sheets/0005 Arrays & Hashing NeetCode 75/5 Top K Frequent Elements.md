Given an integer array nums and an integer k, return the k most frequent elements within the array.

The test cases are generated such that the answer is always unique.

You may return the output in any order.


Example 1:

Input: nums = [1,2,2,3,3,3], k = 2

Output: [2,3]


Example 2:

Input: nums = [7,7], k = 1

Output: [7]



```cs
public class TopKFrequentElements
{
    public int[] TopKFrequentCounting(int[] nums, int k)
    {
        Dictionary<int, int> counts = new();
        foreach (int value in nums)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 1;
            }
        }

        // Start - Check with Linq (same)
        List<KeyValuePair<int, int>> listOfPairs = new List<KeyValuePair<int, int>>();
        foreach (KeyValuePair<int, int> pair in counts)
        {
            listOfPairs.Add(pair);
        }
        listOfPairs.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        int[] result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = listOfPairs[i].Key;
        }
        // End

        Array.Sort(result);
        return result;
    }

    public int[] TopKFrequentCountingLinq(int[] nums, int k)
    {
        Dictionary<int, int> counts = new();
        foreach (int value in nums)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 1;
            }
        }

        int[] result = counts.OrderByDescending(pair => pair.Value)
                             .Select(pair => pair.Key)
                             .Take(k)
                             .ToArray();

        Array.Sort(result);
        return result;
    }

    public int[] TopKFrequentCountingCorrection(int[] nums, int k)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }

        List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList();
        arr.Sort((a, b) => b[0].CompareTo(a[0]));

        int[] res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = arr[i][1];
        }
        Array.Sort(res);
        return res;
    }

    public int[] TopKFrequentQueue(int[] nums, int k)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int value in nums)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 1;
            }
        }

        /*
            Use a Min-Heap (Priority Queue) to keep track of the top K elements
            The PriorityQueue stores KeyValuePair<number, frequency>
            and prioritizes based on frequency.
            We want a MIN-heap based on frequency, so elements with LOWER frequency are removed first.
            The comparer (a, b) => a.Value.CompareTo(b.Value) ensures this:
            if a.Value is smaller than b.Value, 'a' has higher priority (comes first in min-heap).
            
            PriorityQueue<TElement, TPriority>
            TElement: KeyValuePair<int, int> (the number and its frequency)
            TPriority: int (the frequency, which we'll use for priority)
            Custom comparer: (a, b) => a.Value.CompareTo(b.Value) means lower frequency values
            (a.Value) have higher priority.
        */
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (KeyValuePair<int, int> entry in counts)
        {
            int number = entry.Key;
            int frequency = entry.Value;
            minHeap.Enqueue(number, frequency);
            if (minHeap.Count > k) // Dequeue because max size reached (k)
            {
                minHeap.Dequeue();
            }
        }

        int[] result = new int[k];
        int index = 0;
        while (minHeap.Count > 0)
        {
            result[index++] = minHeap.Dequeue();
        }

        Array.Sort(result);
        return result;
    }

    public int[] TopKFrequentBucketSort(int[] nums, int k)
    {
        Dictionary<int, int> counts = new();
        foreach (int value in nums)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 1;
            }
        }

        // Create buckets
        int len = nums.Length;
        List<List<int>> buckets = new(len + 1);
        for (int i = 0; i <= len; i++)
        {
            buckets.Add(new List<int>());
        }

        // Fill buckets
        foreach (var entry in counts)
        {
            int number = entry.Key;
            int frequency = entry.Value;
            buckets[frequency].Add(number);
        }

        // Collect buckets
        List<int> result = new();
        for (int i = buckets.Count - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i].Count > 0)
            {
                foreach (int number in buckets[i])
                {
                    result.Add(number);
                    if (result.Count == k)
                    {
                        break;
                    }
                }
            }
        }

        result.Sort();
        return result.ToArray();
    }
}
```