using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using XPub.Resources.Enums;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// TaskStatusCompletedConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to determine if a task is int he completed state
    /// </summary>
    public class TaskStatusCompletedConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Determines if a task is in the completed state based on the value parameter's task status value
        /// </summary>
        /// <param name="value">XPubTaskStatus object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>boolean , true if completed state< flase otherwise/returns>
        /// </remarks>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is XPubTaskStatus)) return false;
            var status = (XPubTaskStatus)value;
            return status == XPubTaskStatus.Completed;
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
            throw new NotSupportedException();
        }
        #endregion
    }
}
