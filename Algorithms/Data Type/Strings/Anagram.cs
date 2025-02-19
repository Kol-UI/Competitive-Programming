namespace CompetitiveProgramming.Algorithms;
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
// "eat","tea","ate" are anagrams
public class Anagram
{
    #region LC 242
    // Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;
        
        char[] ss = s.ToCharArray();
        char[] tt = t.ToCharArray();

        Array.Sort(ss);
        Array.Sort(tt);

        return new string(ss) == new string(tt);
    }
    #endregion

    #region LC 49
    /* Group Anagrams :
        Input: strs = ["eat","tea","tan","ate","nat","bat"]
        Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    */
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var set = new Dictionary<string, IList<string>>();
        foreach(string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string value = new(chars);
            if(!set.ContainsKey(value))
            {
                set[value] = new List<string>();
            }
            set[value].Add(str);
        }

        return set.Values.ToList();
    }
    #endregion

    // "abc" => ["abc", "acb", "bac", "bca", "cab", "cba"]
    private static List<string> GenerateAnagrams(string s)
    {
        List<string> anagrams = new List<string>();
        GenerateAnagramsRecursive(s.ToCharArray(), 0, s.Length - 1, anagrams);
        return anagrams;
    }

    private static void GenerateAnagramsRecursive(char[] arr, int start, int end, List<string> result)
    {
        if (start == end)
        {
            result.Add(new string(arr));
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                Swap(ref arr[start], ref arr[i]);
                GenerateAnagramsRecursive(arr, start + 1, end, result);
                Swap(ref arr[start], ref arr[i]);
            }
        }
    }

    private static void Swap(ref char a, ref char b)
    {
        if (a == b) return;
        char temp = a;
        a = b;
        b = temp;
    }

    private static List<string> FindLargestAnagramGroup(List<string> strings)
    {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (string s in strings)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if (!groups.ContainsKey(sorted))
            {
                groups[sorted] = new List<string>();
            }
            groups[sorted].Add(s);
        }

        return groups.Values.OrderByDescending(group => group.Count).First();
    }

    private static int CountUniqueAnagrams(List<string> strings)
    {
        HashSet<string> uniqueGroups = new HashSet<string>();

        foreach (string s in strings)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            uniqueGroups.Add(new string(chars));
        }

        return uniqueGroups.Count;
    }

    private static List<string> FindAnagramsInList(string target, List<string> strings)
    {
        List<string> anagrams = new List<string>();
        char[] targetChars = target.ToCharArray();
        Array.Sort(targetChars);
        string sortedTarget = new string(targetChars);

        foreach (string s in strings)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            if (new string(chars) == sortedTarget)
            {
                anagrams.Add(s);
            }
        }

        return anagrams;
    }

    private static bool IsAnagramOfPalindrome(string s)
    {
        int[] count = new int[26];
        foreach (char c in s)
        {
            count[char.ToLower(c) - 'a']++;
        }

        int oddCount = 0;
        foreach (int c in count)
        {
            if (c % 2 != 0)
                oddCount++;
        }

        return oddCount <= 1;
    }

    private static bool AreAnagramsIgnoreCaseAndPunctuation(string s1, string s2)
    {
        s1 = new string(s1.Where(char.IsLetter).ToArray()).ToLower();
        s2 = new string(s2.Where(char.IsLetter).ToArray()).ToLower();

        return IsAnagram(s1, s2);
    }
}