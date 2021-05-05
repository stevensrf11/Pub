using System;
using System.Windows.Data;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// ColumnCategoryImageConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return image string based on task categories state
    /// </summary>
    public class ColumnCategoryImageConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used current create an image string based on value task state
        /// </summary>
        /// <param name="value">XPubTaskCategory object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Image string</returns>
        /// <remard> String should be pack format but could not get it to work 
        /// so the image must be places in the corresponding bin directory
        /// </remars>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || !(value is XPubTaskCategory)) return null;
            var category = (XPubTaskCategory)value;
            return String.Format(@"/XPub.Infrastructure;component/Images/Tasks/Category_{0}.svg", category);
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
