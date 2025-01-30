namespace CompetitiveProgramming.Algorithms;

public class SubsetSum
{
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

	// Sums of all Subsets
	public static List<int> GetSumsOfAllSubsets(List<int> nums)
	{
		List<int> results = new();
		List<List<int>> subsets = GenerateSubsets(nums, new List<int>());
		foreach(List<int> subset in subsets) results.Add(subset.Sum());
		results.Sort();
		return results;
	}

	// Given a set of positive numbers, determine if a subset exists whose sum is equal to a given number
	public static int GetSubsetWhoseSumIsEqual(List<int> nums, int value)
	{
		int result = -1;
		List<List<int>> subsets = GenerateSubsets(nums, new List<int>());
		foreach (List<int> subset in subsets)
		{
			int sum = subset.Sum();
			if (sum == value) return sum;
		}
		return result;
	}

	public static bool HasSumSubsetEqual(List<int> nums, int value)
	{
		List<List<int>> subsets = GenerateSubsets(nums, new List<int>());
		foreach (List<int> subset in subsets)
		{
			int sum = subset.Sum();
			if (sum == value) return true;
		}
		return false;
	}
}