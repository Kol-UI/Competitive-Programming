namespace CompetitiveProgramming.Algorithms;

public class StringMatching
{

    #region LC1408
    // Return all strings in words that is a substring of another word. You can return the answer in any order.
    // A substring is a contiguous sequence of characters within a string
    // ["mass","as","hero","superhero"] => ["as","hero"]
    public IList<string> StringMatchingInArray(string[] words)
    {
        return words.Where(w => words.Any(a => a.Contains(w) && a.Length > w.Length)).ToList();
    }
    #endregion

    #region LC2185
    // Return the number of strings in words that contain pref as a prefix
    // words = ["pay","attention","practice","attend"], pref = "at"
    // return 2
    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        foreach (var word in words)
        { 
            if (word.StartsWith(pref)) count++;
        }
        return count;
    }
    #endregion

    // Compares two strings in a generic way and returns the length of the longest common prefix.
	private static int GetCommonPrefixLength(string input, string target)
	{
		int result = 0;
		int minLength = Math.Min(input.Length, target.Length);

		while (result < minLength && input[result] == target[result])
		{
			result++;
		}

		return result;
	}

	// Compares two strings in a generic way and returns the length of the longest common suffix.
	private static int GetCommonSuffixLength(string input, string target)
	{
		int result = 0;
		int minLength = Math.Min(input.Length, target.Length);

		while (result < minLength && input[input.Length - 1 - result] == target[target.Length - 1 - result])
		{
			result++;
		}

		return result;
	}

	// String "bread"
	// Prefixes [b, br, bre, brea]
	// Suffixes [read, ead, ad, d]
	public (List<string>, List<string>) GetAllPrefixesAndSuffixes(string s)
	{
		List<string> prefixes = new();
		List<string> suffixes = new();
		for (int i = 1; i < s.Length; i++)
		{
			prefixes.Add(s.Substring(0, i));
			suffixes.Add(s.Substring(i, s.Length - i));
		}
		return (prefixes, suffixes);
	}

	// Returns strings that are both prefix & suffix of s
	public List<string> GetCommonPrefixSuffixes(string s)
	{
		List<string> result = new();

		for (int i = 1; i < s.Length; i++)
		{
			string prefix = s.Substring(0, i);
			string suffix = s.Substring(s.Length - i, i);

			if (prefix == suffix)
			{
				result.Add(prefix);
			}
		}

		return result;
	}

	// { "abc", "defabc", "abcxyz", "xyzabc" }
	// Returns 2
	// "abc" prefix of "defabc" & suffix of "abcxyz"
	// "xyz" prefix of "xyzabc" & suffix of "abcxyz
	public int CountPrefixSuffixPairs(string[] words)
	{
		int count = 0;

		for (int i = 0; i < words.Length; i++)
		{
			for (int j = 0; j < words.Length; j++)
			{
				if (i != j)
				{
					string prefix = words[i];
					string suffix = words[j];

					if (words[i].EndsWith(suffix) && words[j].StartsWith(prefix))
					{
						count++;
					}
				}
			}
		}

		return count;
	}

	public string GetMostCommonPrefix(string[] words)
	{
		Dictionary<string, int> prefixCount = new();
		string mostCommonPrefix = "";
		int maxCount = 0;

		foreach (var word in words)
		{
			for (int i = 1; i <= word.Length; i++)
			{
				string prefix = word.Substring(0, i);
				if (prefixCount.ContainsKey(prefix))
				{
					prefixCount[prefix]++;
				}
				else
				{
					prefixCount[prefix] = 1;
				}
			}
		}

		foreach (var prefix in prefixCount)
		{
			if (prefix.Value > maxCount)
			{
				mostCommonPrefix = prefix.Key;
				maxCount = prefix.Value;
			}
		}

		return mostCommonPrefix;
	}

	public string GetMostCommonSuffix(string[] words)
	{
		Dictionary<string, int> suffixCount = new();
		string mostCommonSuffix = "";
		int maxCount = 0;

		foreach (var word in words)
		{
			for (int i = 1; i <= word.Length; i++)
			{
				string suffix = word.Substring(word.Length - i, i);
				if (suffixCount.ContainsKey(suffix))
				{
					suffixCount[suffix]++;
				}
				else
				{
					suffixCount[suffix] = 1;
				}
			}
		}

		foreach (var suffix in suffixCount)
		{
			if (suffix.Value > maxCount)
			{
				mostCommonSuffix = suffix.Key;
				maxCount = suffix.Value;
			}
		}

		return mostCommonSuffix;
	}
}