using System.Text;

namespace CompetitiveProgramming.Algorithms;
// Group strings that are anagrams of each other into the same list.
// Order of groups and order within groups does not matter.
public class GroupAnagrams
{
    // Approach 1: Sorted string as dictionary key
    public static List<List<string>> GroupBySortedKey(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }

    // Approach 2: Character count signature as key
    public static List<List<string>> GroupByCountKey(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            int[] counts = new int[26];
            foreach (char c in str)
            {
                counts[c - 'a']++;
            }

            var keyBuilder = new StringBuilder();
            foreach (int count in counts)
            {
                keyBuilder.Append(count).Append('#');
            }

            string key = keyBuilder.ToString();

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }
}