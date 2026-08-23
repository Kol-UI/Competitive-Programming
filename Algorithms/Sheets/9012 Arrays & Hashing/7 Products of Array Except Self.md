// Products of Array Except Self

Given an integer array nums, return an array output where output[i] is the product of all the elements of nums except nums[i].

Each product is guaranteed to fit in a 32-bit integer.


Example 1:

Input: nums = [1,2,4,6]

Output: [48,24,12,8]



Example 2:

Input: nums = [-1,0,1,2,3]

Output: [0,-6,0,0,0]


```cs
public class ProductsofArrayExceptSelfBruteForce
{
    // * all except current
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int product = 1;
            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    product *= nums[j];
                }
            }
            result[i] = product;
        }
        return result;
    }
}

public class ProductsofArrayExceptSelfDivision
{
    // * all then / by current
    public int[] ProductExceptSelf(int[] nums)
    {
        int product = 1, zeroCount = 0, n = nums.Length;
        foreach (int num in nums)
        {
            if (num != 0)
            {
                product *= num;
            }
            else
            {
                zeroCount++;
            }
        }

        if (zeroCount > 1) return new int[n]; // if there is a 0 then all zero !

        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (zeroCount > 0)
            {
                result[i] = (nums[i] == 0) ? product : 0;
            }
            else
            {
                result[i] = product / nums[i];
                // ex1: 48/6 = 8
                // so we can * all then / by current
            }
        }
        return result;
    }
}


public class ProductsofArrayExceptPrefixSuffix
{
    /*
        calculate product on left of each position (A)
        then calculate product on right of each position (B)
        then A * B (it represent product of each except position)


        Step 1
        nums = [1, 2, 3, 4]
        prefixe = [1, _, _, _]
        suffixe = [_, _, _, 1]

        Step 2
        nums = [1, 2, 3, 4]
        prefixe = [1, 1, 2, 6]
        1 * 1 = 1
        2 * 1 = 2
        3 * 2 = 6

        Step 3
        nums = [1, 2, 3, 4]
        suffixe = [24, 12, 4, 1]
        4 * 1 = 4
        3 * 4 = 12
        12 * 2 = 24

        Step 4
        prefixe = [1, 1, 2, 6]
        suffixe = [24, 12, 4, 1]

        final result [24, 12, 8, 6]
        1 * 24 = 24
        1 * 12 = 12
        2 * 4 = 8
        6 * 1 = 6

    */
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        // Step 1
        prefix[0] = 1;
        suffix[n - 1] = 1;

        // Step 2
        for (int i = 1; i < n; i++)
        {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        // Step 3
        for (int i = n - 2; i >= 0; i--)
        {
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        // Step 3
        for (int i = 0; i < n; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}


public class ProductsofArrayExceptPrefixSuffixOpti
{
    /*
        Step 1
        nums = [1, 2, 3, 4]
        result = [1, 1, 1, 1]

        Step 2
        calculate products from left to right
        nums = [1, 2, 3, 4]
        result = [1, 1, 2, 6]
        1 * 1 = 1
        1 * 2 = 2
        2 * 3 = 6

        Step 3
        calculate products from right to left
        postfix : products on right
        for each position :
            result[i] * postfix
            postfix = nums[i] * postfix

        6 * 1 = 6 (result) & 1 * 4 = 4 (postfix is now 4)
        2 * 4 = 8 (result) & 4 * 3 = 12 (postfix is now 12)
        1 * 12 = 12 (result) & 12 * 2 = 24 (postfix is now 24)
        1 * 24 = 24 (result) & 24 * 1 = 24

        final result = [24, 12, 8, 6]

    */
    public int[] ProductExceptSelf(int[] nums)
    {
        // Step 1
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, 1);

        // Step 2
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        // Step 3
        int postfix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }
        return result;
    }
}
```