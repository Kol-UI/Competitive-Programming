namespace CompetitiveProgramming.Algorithms;

public class BeautifulString
{
    /*
        A string is beautiful if it's possible to partition it into one or more substrings such that:

        Each substring has an even length.
        Each substring contains only 1's or only 0's.
    */

    public static bool IsBeautifulString(string s)
    {
        for (int i = 0; i < s.Length; i += 2)
        {
            if (s[i] != s[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    #region LC 2914
    public static int MinimumChangesToGetBeautifulString(string s)
    {
        int countChanges = 0;
        for (int i = 0; i < s.Length; i += 2)
        {
            if (s[i] != s[i + 1])
            {
                countChanges++;
            }
        }
        return countChanges;
    }
    #endregion
}