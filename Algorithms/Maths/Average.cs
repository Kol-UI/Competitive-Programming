namespace CompetitiveProgramming.Algorithms
{
    public class Average
    {
        public static double GetAverage(double[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }

            double sum = 0.0;
            foreach(double value in array)
            {
                sum += value;
            }
            return sum / array.Length;
        }
    }
}