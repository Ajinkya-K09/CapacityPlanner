using System;
using System.Globalization;
using System.Windows.Data;

namespace VelocityCalculator.Converter
{
    class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var results = (int)value;
            return results.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return System.Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
