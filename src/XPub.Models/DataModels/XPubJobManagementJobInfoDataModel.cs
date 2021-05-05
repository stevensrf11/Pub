using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XPub.Resources.Enums;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubJobManagementJobInfoDataModel class derived from <see cref="XPubJobManagementJobDataModel"/>
    /// Provides job status sub section information on a record file
    /// </summary>

    public class XPubJobManagementJobInfoDataModel : XPubJobManagementJobDataModel
    {
        #region Property Accessors
        private MarkUpStateEnum _sectionMarkUpStateEnum = MarkUpStateEnum.Default;
        public MarkUpStateEnum SectionMarkUpStateEnum
        {
            get { return _sectionMarkUpStateEnum; }
            set
            {
                SetProperty(ref _sectionMarkUpStateEnum, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<XPubJobManagementJobInfoDataModel> _sections;
        public ObservableCollection<XPubJobManagementJobInfoDataModel> Sections
        {
            get { return _sections; }
            set
            {
                SetProperty(ref _sections, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion
    }
}
