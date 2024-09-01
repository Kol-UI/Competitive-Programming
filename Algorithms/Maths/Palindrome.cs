namespace CompetitiveProgramming.Algorithms
{
    public class Palindrome
    {
        #region LC564
        public static string NearestPalindromic(string input)
        {
            long originalNumber = long.Parse(input);
            long smallerPalindrome = GetSmallerPalindrome(originalNumber);
            long largerPalindrome = GetLargerPalindrome(originalNumber);

            return IsCloserToOriginal(originalNumber, smallerPalindrome, largerPalindrome)
                ? smallerPalindrome.ToString()
                : largerPalindrome.ToString();
        }

        private static bool IsCloserToOriginal(long original, long smaller, long larger)
        {
            return original - smaller <= larger - original;
        }

        private static long GetSmallerPalindrome(long number)
        {
            string numberAsString = number.ToString();
            int numberLength = numberAsString.Length;
            long leftHalf = ExtractLeftHalf(numberAsString, numberLength);

            for (long i = leftHalf; i > 0; i--)
            {
                long palindromeCandidate = CreatePalindrome(i, numberLength % 2 == 0);
                if (IsShorterPalindrome(palindromeCandidate, numberLength)) break;
                if (palindromeCandidate < number)
                {
                    return palindromeCandidate;
                }
            }
            return GenerateDefaultSmallerPalindrome(numberLength);
        }

        private static long GetLargerPalindrome(long number)
        {
            string numberAsString = number.ToString();
            int numberLength = numberAsString.Length;
            long leftHalf = ExtractLeftHalf(numberAsString, numberLength);

            for (long i = leftHalf; i <= long.MaxValue; i++)
            {
                long palindromeCandidate = CreatePalindrome(i, numberLength % 2 == 0);
                if (IsLongerPalindrome(palindromeCandidate, numberLength)) break;
                if (palindromeCandidate > number)
                {
                    return palindromeCandidate;
                }
            }
            return GenerateDefaultLargerPalindrome(numberLength);
        }

        private static long CreatePalindrome(long leftHalf, bool isEvenLength)
        {
            long result = leftHalf;
            if (!isEvenLength) leftHalf /= 10;

            return AppendReverseOfLeftHalf(result, leftHalf);
        }

        private static long ExtractLeftHalf(string numberAsString, int numberLength)
        {
            return long.Parse(numberAsString.Substring(0, (numberLength + 1) / 2));
        }

        private static bool IsShorterPalindrome(long palindrome, int originalLength)
        {
            return palindrome.ToString().Length < originalLength;
        }

        private static bool IsLongerPalindrome(long palindrome, int originalLength)
        {
            return palindrome.ToString().Length > originalLength;
        }

        private static long AppendReverseOfLeftHalf(long result, long leftHalf)
        {
            while (leftHalf != 0)
            {
                result = result * 10 + leftHalf % 10;
                leftHalf /= 10;
            }
            return result;
        }

        private static long GenerateDefaultSmallerPalindrome(int length)
        {
            return (long)Math.Pow(10, length - 1) - 1;
        }

        private static long GenerateDefaultLargerPalindrome(int length)
        {
            return (long)Math.Pow(10, length) + 1;
        }
        #endregion
    }
}