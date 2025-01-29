namespace CompetitiveProgramming.Algorithms;

public class GeneratingSubsets
{
    // var subsets = GenerateSubsets(nums, new List<int>());
    public static List<List<int>> GenerateSubsets(List<int> nums, List<int> currentSubset)
    {
        List<List<int>> subsets = new List<List<int>>();
        subsets.Add(new List<int>(currentSubset));

        for (int i = 0; i < nums.Count; i++)
        {
            currentSubset.Add(nums[i]);
            subsets.AddRange(GenerateSubsets(nums.GetRange(i + 1, nums.Count - i - 1), currentSubset));
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }

        return subsets;
    }


    // var subsetsFromIndex = GenerateSubsetsFromIndex(nums, new List<int>(), 2);
    public static List<List<int>> GenerateSubsetsFromIndex(List<int> nums, List<int> currentSubset, int index)
    {
        List<List<int>> subsets = new List<List<int>>();
        subsets.Add(new List<int>(currentSubset));

        for (int i = index; i < nums.Count; i++)
        {
            currentSubset.Add(nums[i]);
            subsets.AddRange(GenerateSubsetsFromIndex(nums, currentSubset, i + 1));
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }

        return subsets;
    }


    // var subsetsFromRange = GenerateSubsetsFromRange(nums, new List<int>(), 1, 3);
    public static List<List<int>> GenerateSubsetsFromRange(List<int> nums, List<int> currentSubset, int startIndex, int endIndex)
    {
        List<List<int>> subsets = new List<List<int>>();
        subsets.Add(new List<int>(currentSubset));

        for (int i = startIndex; i <= endIndex && i < nums.Count; i++)
        {
            currentSubset.Add(nums[i]);
            subsets.AddRange(GenerateSubsetsFromRange(nums, currentSubset, i + 1, endIndex));
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }

        return subsets;
    }

}