
using System.Text;

namespace CompetitiveProgramming.Helpers.Converters;
public class JaggedArrayToStringConverter
{
    public static string JaggedArrayToString(Array? array)
    {
        if (array == null)
        {
            return string.Empty;
        }
        StringBuilder sb = new();
        void ProcessArray(Array array)
        {
            foreach (var item in array)
            {
                if (item is Array innerArray)
                {
                    ProcessArray(innerArray);
                }
                else
                {
                    sb.Append(item).Append(", ");
                }
            }
        }
        ProcessArray(array);
        return sb.ToString().TrimEnd(' ', ',');
    }
}