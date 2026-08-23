// Encode and Decode Strings

Design an algorithm to encode a list of strings to a single string.

The encoded string is then decoded back to the original list of strings.

Please implement encode and decode


Example 1:

Input: ["neet","code","love","you"]

Output:["neet","code","love","you"]


Example 2:

Input: ["we","say",":","yes"]

Output: ["we","say",":","yes"]


Constraints:

0 <= strs.length < 100

0 <= strs[i].length < 200

strs[i] contains only UTF-8 characters.


```cs
public class EncodeAndDecodeStrings
{
    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0) return "";
        StringBuilder stringBuilder = new();
        string delimiter = "#";
        foreach (string str in strs)
        {
            stringBuilder.Append(str.Length);
            stringBuilder.Append(delimiter);
            stringBuilder.Append(str);
        }
        return stringBuilder.ToString();
    }

    public List<string> Decode(string s)
    {
        int len = s.Length;
        List<string> result = new();
        if (string.IsNullOrEmpty(s)) return result;
        int i = 0;
        char delimiter = '#';
        while (i < len)
        {
            int j = i;
            while (s[j] != delimiter) j++;
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            j = i + length;
            result.Add(s.Substring(i, length));
            i = j;
        }
        return result;
    }
}
```


"neet","code","love","you" => "4#neet4#code4#love3#you"
"we","say",":","yes" => "2#we3#say1#:3#yes"