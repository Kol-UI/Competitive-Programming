Given two sorted arrays, arr1, and arr2 of size n and m.

Find the union of two sorted arrays.

The union of two arrays can be defined as the common and distinct elements in the two arrays.

NOTE: Elements in the union should be in ascending order.


Example 1:

Input:

n = 5,m = 5.

arr1[] = {1,2,3,4,5}  

arr2[] = {2,3,4,4,5}

Output: {1,2,3,4,5}


Explanation: 

Common Elements in arr1 and arr2  are:  2,3,4,5

Distinct Elements in arr1 are : 1

Distinct Elements in arr2 are : No distinct elements.

Union of arr1 and arr2 is {1,2,3,4,5} 


Example 2:

Input:

n = 10,m = 7.

arr1[] = {1,2,3,4,5,6,7,8,9,10}

arr2[] = {2,3,4,4,5,11,12}

Output: {1,2,3,4,5,6,7,8,9,10,11,12}


Explanation: 


Common Elements in arr1 and arr2  are:  2,3,4,5

Distinct Elements in arr1 are : 1,6,7,8,9,10

Distinct Elemennts in arr2 are : 11,12

Union of arr1 and arr2 is {1,2,3,4,5,6,7,8,9,10,11,12} 



**Solution 1: Using Dictionary<TKey, TValue>**



Our aim is to find the common elements in arr1 and arr2, and the distinct elements of arr1 and arr2.

Use a single Dictionary<TKey, TValue> to find the frequencies of elements in arr1 and arr2.

Since we are using only a single dictionary, common elements in arr1 and arr2 are treated as a single element for frequency counting, so there won't be duplicates in the final frequency count.


Why Dictionary<TKey, TValue> instead of Hashtable or another collection?

While C# has various dictionary-like collections, Dictionary<TKey, TValue> is generally preferred for its type safety and performance (it's essentially a generic hash table).

It offers good performance for lookups and insertions.

If you need the keys to be in a sorted order, you would typically use a SortedDictionary<TKey, TValue> instead.

Dictionary<TKey, TValue> stores keys in an unpredictable order (based on hashing), similar to C++'s unordered_map.

If the requirement is to have the union elements in ascending order, you'd either use SortedDictionary<TKey, TValue> from the start, or sort the elements after populating a regular Dictionary<TKey, TValue>.

```cs
public class UnionofTwoSortedArraysDictionary
{
    public List<int> FindUnion(int[] arr1, int[] arr2)
    {
        int n = arr1.Length;
        int m = arr2.Length;
        Dictionary<int, int> freq = new Dictionary<int, int>();
        List<int> unionList = new List<int>();

        // Iterate through the first array and count frequencies
        for (int i = 0; i < n; i++)
        {
            if (freq.ContainsKey(arr1[i]))
            {
                freq[arr1[i]]++;
            }
            else
            {
                freq.Add(arr1[i], 1);
            }
        }

        // Iterate through the second array and count frequencies.
        // This handles common elements by incrementing their existing frequency.
        for (int i = 0; i < m; i++)
        {
            if (freq.ContainsKey(arr2[i]))
            {
                freq[arr2[i]]++;
            }
            else
            {
                freq.Add(arr2[i], 1);
            }
        }

        // Iterate through the dictionary keys to get the unique elements and add them to the union list.
        // By default, the order of keys in a Dictionary is not guaranteed to be sorted.
        foreach (var entry in freq)
        {
            unionList.Add(entry.Key);
        }
        unionList.Sort();
        return unionList;
    }
}
```



**Solution 2: Using HashSet**

Suppose we consider arr1 and arr2 as a single array say arr,

then the union of arr1 and arr2 is the distinct elements in arr.

Example:

arr1[] = {1,2,3,4,5,6,7,8,9,10}

arr2[] = {2,3,4,4,5,11,12} 

arr = arr1 + arr2 = {1,2,3,4,5,67,8,9,
                     10,2,3,4,4,5,11,12}

Distinct element in 
arr = {1,2,3,4,5,6,7,8,9,10,11,12} 
    = Union of arr1,arr2.
	
So using a set we can find the distinct elements because the set does not hold any duplicates.

Hence we can find the union of arr1 and arr2.

```cs
public class UnionofTwoSortedArraysHashSet
{
    public List<int> FindUnion(int[] arr1, int[] arr2)
    {
        int n = arr1.Length;
        int m = arr2.Length;
        HashSet<int> uniqueElements = new HashSet<int>();

        // Duplicates are automatically ignored by HashSet.
        for (int i = 0; i < n; i++)
        {
            uniqueElements.Add(arr1[i]);
        }

        for (int i = 0; i < m; i++)
        {
            uniqueElements.Add(arr2[i]);
        }

        List<int> unionList = uniqueElements.ToList();
        unionList.Sort();
        return unionList;
    }
}
```



**Solution 3: Two Pointers**

Solution 1 and 2 work for the unsorted arrays also, The arrays arr1 and arr2 are sorted, can we use this property to reduce the time Complexity?

**Approach:**


Take two pointers let’s say i,j pointing to the 0th index of arr1 and arr2.

Create an empty list for storing the union of arr1 and arr2.

From solution 2 we know that the union is nothing but the distinct elements in arr1 + arr2 

Let’s traverse the arr1 and arr2 using pointers i and j and insert the distinct elements found into the union list.

While traversing we may encounter three cases.


**arr1[i] == arr2[j]**


Here we found a common element, so insert only one element in the union. Let’s insert arr[i] in union and increment i.

NOTE:

There may be cases like the element to be inserted is already present in the union, in that case, we are inserting duplicates which is not desired.

So while inserting always check whether the last element in the union list is equal or not to the element to be inserted.

If equal we are trying to insert duplicates, so don’t insert the element, else insert the element in the union.

This makes sure that we are not inserting any duplicates in the union because we are inserting elements in sorted order.

**arr1[i] < arr2[j]**


arr1[i] < arr2[j] so we need to insert arr1[i] in union.

IF last element in union list is not equal to arr1[i],then insert in union else don’t insert.

After checking Increment i.

**arr1[i] > arr2[j]**


arr1[i] > arr2[j] so we need to insert arr2[j] in union.

IF the last element in the union list is not equal to arr2[j], then insert in the union, else don’t insert.

After checking Increment j.

After traversing if any elements are left in arr1 or arr2 check for condition and insert in the union.


```cs
public class UnionofTwoSortedArraysTwoPointers
{
    public List<int> FindUnion(int[] arr1, int[] arr2)
    {
        int n = arr1.Length;
        int m = arr2.Length;
        int i = 0, j = 0;
        List<int> unionList = new List<int>();

        while (i < n && j < m)
        {
            // Case 1: arr1[i] is smaller than arr2[j]
            // Add arr1[i] to union if it's not a duplicate of the last element added
            if (arr1[i] <= arr2[j])
            { 
                if (unionList.Count == 0 || unionList[unionList.Count - 1] != arr1[i])
                {
                    unionList.Add(arr1[i]);
                }
                i++;
            }
            // Case 2: arr2[j] is smaller than arr1[i]
            // Add arr2[j] to union if it's not a duplicate of the last element added
            else
            { 
                if (unionList.Count == 0 || unionList[unionList.Count - 1] != arr2[j])
                {
                    unionList.Add(arr2[j]);
                }
                j++;
            }
        }

        // Add any remaining elements from arr1 (if arr2 was exhausted first)
        while (i < n)
        {
            if (unionList[unionList.Count - 1] != arr1[i])
            {
                unionList.Add(arr1[i]);
            }
            i++;
        }

        // Add any remaining elements from arr2 (if arr1 was exhausted first)
        while (j < m)
        {
            if (unionList[unionList.Count - 1] != arr2[j])
            {
                unionList.Add(arr2[j]);
            }
            j++;
        }

        return unionList;
    }
}
```