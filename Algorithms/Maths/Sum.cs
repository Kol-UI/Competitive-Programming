namespace CompetitiveProgramming.Algorithms
{
    public class Sum
    {
        #region LC1945
        // "123" => 1+2+3 return 6
        public static int SumOfDigits(string numericString)
        {
            int sum = 0;
            foreach (char digit in numericString)
            {
                sum += digit - '0';
            }
            return sum;
        }
        #endregion

        // Addition
        public static int CalculateArithmeticProgression(int firstTerm, int commonDifference, int numberOfTerms)
        {
            int lastTerm = firstTerm + (numberOfTerms - 1) * commonDifference;

            int sum = (numberOfTerms * (firstTerm + lastTerm)) / 2;

            return sum;
        }

        // Multiplication
        public static double CalculateGeometricProgression(double firstTerm, double commonRatio, int numberOfTerms)
        {
            if (commonRatio == 1)
            {
                return firstTerm * numberOfTerms;
            }
            
            double sum = firstTerm * (1 - Math.Pow(commonRatio, numberOfTerms)) / (1 - commonRatio);
            return sum;
        }

        public static double CalculateHarmonicSum(int numberOfTerms)
        {
            double harmonicSum = 0.0;

            for (int i = 1; i <= numberOfTerms; i++)
            {
                harmonicSum += 1.0 / i;
            }

            return harmonicSum;
        }
    }
}