Merge Sorted Array :

You are given two integer arrays nums1 and nums2, both sorted in non-decreasing order, along with two integers m and n, where:


m is the number of valid elements in nums1,

n is the number of elements in nums2.

The array nums1 has a total length of (m+n), with the first m elements containing the values to be merged, and the last n elements set to 0 as placeholders.


Your task is to merge the two arrays such that the final merged array is also sorted in non-decreasing order and stored entirely within nums1.

You must modify nums1 in-place and do not return anything from the function.


Example 1:

Input: nums1 = [10,20,20,40,0,0], m = 4, nums2 = [1,2], n = 2

Output: [1,2,10,20,20,40]


Example 2:

Input: nums1 = [0,0], m = 0, nums2 = [1,2], n = 2

Output: [1,2]


```cs

// Sorting Approch
public class MergeSortedArraySorting()
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i + m] = nums2[i];
        }
        Array.Sort(nums1);
    }

    /* nums1 = [10,20,20,40,0,0], m = 4, nums2 = [1,2], n = 2

        i = 0 : 
        nums1[4] = nums2[0] (1)
        [10,20,20,40,1,0]

        i = 1 :
        nums1[5] = nums2[1] (2)
        [10,20,20,40,1,2]

        Array.Sort = [1,2,10,20,20,40]
    */
}

// Two Pointers with extra space Approch
// Copy nums1, take in nums2 or copy depending of value
public class MergeSortedArrayTwoPointersExtraSpace()
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] nums1Copy = new int[m];
        Array.Copy(nums1, nums1Copy, m);

        int idx = 0, i = 0, j = 0;

        while (idx < m + n)
        {
            if (j >= n || (i < m && nums1Copy[i] <= nums2[j]))
            {
                nums1[idx++] = nums1Copy[i++];
            }
            else
            {
                nums1[idx++] = nums2[j++];
            }
        }

        /* nums1 = [10,20,20,40,0,0], m = 4, nums2 = [1,2], n = 2

            copy = [10,20,20,40,0,0]
            
            while :
                int idx = 0, i = 0, j = 0, m = 4, n = 2
                else : nums1[0] = nums2[0] (1)
                [1,20,20,40,0,0] / [10,20,20,40,0,0]
                int idx = 1, i = 0, j = 1, m = 4, n = 2
                else : nums1[1] = nums2[1] (2)
                [1,2,20,40,0,0] / [10,20,20,40,0,0]
                int idx = 2, i = 0, j = 2, m = 4, n = 2
                if : nums1[2] = copy[0]
                [1,2,10,40,0,0] / [10,20,20,40,0,0]
                int idx = 3, i = 1, j = 2, m = 4, n = 2
                if : nums1[3] = copy[1]
                [1,2,10,20,0,0] / [10,20,20,40,0,0]
                int idx = 4, i = 2, j = 2, m = 4, n = 2
                if : nums1[4] = copy[2]
                [1,2,10,20,20,0] / [10,20,20,40,0,0]
                int idx = 5, i = 3, j = 2, m = 4, n = 2
                if : nums1[5] = copy[3]
                [1,2,10,20,20,40] / [10,20,20,40,0,0]
                int idx = 6, i = 4, j = 2, m = 4, n = 2

            result [1,2,10,20,20,40]

        */
    }
}

// Three Pointers Extra Space 1 Approch
public class MergeSortedArrayThreePointersExtraSpaceI
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int last = m + n - 1;

        // Merge in reverse order
        while (m > 0 && n > 0)
        {
            if (nums1[m - 1] > nums2[n - 1])
            {
                nums1[last] = nums1[m - 1];
                m--;
            }
            else
            {
                nums1[last] = nums2[n - 1];
                n--;
            }
            last--;
        }

        // Fill nums1 with leftover nums2 elements
        while (n > 0)
        {
            nums1[last] = nums2[n - 1];
            n--;
            last--;
        }


        /*
            nums1 = [10,20,20,40,0,0], m = 4, nums2 = [1,2], n = 2

            last = 5
            while :
                if (40 > 2)
                    nums1[5] = nums1[3] (40)
                    nums1 = [10,20,20,40,0,40]
                    m = 3
                last = 4
                if (20 > 2)
                    nums1[4] = nums1[2] (20)
                    nums1 = [10,20,20,40,20,40]
                    m = 2
                last = 3
                if (20 > 2)
                    nums1[3] = nums1[1] (20)
                    nums1 = [10,20,20,20,20,40]
                    m = 1
                last = 2
                if (10 > 2)
                    nums1[2] = nums1[0] (10)
                    nums1 = [10,20,10,20,20,40]
                    m = 0
                last = 1

                no else in this case

            while :
            m = 0, n = 2, last = 1
            nums1[1] = nums2[1] (2)
            nums1 = [10,2,10,20,20,40]
            n = 1
            last = 0
            
            m = 0, n = 1, last = 0
            nums1[0] = nums2[0] (1)
            nums1 = [1,2,10,20,20,40]
            n = 0
            last = -1

        */
    }
}

// Three Pointers Extra Space 2 Approch
public class MergeSortedArrayThreePointersExtraSpaceII
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int last = m + n - 1;
        int i = m - 1, j = n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[last--] = nums1[i--];
            }
            else
            {
                nums1[last--] = nums2[j--];
            }
        }

        /*
            nums1 = [10,20,20,40,0,0], m = 4, nums2 = [1,2], n = 2
            
            last = 5
            i = 3
            j = 1

            while (j >= 0)
            
                j = 1
                if (i >= 0 && nums1[i] > nums2[j])
                    if (3 >= 0 && nums1[3] (40) > nums2[1] (2)) est VRAI
                        nums1[last--] = nums1[i--] -> nums1[5] = nums1[3] (40)
                        nums1 = [10,20,20,40,0,40]
                        last = 4
                        i = 2
                
                j = 1
                if (i >= 0 && nums1[i] > nums2[j])
                    if (2 >= 0 && nums1[2] (20) > nums2[1] (2)) est VRAI
                        nums1[last--] = nums1[i--] -> nums1[4] = nums1[2] (20)
                        nums1 = [10,20,20,40,20,40]
                        last = 3
                        i = 1

                j = 1
                if (i >= 0 && nums1[i] > nums2[j])
                    if (1 >= 0 && nums1[1] (20) > nums2[1] (2)) est VRAI
                        nums1[last--] = nums1[i--] -> nums1[3] = nums1[1] (20)
                        nums1 = [10,20,20,20,20,40]
                        last = 2
                        i = 0
                        
                j = 1
                if (i >= 0 && nums1[i] > nums2[j])
                    if (0 >= 0 && nums1[0] (10) > nums2[1] (2)) est VRAI
                        nums1[last--] = nums1[i--] -> nums1[2] = nums1[0] (10)
                        nums1 = [10,20,10,20,20,40]
                        last = 1
                        i = -1
                        
                j = 1
        */
    }
}
```