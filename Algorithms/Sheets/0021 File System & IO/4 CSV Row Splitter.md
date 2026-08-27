CSV Row Splitter

```cs
// Problem: split a single CSV line into its fields.
// Rules: fields can be quoted with double quotes, quoted fields can contain
// commas, and "" inside a quoted field means an escaped literal quote.
// Example: "a,\"b,c\",\"d\"\"e\""  ->  [a] [b,c] [d"e]

// Approach 1 : Manual
public class CsvRowSplitterManual
{
    public List<string> Split(string line)
    {
        var fields = new List<string>();
        if (line == null)
            return fields;

        var current = new StringBuilder();
        bool insideQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (insideQuotes)
            {
                if (c == '"')
                {
                    // escaped quote "" -> literal "
                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        insideQuotes = false;
                    }
                }
                else
                {
                    current.Append(c);
                }
            }
            else
            {
                if (c == '"')
                {
                    insideQuotes = true;
                }
                else if (c == ',')
                {
                    fields.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }
        }

        fields.Add(current.ToString());
        return fields;
    }
}

// Approach 2 : Regex
public class CsvRowSplitterRegex
{
    // matches either a quoted field (with "" escapes) or an unquoted field
    private static readonly Regex Pattern = new Regex("(?:^|,)(?:\"(?<quoted>(?:[^\"]|\"\")*)\"|(?<plain>[^,]*))", RegexOptions.Compiled);

    public List<string> Split(string line)
    {
        var fields = new List<string>();
        if (line == null)
            return fields;

        foreach (Match match in Pattern.Matches(line))
        {
            string value = match.Groups["quoted"].Success ? match.Groups["quoted"].Value.Replace("\"\"", "\"") : match.Groups["plain"].Value;
            fields.Add(value);
        }

        return fields;
    }
}```