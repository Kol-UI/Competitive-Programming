Money Formatter (Culture Aware)
Formats a decimal amount as currency string for a given culture/currency

```cs
public class MoneyFormatter
{
    // Approach 1: CultureInfo - symbol and format from the culture
    public static string FormatByCulture(decimal amount, string cultureName)
    {
        var culture = new CultureInfo(cultureName);
        return amount.ToString("C", culture);
    }

    // Approach 2: explicit currency code via RegionInfo — decouples culture (language/format)
    // from currency (ISO 4217 symbol), useful when they differ (e.g. Swiss French + CHF)
    public static string FormatByCurrencyCode(decimal amount, string cultureName, string isoCurrencyCode)
    {
        var culture = (CultureInfo)new CultureInfo(cultureName).Clone();
        var region = new RegionInfo(cultureName);

        // Override the currency symbol with the ISO code if it differs
        if (!string.Equals(region.ISOCurrencySymbol, isoCurrencyCode, StringComparison.OrdinalIgnoreCase))
        {
            culture.NumberFormat.CurrencySymbol = isoCurrencyCode;
        }

        return amount.ToString("C", culture);
    }

    // Approach 3: custom format — full control over symbol, separator, decimals, and pattern
    public static string FormatCustom(decimal amount, string currencySymbol, string cultureName, int decimalDigits = 2, bool symbolAfter = false)
    {
        var culture = (CultureInfo)new CultureInfo(cultureName).Clone();
        var fmt = culture.NumberFormat;

        fmt.CurrencySymbol = currencySymbol;
        fmt.CurrencyDecimalDigits = decimalDigits;

        // 0 = "$n", 1 = "n$", 2 = "$ n", 3 = "n $"
        fmt.CurrencyPositivePattern = symbolAfter ? 1 : 0;
        fmt.CurrencyNegativePattern = symbolAfter ? 5 : 1; // "(n$)" vs "($n)"

        return amount.ToString("C", culture);
    }
}```