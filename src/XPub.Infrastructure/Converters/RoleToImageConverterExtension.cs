using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using XPub.Infrastructure.Controls;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// RoleToImageConverterExtension object derived from the <see cref="BaseValueConverter"/> object,
    /// Used to return image string based on a role
    /// </summary>
    public class RoleToImageConverterExtension : BaseValueConverter
    {
        #region Fields
        /// <summary>
        /// images field
        /// Collection of roles
        /// </summary>
        /// <value> List of string</value>
        public static List<string> images = new List<string> { "employee", "administration", "supervisor" };
        #endregion



        #region Property Accessor
        /// <summary>
        /// GetImagePathByGroupName Property Get Accessor
        /// Returns the image string name for a role based on the role name parameter value
        /// </summary>
        /// <param name="groupName"> Role name</param>
        /// <returns>Image string</returns>
         /// <remarks> String should be pack format but could not get it to work 
        /// so the image must be places in the corresponding bin directory
        /// </remarks>
        public static string GetImagePathByGroupName(string groupName)
        {
            groupName = groupName.ToLowerInvariant();
            foreach (string item in images)
            {
                if (groupName.Contains(item))
                {
                    return "pack://siteoforigin:,,,/Images/CellImages/" + item + ".svg";
                }
            }
            return groupName;
        }
        #endregion

        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used  to return  image string name for a role based value parameter's string value
        /// </summary>
        /// <param name="value">XPubFlagStatus object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Image source</returns>
       public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            return GetImagePathByGroupName((string)value);
        }
        #endregion
    }
}
