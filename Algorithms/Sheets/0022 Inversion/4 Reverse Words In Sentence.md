Reverse Words in a Sentence

```cs
// Problem: Reverse Words in a Sentence
// Given a sentence, reverse the order of the words.
// Extra spaces (leading, trailing, multiple between words) should be collapsed to a single space.
// Example: "  the sky   is blue  " -> "blue is sky the"
public class ReverseWordsInSentence
{
    // Approach 1: Split, Array.Reverse, Join (built-in)
    public static string ReverseBuiltIn(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(' ', words);
    }

    // Approach 2: LINQ Split + Reverse + Join
    public static string ReverseLinq(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
        return string.Join(' ', words);
    }

    // Approach 3: Manual with StringBuilder
    public static string ReverseManual(string s)
    {
        var words = new List<string>();
        var current = new StringBuilder();

        foreach (char c in s)
        {
            if (c == ' ')
            {
                if (current.Length > 0)
                {
                    words.Add(current.ToString());
                    current.Clear();
                }
            }
            else
            {
                current.Append(c);
            }
        }
        if (current.Length > 0)
        {
            words.Add(current.ToString());
        }

        var sb = new StringBuilder();
        for (int i = words.Count - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
            if (i > 0) sb.Append(' ');
        }
        return sb.ToString();
    }

    // Approach 4: Stack
    public static string ReverseWithStack(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var stack = new Stack<string>(words);

        var sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
            if (stack.Count > 0) sb.Append(' ');
        }
        return sb.ToString();
    }

    // Approach 5: Two-pointer swap on the word array, then join
    public static string ReverseTwoPointers(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int left = 0;
        int right = words.Length - 1;
        while (left < right)
        {
            (words[left], words[right]) = (words[right], words[left]);
            left++;
            right--;
        }
        return string.Join(' ', words);
    }
}```