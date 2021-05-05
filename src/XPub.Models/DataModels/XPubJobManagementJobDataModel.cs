using System;
using System.Collections.Generic;
using System.Text;
using XPub.Resources.Enums;

namespace XPub.Models.DataModels
{
    /// <summary>
    /// XPubJobManagementJobDataModel object derived from <see cref=""/>
    /// Provides job status information on a record file
    /// </summary>
    public class XPubJobManagementJobDataModel : XPubViewModelBase
    {
        #region Property Accessors

        private MarkUpSelectorEnum _markUpSelectorEnum = MarkUpSelectorEnum.None;
        public MarkUpSelectorEnum MarkUpSelectorEnum
        {
            get { return _markUpSelectorEnum; }
            set
            {
                SetProperty(ref _markUpSelectorEnum, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        private string _section;
        public string Section
        {
            get { return _section; }
            set
            {
                SetProperty(ref _section, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        private string _sectionText;
        public string SectionText
        {
            get { return _sectionText; }
            set
            {
                SetProperty(ref _sectionText, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        private string _sectionStatus;
        public string SectionStatus
        {
            get { return _sectionStatus; }
            set
            {
                SetProperty(ref _sectionStatus, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        private string _sectionTextTable;
        public string SectionTextTable
        {
            get { return _sectionTextTable; }
            set
            {
                SetProperty(ref _sectionTextTable, value);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion
    }

}
