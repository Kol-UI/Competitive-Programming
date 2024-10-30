namespace CompetitiveProgramming.Algorithms;

public class MountainArray
{
    /*
        Moutain Array :
        Strictly Increasing & Strictly Decreasing
        
        Strictly Increasing | Strictly Decreasing
        [0,2,3,4,5,             2,1,0]      => true
        [0,2,3,3,5,             2,1,0]      => false
        [2,1]                               => false
        [3,5,5]                             => false
        [0,3,                   2,1]        => true
    */
    #region LC 941
    public bool IsValidMountainArray(int[] arr)
    {
        if (arr.Length < 3)
        {
            return false;
        }

        int i = 0;
        while (i < arr.Length - 1 && arr[i] < arr[i + 1]) 
        {
            i++;
        }
        if (i == 0 || i == arr.Length - 1) 
        {
            return false;
        }
        while (i < arr.Length - 1 && arr[i] > arr[i + 1]) 
        {
            i++;
        }

        return i == arr.Length - 1;
    }
    #endregion

    #region LC 1671
    // return the minimum number of elements to remove to make nums​​​ a mountain array.
    public int MinimumNumberOfElementsToMakeMountainArray(int[] nums)
    {
        int n = nums.Length;
        
        List<int> lis = LisLength(nums);
        
        Array.Reverse(nums);
        List<int> lds = LisLength(nums);
        lds.Reverse();
        Array.Reverse(nums);
        
        int removals = int.MaxValue;
        
        for (int i = 0; i < n; i++)
        {
            if (lis[i] > 1 && lds[i] > 1)
            {
                removals = Math.Min(removals, n + 1 - lis[i] - lds[i]);
            }
        }
        
        return removals;
    }
    
    private List<int> LisLength(int[] v)
    {
        List<int> lis = new List<int> { v[0] };
        List<int> lisLen = new List<int>(new int[v.Length]);
        
        for (int i = 0; i < v.Length; i++)
        {
            lisLen[i] = 1;
        }

        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] > lis[lis.Count - 1])
            {
                lis.Add(v[i]);
            }
            else
            {
                int index = lis.BinarySearch(v[i]);
                if (index < 0)
                {
                    index = ~index;
                }
                lis[index] = v[i];
            }
            lisLen[i] = lis.Count;
        }
        return lisLen;
    }
    #endregion
}