namespace CompetitiveProgramming.Algorithms
{
    public class ExistentialQuantifier
    {
        public static bool IsThereAnyEven(int[] array)
        {
            foreach (int element in array)
            {
                if (element % 2 == 0) return true;
            }
            return false;
        }

        public static bool IsThereAnyOdd(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsThereAnyLongWord(string[] words, int size)
        {
            foreach (string word in words)
            {
                if (word.Length > size)
                {
                    return true;
                }
            }
            return false;
        }
    }
}