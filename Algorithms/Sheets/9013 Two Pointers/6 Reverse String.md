Reverse String :
You are given an array of characters which represents a string s.

Write a function which reverses a string.


```cs
// Using Temp Array Method
public class ReverseStringArray()
{
    public char[] ReverseString(char[] s)
    {
        char[] tmp = new char[s.Length];
        int len = s.Length;

        for (int i = 0; i < len; i++)
        {
            tmp[i] = s[len - 1 - i];
        }

        for (int i = 0; i < len; i++)
        {
            s[i] = tmp[i];
        }

        return s;
    }
}

// Using Recursion Two Pointers Method
public class ReverseStringRecursion()
{
    public char[] ReverseString(char[] s)
    {
        Reverse(s, 0, s.Length - 1);
        return s;
    }

    private void Reverse(char[] s, int left, int right)
    {
        if (left < right)
        {
            Reverse(s, left + 1, right - 1);
            (s[right], s[left]) = (s[left], s[right]);
        }
    }
}

// Using Built-In Function Method
public class ReverseStringBuiltIn()
{
    public char[] ReverseString(char[] s)
    {
        Array.Reverse(s);
        return s;
    }
}

// Using Stack Method
public class ReverseStringStack()
{
    public char[] ReverseString(char[] s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            stack.Push(c);
        }

        for (int i = 0; i < s.Length; i++)
        {
            s[i] = stack.Pop();
        }

        return s;
    }
}

// Using Two Pointers Method
public class ReverseStringTwoPointers()
{
    public char[] ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            (s[right], s[left]) = (s[left], s[right]);
            left++;
            right--;
        }
        return s;
    }
}
```