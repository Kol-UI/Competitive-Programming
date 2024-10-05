namespace CompetitiveProgramming.Algorithms
{
    public class CharManipulation
    {
        public static bool ContainsDigit(List<char> charList)
        {
            return charList.Any(c => char.IsDigit(c));
        }
    }
}