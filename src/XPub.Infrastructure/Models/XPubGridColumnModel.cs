using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.Utils;
using DevExpress.Xpf.Grid;
using DevExpress.XtraGrid;
using System;

namespace XPub.Infrastructure.Models
{
    ///  <summary>
    /// XPubGridColumnModel object derived from the <see cref="BindableBase"/> object
    /// Contains information for a grid column
    /// </summary>
    public class XPubGridColumnModel : BindableBase
    {

        #region Property Get  / Set Accessors

        ///  <summary>
        /// Name Property Get  / Set Accessor
        /// Column Name
        /// </summary>
        /// <value>string</value>
        public string Name { get; set; }

        ///  <summary>
        /// DisplayName Property Get  / Set Accessor
        /// Column DisplayName
        /// </summary>
        /// <value>string</value>
        public string DisplayName { get; set; }


        ///  <summary>
        /// IsGrouped Property Get  / Set Accessor
        /// Determine if column is group with others
        /// </summary>
        /// <value>boolean</value>
        bool isGrouped;
        public bool IsGrouped
        {
            get { return isGrouped; }
            set
            {
                if (isGrouped == value)
                    return;
                isGrouped = value;
                RaisePropertiesChanged("IsGrouped");
            }
        }

        ///  <summary>
        /// Width Property Get  / Set Accessor
        /// Columns GridColumnWidth
        /// </summary>
        /// <value>GridColumnWidth</value>
        GridColumnWidth width = Double.NaN;
        public GridColumnWidth Width
        {
            get { return width; }
            set
            {
                width = value;
                RaisePropertiesChanged("Width");
            }
        }

        ///  <summary>
        /// HorizontalHeaderContentAlignment Property Get  / Set Accessor
        /// Columns header content horizontal alignment 
        /// </summary>
        /// <value>GridColumnWidth</value>
        public System.Windows.HorizontalAlignment HorizontalHeaderContentAlignment
        {
            get;
            set;
        }

        ///  <summary>
        /// AllowFiltering Property Get  / Set Accessor
        /// </summary>
        /// <value>DefaultBoolean</value>
        DefaultBoolean allowFiltering = DefaultBoolean.True;
        public DefaultBoolean AllowFiltering
        {
            get { return allowFiltering; }
            set { allowFiltering = value; }
        }

        ///  <summary>
        /// AllowSorting Property Get  / Set Accessor
        /// Allows a  column to be sorted or not
        /// </summary>
        /// <value>DefaultBoolean</value>
        DefaultBoolean allowSorting = DefaultBoolean.True;
        public DefaultBoolean AllowSorting
        {
            get { return allowSorting; }
            set { allowSorting = value; }
        }

        ///  <summary>
        /// AllowEditing Property Get  / Set Accessor
        /// Allows a  column to be edited or not
        /// </summary>
        /// <value>DefaultBoolean</value>

        public DefaultBoolean AllowEditing { get; set; }

        ///  <summary>
        /// GroupInterval Property Get  / Set Accessor
        /// Specifies how the data rows are combined into groups when the column in grouping mode.
        /// </summary>
        /// <value>ColumnGroupInterval Enumeration value</value>
        public ColumnGroupInterval GroupInterval { get; set; }

        ///  <summary>
        /// FixedWidth Property Get  / Set Accessor
        /// Specifies if a column has a fixed width.
        /// </summary>
        /// <value>boolean</value>
        public bool FixedWidth { get; set; }

        ///  <summary>
        /// Mask Property Get  / Set Accessor
        /// </summary>
        /// <value>string</value>
        public string Mask { get; set; }


        ///  <summary>
        /// SortOrder Property Get  / Set Accessor
        /// Specifies  if a column is sorting and whether sorting is ascending or descending
        /// </summary>
        /// <value>ColumnSortOrder Enumeration value</value>
        ColumnSortOrder sortOrder;
        public ColumnSortOrder SortOrder
        {
            get { return sortOrder; }
            set
            {
                sortOrder = value;
                RaisePropertiesChanged("SortOrder");
            }
        }

        ///  <summary>
        /// Index Property Get  / Set Accessor
        /// Specifies  column's index order in the grid 
        /// </summary>
        /// <value>int</value>
        int index;
        public int Index
        {
            get { return index; }
            set
            {
                index = value;
                RaisePropertiesChanged("Index");
            }
        }

        ///  <summary>
        /// IsVisible Property Get  / Set Accessor
        /// Specifies if combined is visible.
        /// </summary>
        /// <value>boolean</value>
        bool isVisible = true;
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                RaisePropertiesChanged("IsVisible");
            }
        }
        #endregion
    }

}
