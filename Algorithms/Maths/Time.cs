namespace CompetitiveProgramming.Algorithms.Maths
{
    public class Time
    {
        #region CF 1283A
        public static int CalculateMinutesBeforeNewYear(int hours, int minutes)
        {
            int totalMinutesInDay = 24 * 60;
            int currentMinutes = ConvertToMinutes(hours, minutes);
            return totalMinutesInDay - currentMinutes;
        }

        public static int ConvertToMinutes(int hours, int minutes)
        {
            return hours * 60 + minutes;
        }
        #endregion
    }
}