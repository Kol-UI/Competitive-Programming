Inverse case of each letters in a string.

```cs
public class InverseCaseConverter
{
    public static string ToInverseCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input ?? string.Empty;
        }

        StringBuilder sb = new(input.Length);

        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                sb.Append(char.ToLowerInvariant(c));
            }
            else if (char.IsLower(c))
            {
                sb.Append(char.ToUpperInvariant(c));
            }
            else
            {
                // digits, spaces and symbols do not changes
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
```