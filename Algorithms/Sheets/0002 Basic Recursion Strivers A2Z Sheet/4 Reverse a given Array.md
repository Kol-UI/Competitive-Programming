
Problem Statement: You are given an array. The task is to reverse the array and print it.


Examples : 

Input: N = 5, arr[] = {5,4,3,2,1}

Output: {1,2,3,4,5}

Explanation: Since the order of elements gets reversed the first element will occupy the fifth position, the second element occupies the fourth position and so on.


Input: N = 4 arr[] = {10,20,30,40}

Output: {40,30,20,10}

Explanation: Since the order of elements gets reversed the first element will occupy the fifth position, the second element occupies the fourth position and so on.


```cs
// Brute Force Approch
public class ReverseagivenArray_BruteForce
{
    public int[] ReverseArray(int n, int[] values)
    {
        int[] reversedValues = new int[n];

        for (int i = 0; i < n; i++)
        {
            // Place the element from end into beginning
            reversedValues[i] = values[n - 1 - i];
        }

        return reversedValues;
    }
}

// Better Approch
public class ReverseagivenArray_BetterApproch
{
    public int[] ReverseArray(int n, int[] arr)
    {
        int p1 = 0;
        int p2 = n - 1;

        while (p1 < p2)
        {
            int temp = arr[p1];
            arr[p1] = arr[p2];
            arr[p2] = temp;

            p1++;
            p2--;
        }

        return arr;
    }
}

// Built-In Approch
public class ReverseagivenArray_BuiltIn
{
    public int[] ReverseArray(int n, int[] arr)
    {
        Array.Reverse(arr);
        return arr;
    }
}

// Recursive Approch (Learn only)
public class ReverseagivenArray_Recursive
{
    public int[] ReverseArray(int n, int[] arr)
    {
        return ReverseHelper(arr, 0, n - 1);
    }

    private int[] ReverseHelper(int[] arr, int start, int end)
    {
        if (start >= end) return arr;

        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        return ReverseHelper(arr, start + 1, end - 1);
    }
}
```