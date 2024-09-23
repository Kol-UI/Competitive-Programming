namespace CompetitiveProgramming.Algorithms
{
    public class BasicMaths
    {
        public static double GetBasicOperation(char operation, double value1, double value2)
        {
            switch(operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
                default:
                    break;
            }
            return -1;
        }

        public static int CountOddNumbers(int[] numbers)
        {
            return numbers.Count(n => n % 2 == 1);
        }

        public static bool IsThereAnyEven(int[] array)
        {
            foreach (int element in array)
            {
                if (element % 2 == 0) return true;
            }
            return false;
        }

        public static bool AreValuesAllPositive(int[] array)
        {
            foreach (int element in array)
            {
                if (element <= 0) return false;
            }
            return true;
        }
    }
}