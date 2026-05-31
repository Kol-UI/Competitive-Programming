
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.


Example 2:

Input: strs = [""]

Output: [[""]]


Example 3:

Input: strs = ["a"]

Output: [["a"]]



Sorting Solution :

```cs
public IList<IList<string>> GroupAnagrams(string[] strs)
{
    var result = new Dictionary<string, IList<string>>();
    for (int i = 0; i < strs.Length; i++)
    {
        string current = strs[i];
        char[] chars = current.ToCharArray();
        Array.Sort(chars);
        string sorted = new string(chars);
        if (result.ContainsKey(sorted))
        {
            result[sorted].Add(current);
        }
        else
        {
            result.Add(sorted, [current]);
        }
    }
    return result.Values.ToList();
}
```

This code groups anagrams by sorting each string and using the sorted version as a key in a dictionary.
If the key doesn't exist, it creates a new list for that key and adds the string to the list.
Finally, it returns all grouped anagrams.