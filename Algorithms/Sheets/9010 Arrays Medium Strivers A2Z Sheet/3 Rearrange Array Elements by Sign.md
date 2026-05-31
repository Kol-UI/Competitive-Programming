Problem Statement:


There’s an array ‘A’ of size ‘N’ with an equal number of positive and negative elements.

Without altering the relative order of positive and negative elements, you must return an array of alternately positive and negative values.

Note: Start the array with positive elements.


Examples: 


Example 1:

Input:

arr[] = {1,2,-4,-5}, N = 4

Output:

1 -4 2 -5

Explanation: 

Positive elements = 1,2


Negative elements = -4,-5

To maintain relative ordering, 1 must occur before 2, and -4 must occur before -5.


Example 2:

Input:

arr[] = {1,2,-3,-1,-2,-3}, N = 6

Output:

1 -3 2 -1 -2 -3

Explanation: 

Positive elements = 1,2,3

Negative elements = -3,-1,-2,-3


```cs
public class RearrangeArrayElementsbySign
{
    public int[] RearrangebySign(int[] A, int n)
    {
        int[] result = new int[n];
        List<int> negatives = new();
        List<int> positives = new();

        foreach (int value in A)
        {
            if (value > 0)
            {
                positives.Add(value);
            }
            else
            {
                negatives.Add(value);
            }
        }

        int posIdx = 0; 
        int negIdx = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) // even : positive
            {
                if (posIdx < positives.Count)
                {
                    result[i] = positives[posIdx];
                    posIdx++;
                }
                else if (negIdx < negatives.Count) 
                {
                    result[i] = negatives[negIdx];
                    negIdx++;
                }
            }
            else
            {
                if (negIdx < negatives.Count)
                {
                    result[i] = negatives[negIdx];
                    negIdx++;
                }
                else if (posIdx < positives.Count)
                {
                    result[i] = positives[posIdx];
                    posIdx++;
                }
            }
        }

        return result;
    }
}
```