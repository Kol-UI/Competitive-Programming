Move Zeros to end

Problem Statement:
You are given an array of integers, your task is to move all the zeros in the array to the end of the array and move non-negative integers to the front by maintaining their order.


Example 1:
Input: 1 ,0 ,2 ,3 ,0 ,4 ,0 ,1
Output: 1 ,2 ,3 ,4 ,1 ,0 ,0 ,0
Explanation: All the zeros are moved to the end and non-negative integers are moved to front by maintaining order

Example 2:
Input: 1,2,0,1,0,4,0
Output: 1,2,1,4,0,0,0
Explanation: All the zeros are moved to the end and non-negative integers are moved to front by maintaining order


```cs
public class MoveAllZerosToTheEndOfTheArraySolution
{
    // Use an extra list
    public List<int> MoveZerosBruteForce(int n, List<int> a)
    {
        List<int> temp = new();

        // Copy non-zero elements from the original list to the temporary list.
        for (int i = 0; i < n; i++)
        {
            if (a[i] != 0)
            {
                temp.Add(a[i]);
            }
        }

        int numberOfNonZeros = temp.Count;
        for (int i = 0; i < numberOfNonZeros; i++)
        {
            a[i] = temp[i];
        }

        for (int i = numberOfNonZeros; i < n; i++)
        {
            a[i] = 0;
        }

        return a;
    }

    // This method efficiently moves all zeros to the end of the list
    // using a two-pointer approach, maintaining the relative order of non-zero elements.
    
    /*
        Pointer j (slow): This pointer is responsible for tracking the position of the first zero encountered in the list. This is the spot where a new non-zero element will be "moved" (swapped). It indicates the "front" of the accumulating zero section.
        Pointer i (fast): This pointer traverses the list from beginning to end (or from just after the first zero). Its job is to find the non-zero elements that need to be moved.
    */
    public List<int> MoveZerosTwoPointers(int n, List<int> a)
    {
        int j = -1;

        // Find first zero
        for (int i = 0; i < n; i++)
        {
            if (a[i] == 0)
            {
                j = i;
                break;
            }
        }

        if (j == -1) return a; // No zero in the original list

        /*
            this loop iterates through the list starting *after* the first zero found (at index 'j').
            Then check if the element at the current 'i' pointer is a non-zero element.
            If 'a[i]' is non-zero, it means we found a number that should
            come before the zero currently pointed to by 'j'.
            Swap the non-zero element at 'a[i]' with the zero element at 'a[j]'.
            After the swap, the element at 'j' is now a non-zero number,
            so 'j' needs to advance to the next position where a zero 
            is expected to be placed (or where the next non-zero should be moved).
        */
        for (int i = j + 1; i < n; i++)
        {
            if (a[i] != 0)
            {
                (a[i], a[j]) = (a[j], a[i]);
                j++;
            }
        }

        return a;
    }
}```
