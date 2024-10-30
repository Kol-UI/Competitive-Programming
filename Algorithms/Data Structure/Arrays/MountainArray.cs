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
}