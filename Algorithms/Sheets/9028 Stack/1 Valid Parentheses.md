
Valid Parentheses

NeetCode 75



You are given a string s consisting of the following characters: '(', ')', '{', '}', '[' and ']'.


The input string s is valid if and only if:

Every open bracket is closed by the same type of close bracket.

Open brackets are closed in the correct order.

Every close bracket has a corresponding open bracket of the same type.

Return true if s is a valid string, and false otherwise.


Example 1:

Input: s = "[]"

Output: true


Example 2:

Input: s = "([{}])"

Output: true


Example 3:

Input: s = "[(])"

Output: false

Explanation: The brackets are not closed in the correct order.




Stack Switch Solution :


```cs

public class ValidParentheses()
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(s[i]);
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Peek() != '(') return false;
                    stack.Pop();
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Peek() != '{') return false;
                    stack.Pop();
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Peek() != '[') return false;
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }

        return stack.Count == 0;
    }
}
```



Stack & Mapping Solution :

```cs
public class StackHashValidParentheses()
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
            {
                if (stack.Count > 0 && stack.Peek() == map[c])
                {
                    stack.Pop();
                }
                else return false;
            }
            else stack.Push(c);
        }
        return stack.Count == 0;
    }
}
```