using System;
using System.Globalization;
using System.Windows.Data;
using DevExpress.Utils;
namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// ImageConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return Uri resource based on value parameter's string value 
    /// </summary>

    public class ImageConverter : IValueConverter
    {

        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used to return Uri resource based on value''s string value 
        /// </summary>
        /// <param name="value">XPubFlagStatus object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Uri</returns>
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return AssemblyHelper.GetResourceUri(typeof(ImageConverter).Assembly, value.ToString());
            return null;
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
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
