
using System.Text;

namespace CompetitiveProgramming.Helpers.Converters;
public class ArrayToStringConverter
{
    public static string ArrayToString<T>(T array)
    {
        if (array == null)
        {
            return string.Empty;
        }
        if (array is Array)
        {
            // Convert array to string
            StringBuilder sb = new();

            foreach (var item in (array as Array)!)
            {
                sb.Append(ArrayToString(item));
                sb.Append(", ");
            }
            
            if (sb.Length > 0)
            {
                sb.Length -= 2;
            }

            sb.Insert(0, "{ ");
            sb.Append(" }");
            
            return sb.ToString();
        }
        else
        {
            // Convert non-array type to string
            return array.ToString()!;
        }
    }
}