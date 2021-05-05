using DevExpress.Xpf.Core;
using System;
using System.Windows.Data;
using System.Windows.Media;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// ColumnFlagStatusImageConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return image source based on flag  state
    /// </summary>
    public class ColumnFlagStatusImageConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used image source based on value parameter's flag state
        /// </summary>
        /// <param name="value">XPubFlagStatus object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Image source</returns>
        /// <remarks> String should be pack format but could not get it to work 
        /// so the image must be places in the corresponding bin directory
        /// </remarks>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || !(value is XPubFlagStatus)) return null;
            var status = (XPubFlagStatus)value;
            var extension = new SvgImageSourceExtension() { Uri = new Uri(String.Format(@"/XPub.Infrastructure;component/Images/Tasks/{0}.svg", status), UriKind.RelativeOrAbsolute), Size = new System.Windows.Size(16, 16) };
            return (ImageSource)extension.ProvideValue(null);
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
