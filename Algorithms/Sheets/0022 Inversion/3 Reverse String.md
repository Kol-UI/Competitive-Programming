Reverse String

```cs
// Reverse String
// Given a string, return it reversed.
// Multiple approaches : built-in, LINQ, manual, StringBuilder, recursive, stack-based.
public class ReverseString
{
    // Approach 1: Convert to char array, use Array.Reverse
    public static string ReverseBuiltIn(string s)
    {
        char[] chars = s.ToCharArray();
        System.Array.Reverse(chars);
        return new string(chars);
    }

    // Approach 2: LINQ .Reverse() on chars
    public static string ReverseLinq(string s)
    {
        return new string(s.Reverse().ToArray());
    }

    // Approach 3: StringBuilder, appending from the end
    public static string ReverseStringBuilder(string s)
    {
        var sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }

    // Approach 4: Manual, build new char array by index
    public static string ReverseManualArray(string s)
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            result[i] = s[s.Length - 1 - i];
        }
        return new string(result);
    }

    // Approach 5: Two-pointer swap on a char array
    public static string ReverseTwoPointers(string s)
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;
        while (left < right)
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);
            left++;
            right--;
        }
        return new string(chars);
    }

    // Approach 6: Recursive, one char at a time
    public static string ReverseRecursive(string s)
    {
        if (s.Length <= 1) return s;
        return ReverseRecursive(s.Substring(1)) + s[0];
    }

    // Approach 7: Stack
    public static string ReverseWithStack(string s)
    {
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            stack.Push(c);
        }

        var sb = new StringBuilder(s.Length);
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }

    // Approach 8: String concatenation with simple loop (least efficient)
    public static string ReverseConcat(string s)
    {
        string result = "";
        foreach (char c in s)
        {
            result = c + result;
        }
        return result;
    }
}```