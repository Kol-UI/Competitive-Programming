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
}