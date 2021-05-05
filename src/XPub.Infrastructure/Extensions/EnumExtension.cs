using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace XPub.Infrastructure.Extensions
{
    /// <summary>
    /// EnumExtension object
    /// Extends an enumeration object
    /// </summary>
    public static class EnumExtension
    {
        #region Public Extension Methods
        /// <summary>
        /// GetDescription<T> extension method
        /// Returns an enumeration's DescriptionAttribute's value
        /// </summary>
        /// <typeparam name="T">Enumeration Type</typeparam>
        /// <param name="e">Enumeration value</param>
        /// <returns>
        /// Enumeration  DescriptionAttribute string value
        /// Otherwise empty string
        /// </returns>
        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descriptionAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() as DescriptionAttribute;

                        if (descriptionAttribute != null)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }

            return string.Empty; // could also return string.Empty
        }
        #endregion
    }

}
