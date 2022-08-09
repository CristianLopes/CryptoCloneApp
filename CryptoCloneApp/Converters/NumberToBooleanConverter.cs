using System.Globalization;

namespace CryptoCloneApp.Converters
{
    internal class NumberIsPositiveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !double.TryParse(value.ToString(), out var number))
            {
                return value;
            }


            return number > 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

