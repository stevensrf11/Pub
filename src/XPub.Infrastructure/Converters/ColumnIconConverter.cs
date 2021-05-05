using DevExpress.Xpf.Core;
using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// ColumnIconConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return image source based on value parameter' indicator state
    /// </summary>
    public class ColumnIconConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used current create an image source based on value parameter' indicator state
        /// </summary>
        /// <param name="value">indicator's state</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Image source</returns>
        /// <remard> String should be pack format but could not get it to work 
        /// so the image must be places in the corresponding bin directory
        /// </remars>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || !(value is int)) return null;
            int intValue = (int)value;
            var extension = new SvgImageSourceExtension() { Uri = new Uri(string.Format(@"/XPub.Infrastructure;component/Images/Tasks/Status_{0}.svg", intValue), UriKind.RelativeOrAbsolute), Size = new Size(16, 16) };
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


