using System;
using System.Globalization;
using System.Windows.Data;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// FileLengthToCharConverter object derived from the <see cref="BaseValueConverter"/> object,
    /// Used to a string which represents how many characters are in a file
    /// </summary>
    public class FileLengthToCharConverter : BaseValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used return a string which indicated how many characters are based on the value parameter's value
        /// </summary>
        /// <param name="value">Number of characters</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>string</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            return $"{value} chars";
        }

        /// <summary>
        /// Called method propagates a value from the binding target to the binding source
        /// Not Implemented
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter</param>
        /// <returns>Nothing</returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
        #endregion

    }
}
