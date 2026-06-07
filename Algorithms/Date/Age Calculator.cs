namespace CompetitiveProgramming.Algorithms;
public class AgeCalculator
{
    // Approach 1: Standard logic checking months and days
    public int CalculateAgeStandard(DateTime birthday, DateTime givenDate)
    {
        if (givenDate < birthday)
            throw new ArgumentException("Given date cannot be earlier than the birthday.");

        int age = givenDate.Year - birthday.Year;

        // Decrease age if current month/day is before birthday month/day
        if (givenDate.Month < birthday.Month || (givenDate.Month == birthday.Month && givenDate.Day < birthday.Day))
        {
            age--;
        }

        return age;
    }

    // Approach 2: Integer math trick (YYYYMMDD subtraction)
    public int CalculateAgeMathTrick(DateTime birthday, DateTime givenDate)
    {
        if (givenDate < birthday)
            throw new ArgumentException("Given date cannot be earlier than the birthday.");

        // Convert both dates to an integer representing YYYYMMDD
        int date1 = (givenDate.Year * 10000) + (givenDate.Month * 100) + givenDate.Day;
        int date2 = (birthday.Year * 10000) + (birthday.Month * 100) + birthday.Day;

        // Integer division drops the decimal part automatically
        return (date1 - date2) / 10000;
    }
}