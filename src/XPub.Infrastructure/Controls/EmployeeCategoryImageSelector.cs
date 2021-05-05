using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Text;
using XPub.Models.DataModels;
using System.Windows.Media;
using DevExpress.Xpf.Core;
using XPub.Infrastructure.Converters;

namespace XPub.Infrastructure.Controls
{
    public class EmployeeCategoryImageSelector : TreeListNodeImageSelector
    {
        public override ImageSource Select(DevExpress.Xpf.Grid.TreeList.TreeListRowData rowData)
        {
            var empl = (rowData.Row as XPubEmployeeDataModel);
            if (empl == null || string.IsNullOrEmpty(empl.Role))
                return null;
            var extension = new SvgImageSourceExtension() { Uri = new Uri(RoleToImageConverterExtension.GetImagePathByGroupName(empl.Role)), Size = new System.Windows.Size(16, 16) };
            return (ImageSource)extension.ProvideValue(null);

        }
    }
}
