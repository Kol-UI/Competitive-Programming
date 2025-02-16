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

