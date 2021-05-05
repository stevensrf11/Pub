using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using XPub.Infrastructure.Controls;

namespace XPub.Infrastructure.Converters
{

    /// <summary>
    /// BooleanToVisibilityConverter object derived from the <see cref="BaseValueConverter"/> object,
    /// Used to convert boolean to visibility  state and visa versa
    /// </summary>
    public class BooleanToVisibilityConverter : BaseValueConverter
    {
        #region Property Accessors
        /// <summary>
        /// Invert Property Get Set Accessor
        /// Sets viability state
        /// </summary>
        /// <value> boolean</value>
        public bool Invert { get; set; }
        #endregion

        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used current value parameter, the Invert property, and the string parameter to determine the
        /// Visibility state to return
        /// </summary>
        /// <param name="value">The value produced by the binding source</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Visibility state</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility collapsed = Visibility.Collapsed;
            if ((parameter is string) && (((string)parameter) == "HiddenOnFalse"))
            {
                collapsed = Visibility.Hidden;
            }
            if ((value != null) && ((bool)value))
            {
                return (this.Invert ? ((object)collapsed) : ((object)0));
            }
            return (this.Invert ? ((object)0) : ((object)collapsed));
        }

        /// <summary>
        /// Called method propagates a value from the binding target to the binding source
        /// Return Inverted property value based on the value parameter's viability state
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter</param>
        /// <returns>boolean</returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            if (visibility == Visibility.Collapsed)
            {
                return this.Invert;
            }
            return !this.Invert;
        }
        #endregion



    }
}
