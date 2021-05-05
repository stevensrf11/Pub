using System;
using System.Globalization;
using System.Windows.Data;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// IntToCharConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return indicate how many characters are present based on a value parameter's value
    /// </summary>
    public class IntToCharConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Return a string representing how many characters are present based on a value long value
        /// </summary>
        /// <param name="value">number of characters</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>string repenting number of characters</returns>
        /// <remarks>
        /// Should check if value is null
        /// </remarks>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var intVal = (long)value;

            return $"{intVal} chars";
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
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
