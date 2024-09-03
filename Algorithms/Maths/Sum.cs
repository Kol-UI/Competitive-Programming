namespace CompetitiveProgramming.Algorithms
{
    public class Sum
    {
        #region LC1945
        // "123" => 1+2+3 return 6
        private static int SumOfDigits(string numericString)
        {
            int sum = 0;
            foreach (char digit in numericString)
            {
                sum += digit - '0';
            }
            return sum;
        }
        #endregion
    }
}