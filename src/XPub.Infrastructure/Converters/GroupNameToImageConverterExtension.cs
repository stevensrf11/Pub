using System;
using System.Collections.Generic;
using System.Globalization;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// GroupNameToImageConverterExtension object derived from the <see cref="BaseValueConverter"/> object,
    /// Used to convert group name to a corresponding image string 
    /// </summary>
    public class GroupNameToImageConverterExtension : BaseValueConverter
    {
        #region Fields
        public static List<string> images = new List<string> { "congressional", "federal", "bills" };
        #endregion

        #region Property Accessors
        /// <summary>
        /// GetImagePathByGroupName Get accessor perpetuity
        /// Used to return a group name image string based on the group name parameter
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns> group name image string </returns>
        /// <remarks> String should be pack format but could not get it to work 
        /// so the image must be places in the corresponding bin directory
        public static string GetImagePathByGroupName(string groupName)
        {
            groupName = groupName.ToLowerInvariant();
            foreach (string item in images)
            {
                if (groupName.Contains(item))
                {
                    return "pack://siteoforigin:,,,/Images/GroupName/" + item + ".svg";
                }
            }
            return groupName;
        }
        #endregion

        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used great a group name image string based on the value's parameter
        /// </summary>
        /// <param name="value">Group name string</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Group name image string or null</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            return GetImagePathByGroupName((string)value);
        }
        #endregion
    }
}
