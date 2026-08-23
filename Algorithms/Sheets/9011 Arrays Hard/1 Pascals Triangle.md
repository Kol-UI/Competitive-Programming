Pascal's Triangle


Problem Statement: This problem has 3 variations. They are stated below:

Variation 1: Given row number r and column number c. Print the element at position (r, c) in Pascal’s triangle.

Variation 2: Given the row number n. Print the n-th row of Pascal’s triangle.

Variation 3: Given the number of rows n. Print the first n rows of Pascal’s triangle.



Variation 1 : 

In this case, we are given the row number r and the column number c, and we need to find out the element at position (r,c). 

```cs

public class PascalsTriangleVariationOne()
{
    public static long NCr(int n, int r)
    {
        // We ensure that r does not exceed n/2, because C(n,r) = C(n,n−r)
        // This minimizes the number of iterations
        if (r < 0 || r > n) return 0;
        if (r == 0 || r == n) return 1;
        if (r > n / 2) r = n - r;

        long result = 1;

        for (int i = 0; i < r; i++)
        {
            result *= (n - i);
            result /= (i + 1);
        }

        return result;
    }

    // Main function to find the element of Pascal's Triangle
    // The element at row r and column c is given by C(r-1, c-1)
    public int GetPascalElement(int r, int c)
    {
        long element = NCr(r - 1, c - 1);
        return (int)element;
    }
}
```



Variation 2 : 

Given the row number n. Print the n-th row of Pascal’s triangle.

Our first observation regarding Pascal’s triangle should be that the n-th row of the triangle has exactly n elements.
With this observation, we will proceed to solve this problem.


```cs
public class PascalsTriangleVariationTwo
{
    public static void GeneratePascalRow(int n)
    {
        long ans = 1;
        Console.Write(ans + " ");
        for (int i = 1; i < n; i++)
        {
            ans *= (n - i);
            ans /= i;

            Console.Write(ans + " ");
        }

        Console.WriteLine();
    }
}
```



Variation 3 : 

```cs
public class PascalTriangleVariationThree
{
    public static List<int> GenerateRow(int row)
    {
        long ans = 1;
        List<int> ansRow = new List<int>();
        ansRow.Add(1);
        for (int col = 1; col < row; col++)
        {
            ans *= (row - col);
            ans /= col;
            ansRow.Add((int)ans);
        }
        return ansRow;
    }

    public static List<List<int>> PascalTriangle(int n)
    {
        List<List<int>> ans = new List<List<int>>();
        for (int row = 1; row <= n; row++)
        {
            ans.Add(GenerateRow(row));
        }
        return ans;
    }
}
```