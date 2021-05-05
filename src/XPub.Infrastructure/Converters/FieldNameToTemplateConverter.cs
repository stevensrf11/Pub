using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Data;

namespace XPub.Infrastructure.Converters
{
    /// <summary>
    /// FieldNameToTemplateConverter object derived from the <see cref="BindableBase"/> object,
    /// and  the <seealso cref="IValueConverter"/> interface,
    /// Used to return a template for a given grid column filed name
    /// </summary>
    public class FieldNameToTemplateConverter : BindableBase, IValueConverter
    {
        #region Fields
        /// <summary>
        /// static cache field
        /// Dictionary of string  template key value pairs
        /// </summary>
        /// <value>Dictionary<string, object></value>
        static Dictionary<string, object> cache = new Dictionary<string, object>();
        #endregion

        #region Property Accessors
        /// <summary>
        /// TargetTemplateName Property Get Set Accessor
        /// Used to raise notification and set a field's display template
        /// </summary>
        /// <value> string</value>
        string targetTemplateName = null;
        public string TargetTemplateName
        {
            get { return targetTemplateName; }
            set
            {
                targetTemplateName = value;
                RaisePropertiesChanged("TargetTemplateName");
            }
        }
        #endregion

        #region IValueConverter Implementation
        /// <summary>
        /// Called when propagates a value from the binding source to the binding target.
        /// Used set the cache filed values
        /// </summary>
        /// <param name="value">GridColumnBase object</param>
        /// <param name="targetType">The type of the binding target property</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>Dictionary of field name // template key value pairs</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            GridColumnBase column = value as GridColumnBase;
            if (column == null || String.IsNullOrWhiteSpace(column.FieldName))
                return null;
            string fullTemplateName = String.Format("{0}_{1}", column.FieldName, TargetTemplateName);
            if (!cache.ContainsKey(fullTemplateName))
                cache.Add(fullTemplateName, column.TryFindResource(fullTemplateName));
            return cache[fullTemplateName];
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
