
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false




```cs
public bool IsAnagram(string s, string t)
{
    if(s.Length != t.Length) return false;
    
    char[] ss = s.ToCharArray();
    char[] tt = t.ToCharArray();

    Array.Sort(ss);
    Array.Sort(tt);

    return new string(ss) == new string(tt);
}
```
