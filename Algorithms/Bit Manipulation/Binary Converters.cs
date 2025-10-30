namespace CompetitiveProgramming.Algorithms;
public class BinaryConverters
{
	// Decimal Base 2
	// Binary Base 10
	// Convert Decimal to Binary
	// 10 => "1010"
	// 42 => "101010"
	public static string DecimalToBinary(string decimalString)
	{
		try
		{
			int decimalNumber = Convert.ToInt32(decimalString);
			return Convert.ToString(decimalNumber, 2);
		}
		catch (FormatException)
		{
			return $"Error : '{decimalString}' format not valid.";
		}
		catch (Exception ex)
		{
			return $"Error : {ex.Message}";
		}
	}

	// Convert Binary to Decimal
	// "1010" => 10
	// "101010" => 42
	public static int BinaryToDecimal(string binaryString)
	{
		if (!IsBinaryOnly(binaryString))
		{
			Console.WriteLine($"Error : '{binaryString}' has invalid characters."); return -1;
		}
		try { return Convert.ToInt32(binaryString, 2); }
		catch (OverflowException)
		{
			Console.WriteLine($"Error : '{binaryString}' is too high for int."); return -1;
		}
	}

	// Check if there are only '1' and '0'
	private static bool IsBinaryOnly(string s)
	{
		return !string.IsNullOrEmpty(s) && s.All(c => c == '0' || c == '1');
	}
	
	// Binary to value (chooses Full or Short based on binary length)
	public static string BinaryToValue(string bitsValue) => FullBinaryRepresentation.IsLongBinary(bitsValue) ? FullBinaryRepresentation.FullBinaryToValue(bitsValue) : ShortBinaryRepresentation.ShortBinaryToValue(bitsValue);

	// Value to binary (chooses Full or Short based on value range)
	public static string ValueToBinary(long value) => FullBinaryRepresentation.IsLongValue(value) ? FullBinaryRepresentation.ValueToFullBinary(value) : ShortBinaryRepresentation.ValueToShortBinary(value);

	// "00000000000000000000000000010111" => 0b_00000000_00000000_00000000_00010111
	public static uint BinaryStringToUint32(string binary) => Convert.ToUInt32(binary, 2);
}