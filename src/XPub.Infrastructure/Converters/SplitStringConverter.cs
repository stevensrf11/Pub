using DevExpress.Data.Helpers;
using System;
using System.Windows.Data;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// SplitStringConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to split a string up into a collection of strings
    /// </summary>
    public class SplitStringConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used to return a collection of string from the value parameter's string value
        /// </summary>
        /// <param name="value">String to split</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Collection of string or null</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value == null ? null : SplitStringHelper.SplitPascalCaseString(value.ToString());
        }

        /// <summary>
        /// Called method propagates a value from the binding target to the binding source
        /// Not Implemented
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter</param>
        /// <returns>NotSupportedException</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        #endregion

    }
}
