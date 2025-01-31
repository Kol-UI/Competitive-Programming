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

    // Generate Subsets for an Array
    public IList<IList<int>> GenerateSubsets(int[] nums)
    {
        IList<IList<int>> subsets = new List<IList<int>>();
        GenerateSubsetsArray(nums, 0, new List<int>(), subsets);
        return subsets;
    }

    private void GenerateSubsetsArray(int[] nums, int index, List<int> currentSubset, IList<IList<int>> subsets)
    {
        subsets.Add(new List<int>(currentSubset));

        for (int i = index; i < nums.Length; i++)
        {
            currentSubset.Add(nums[i]);
            GenerateSubsetsArray(nums, i + 1, currentSubset, subsets);
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
    }


    // Duplicates are included
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> subsets = new List<IList<int>>();
        GenerateSubsetsIgnoreDuplicates(nums, 0, new List<int>(), subsets);
        return subsets;
    }

    private void GenerateSubsetsIgnoreDuplicates(int[] nums, int index, List<int> currentSubset, IList<IList<int>> subsets)
    {
        subsets.Add(new List<int>(currentSubset));

        for (int i = index; i < nums.Length; i++)
        {
            if (i > index && nums[i] == nums[i - 1]) continue;

            currentSubset.Add(nums[i]);
            GenerateSubsetsIgnoreDuplicates(nums, i + 1, currentSubset, subsets);
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
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


    // var subsets = GenerateSubsetsOfSize(nums, new List<int>(), 0, subsetSize);
	public static List<List<int>> GenerateSubsetsOfSize(List<int> nums, List<int> currentSubset, int index, int targetSize)
	{
		List<List<int>> subsets = new List<List<int>>();

		if (currentSubset.Count == targetSize)
		{
			subsets.Add(new List<int>(currentSubset));
			return subsets;
		}

		for (int i = index; i < nums.Count; i++)
		{
			currentSubset.Add(nums[i]);
			subsets.AddRange(GenerateSubsetsOfSize(nums, currentSubset, i + 1, targetSize));
			currentSubset.RemoveAt(currentSubset.Count - 1);
		}

		return subsets;
	}

}