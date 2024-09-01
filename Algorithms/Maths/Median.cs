namespace CompetitiveProgramming.Algorithms
{
    public class Median
    {
        #region LC4
        private static List<int> SortList(List<int> numbers)
        {
            numbers.Sort();
            return numbers;
        }

        private static double FindMedian(List<int> sortedNumbers)
        {
            int count = sortedNumbers.Count;

            if (count == 0)
            {
                throw new InvalidOperationException("Cannot find median of an empty list.");
            }

            if (IsOddOrEven(count))
            {
                return GetMiddleElementInEvenList(sortedNumbers);
            }
            else
            {
                int mid1 = sortedNumbers[(count / 2) - 1];
                int mid2 = sortedNumbers[count / 2];
                return GetAverage(new List<int> { mid1, mid2 });
            }
        }

        private static bool IsOddOrEven(int value)
        {
            if (value % 2 == 1)
                return true;
            else
                return false;
        }

        private static int GetMiddleElementInEvenList(List<int> list)
        {
            return list[list.Count / 2];
        }

        private static double GetAverage(List<int> ints)
        {
            int sum = 0;
            foreach (int number in ints)
            {
                sum += number;
            }
            return (double)sum / ints.Count;
        }
        #endregion
    }
}