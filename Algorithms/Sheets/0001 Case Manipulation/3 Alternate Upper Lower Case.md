Alternate Case for a given string

```cs
public class ToAlternate
{
    public static string ToAlternateCase(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        var sb = new StringBuilder();
        bool upper = true; // Starts with upper

        foreach (char c in input)
        {
            if (upper)
                sb.Append(char.ToUpper(c));
            else
                sb.Append(char.ToLower(c));

            upper = !upper;
        }

        return sb.ToString();
    }
}
```