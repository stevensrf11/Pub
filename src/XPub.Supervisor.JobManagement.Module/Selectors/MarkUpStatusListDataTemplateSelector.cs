using System.Windows;
using System.Windows.Controls;
using XPub.Models.DataModels;
using XPub.Resources.Enums;

namespace XPub.Supervisor.JobManagement.Module.Selectors
{
    /// <summary>
    /// MarkUpStatusListDataTemplateSelector object derived from the <see cref="DataTemplateSelector"/> object
    /// Used to determine the data template to used for  grid row  order in the Service grid
    /// </summary>
    public class MarkUpStatusListDataTemplateSelector : DataTemplateSelector
    {
        #region DataTemplateSelector Implementation
        /// <summary>
        /// SelectTemplate override method used to select the DataTemplate used
        /// </summary>
        /// <param name="item">Item's view model</param>
        /// <param name="container">Container of item</param>
        /// <returns>A markup data template or null</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is XPubJobManagementJobInfoDataModel)
            {
                var vmb = item as XPubJobManagementJobInfoDataModel;

                if (vmb.MarkUpSelectorEnum == MarkUpSelectorEnum.MarkUpSection)
                    return element.FindResource("MarkUpSectionTemplate") as DataTemplate;
                else if (vmb.MarkUpSelectorEnum == MarkUpSelectorEnum.MarkUpState)
                    return element.FindResource("MarkUpStateTemplate") as DataTemplate;
            }

            return null;
        }
        #endregion
    }
}
