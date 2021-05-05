using System;
using System.Globalization;
using System.Windows.Data;
using XPub.Resources.Enums;
using System.Windows.Media;
using XPub.Infrastructure.Extensions;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// MarkUpStatusToColorConverter object derived from <see cref="IValueConverter"/>
    /// Used to convert a given MarkUpStateEnum value to its corresponding color
    /// </summary>
    public class MarkUpStatusToColorConverter : IValueConverter
    {
        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used convert a markup state enumeration value to its corresponding color value
        /// </summary>
        /// <param name="value">MarkUpStateEnum object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Markup state 's color value or nothing</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MarkUpStateEnum && value != null)
            {
                MarkUpStateEnum status = (MarkUpStateEnum)value;
                if(status== MarkUpStateEnum.None)
                    return Binding.DoNothing;
                var colorString = status.GetDescription();
                var color = new SolidColorBrush(Colors.White);
                if (!string.IsNullOrEmpty(colorString))
                {

                    var clr = System.Drawing.Color.FromName(colorString);
                    color = new SolidColorBrush(Color.FromArgb(clr.A, clr.R, clr.G, clr.B));
                }
                return color;
            }

            return Binding.DoNothing;
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
