Check File Integrity (MD5/SHA)

```cs
// Simulates file integrity checking using plain strings

public class FileIntegrityChecker
{
    // Approach 1: compute hash from a string content using a built-in algorithm
    public static string ComputeHash(string content, string algorithm)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(content);
        using HashAlgorithm hasher = CreateHasher(algorithm);
        byte[] hashBytes = hasher.ComputeHash(bytes);
        return Convert.ToHexString(hashBytes).ToLowerInvariant();
    }

    // Compare computed hash with the expected one (case insensitive)
    public static bool VerifyIntegrity(string content, string expectedHash, string algorithm)
    {
        string actualHash = ComputeHash(content, algorithm);
        return string.Equals(actualHash, expectedHash, StringComparison.OrdinalIgnoreCase);
    }

    private static HashAlgorithm CreateHasher(string algorithm)
    {
        return algorithm.ToUpperInvariant() switch
        {
            "MD5" => MD5.Create(),
            "SHA1" => SHA1.Create(),
            "SHA256" => SHA256.Create(),
            _ => throw new ArgumentException($"Unsupported algorithm: {algorithm}")
        };
    }

    // Approach 2: Rabin-Karp pattern
    // hash = hash * 31 + charCode, wrapped on 32 bits, formatted as 8-char hex
    public static string ComputeSimpleHash(string content)
    {
        uint hash = 0;
        foreach (char c in content)
        {
            unchecked
            {
                hash = hash * 31 + c;
            }
        }
        return hash.ToString("x8");
    }

    public static bool VerifySimpleHash(string content, string expectedHash)
    {
        string actualHash = ComputeSimpleHash(content);
        return string.Equals(actualHash, expectedHash, StringComparison.OrdinalIgnoreCase);
    }
}```