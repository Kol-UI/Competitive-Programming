
namespace CompetitiveProgramming.Helpers.Converters
{
    public class CharIsVowelConverter
    {
        public static bool IsVowel(char c)
        {
            return (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u');
        }
    }
}