using System;
using System.Windows.Data;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// ItemTypeToBooleanConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return whether a new item type has been specified 
    /// </summary>

    public class ItemTypeToBooleanConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used to return a boolean to indicate  whether a new item type has been specified based on the value's string value
        /// </summary>
        /// <param name="value">Item type string</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>boolean/returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string itemType = parameter as string;
            string newValue = value as string;
            if (itemType == null || value == null)
                return false;
            return itemType == newValue;
        }
        /// <summary>
        /// Called method propagates a value from the binding target to the binding source
        /// Return the item type sting value based on if the value parameter's boolean is true
        /// </summary>
        /// <param name="value">Indicator where item type is new</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">Item type string.</param>
        /// <param name="culture">The culture to use in the converter</param>
        /// <returns>item type string or nothing</returns>

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value)
                return parameter;
            return Binding.DoNothing;
        }
        #endregion
    }
}
