using DevExpress.Xpf.Editors.Settings;
using System;
using System.Windows.Data;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// MaskToTextEditSettingsConverter object derived from the <see cref="IValueConverter"/> interface,
    /// Used to return text edit settings based on   the value parameter's sting task mask value
    /// </summary>
    public class MaskToTextEditSettingsConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Return text edit settings based on  a text string mask value
        /// </summary>
        /// <param name="value">Text mask string</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>TextEditSettings object or null</returns>
        /// </remarks>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string mask = value as string;
            if (value == null)
                return null;
            return new TextEditSettings { Mask = mask, MaskUseAsDisplayFormat = true, MaskType = DevExpress.Xpf.Editors.MaskType.RegEx };
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
            throw new NotImplementedException();
        }
        #endregion

    }
}
