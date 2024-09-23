namespace CompetitiveProgramming.Algorithms
{
    public class UniversalQuantifier
    {
        public static bool AreValuesAllPositive(int[] array)
        {
            foreach (int element in array)
            {
                if (element <= 0) return false;
            }
            return true;
        }

        public static bool AllNumbersAreEven(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool AllNumbersAreOdd(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool AllWordsStartWithUppercase(string[] words)
        {
            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word) || !char.IsUpper(word[0]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}