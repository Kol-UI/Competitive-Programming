import java.util.ArrayList;

// Make the array beautiful


class Solution
{
    public static ArrayList<Integer> makeBeautiful(int[] arr)
    {
        int arrlength = arr.length;
        ArrayList<Integer> beautifulList = new ArrayList<>();
        for (int i = 0; i < arrlength; i++) 
        {
            if (beautifulList.size() != 0 && ((beautifulList.get(beautifulList.size() -1) < 0 && arr[i] >= 0 ) || (beautifulList.get(beautifulList.size() -1) >= 0 && arr[i] < 0)))
            {
                beautifulList.remove(beautifulList.size() - 1);
            }
              
            else
            {
                beautifulList.add(arr[i]);
            }
        }
        return beautifulList;
    }
}