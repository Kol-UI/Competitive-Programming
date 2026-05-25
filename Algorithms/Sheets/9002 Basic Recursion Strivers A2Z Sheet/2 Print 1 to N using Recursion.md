Problem Description: Given an integer N, write a program to print numbers from 1 to N.


Input: N = 4

Output: 1, 2, 3, 4

Explanation: All the numbers from 1 to 4 are printed.


Input: N = 1

Output: 1

Explanation: This is the base case. Pre-Order


```cs
public class Print1toNusingRecursion
{
    // Pre-Order
    public void GetNTimesNumberRecursive(int current, int n)
    {
        if (current > n) return;
        Console.Write(current + " ");
        GetNTimesNumberRecursive(current + 1, n);
    }

    // GetNTimesNumberRecursive(1, 4)
    // 1 2 3 4
    // GetNTimesNumberRecursive(1, 1)
    // 1

    // Bonus : Post-Order
    public void GetNTimesNumberRecursivePostOrder(int current, int n)
    {
        if (current > n) return;
        // Order changed
        GetNTimesNumberRecursive(current + 1, n);
        Console.Write(current + " ");
    }

    // GetNTimesNumberRecursivePostOrder(1, 4)
    // 4 3 2 1
    // GetNTimesNumberRecursivePostOrder(1, 1)
    // 1
}
```