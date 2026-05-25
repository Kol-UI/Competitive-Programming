namespace CompetitiveProgramming.Algorithms;

public class ManualInverseCase
{
    public static string ToInverseCaseManual(string input)
    {
        if (string.IsNullOrEmpty(input)) return input ?? string.Empty;

        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];

            // if upper (A-Z)
            if (c >= 65 && c <= 90)
            {
                chars[i] = (char)(c + 32); // becomes lower
            }
            // if lower (a-z)
            else if (c >= 97 && c <= 122)
            {
                chars[i] = (char)(c - 32); // becomes upper
            }
            // else (digit, space, ponctuation), no changes
        }

        return new string(chars);
    }
	
	// Bitwise Approach
	public static string ToInverseCaseBitwise(string input)
    {
        if (string.IsNullOrEmpty(input)) return input ?? string.Empty;

        char[] buffer = input.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char c = buffer[i];

            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            {
                // XOR operator inverse
                buffer[i] = (char)(c ^ 32);
            }
        }

        return new string(buffer);
    }
}