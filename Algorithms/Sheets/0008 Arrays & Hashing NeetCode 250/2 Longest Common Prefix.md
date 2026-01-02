Longest Common Prefix

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:


Input: strs = ["flower","flow","flight"]

Output: "fl"


Example 2:

Input: strs = ["dog","racecar","car"]

Output: ""

Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200

0 <= strs[i].length <= 200

strs[i] consists of only lowercase English letters if it is non-empty.




BF solution
```cs
public string LongestCommonPrefix(string[] strs)
{
	int size = strs.Length;
	if (strs is null || size == 0) return "";
	if (size == 1) return strs[0];
	StringBuilder result = new();

	for (int i = 0; i < strs[0].Length; i++)
	{
		char currentChar = strs[0][i];
		bool isCommon = true;
		for (int j = 1; j < size; j++)
		{
			if (i >= strs[j].Length || strs[j][i] != currentChar)
			{
				isCommon = false;
				break;
			}
		}
		if (isCommon) result.Append(currentChar);
		else return result.ToString();
	}

	return result.ToString();
}
```

Sorting
```cs
public string LongestCommonPrefixSorting(string[] strs)
{
	int size = strs.Length;
	if (size == 1) return strs[0];
	Array.Sort(strs);
	string first = strs[0];
	string last = strs[size - 1];

	int i = 0;
	while (i < Math.Min(first.Length, last.Length))
	{
		if (first[i] != last[i]) return first.Substring(0, i);
		i++;
	}

	return first;
}
```


Horizontal Scanning
```cs
public string LongestCommonPrefixHorizontalScanning(string[] strs)
{
	string prefix = strs[0];
	int size = strs.Length;

	for (int i = 1; i < size; i++)
	{
		int j = 0;
		while (j < Math.Min(prefix.Length, strs[i].Length))
		{
			if (prefix[j] != strs[i][j]) break;
			j++;
		}
		prefix = prefix.Substring(0, j);
	}

	return prefix;
}
```


Vertical Scanning
```cs
public string LongestCommonPrefixVerticalScanning(string[] strs)
{
	for (int i = 0; i < strs[0].Length; i++)
	{
		foreach (string s in strs)
		{
			if (i == s.Length || s[i] != strs[0][i])
			{
				return s.Substring(0, i);
			}
		}
	}
	return strs[0];
}
```

Horizontal Scanning (word by word) :

```cs
public string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0) return "";
    string longestCommonPrefix = strs[0];
    for (int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(longestCommonPrefix) != 0)
        {
            longestCommonPrefix = longestCommonPrefix.Substring(0, longestCommonPrefix.Length - 1);
            if (longestCommonPrefix == "") return "";
        }
    }
    return longestCommonPrefix;
}
```


Vertical Scanning (letter by letter) :

```cs
public string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0) return "";
    for (int i = 0; i < strs[0].Length; i++)
    {
        char c = strs[0][i];
        for (int j = 1; j < strs.Length; j++)
        {
            if (i == strs[j].Length || strs[j][i] != c)
                return strs[0].Substring(0, i);
        }
    }
    return strs[0];
}
```

