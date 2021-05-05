using System;
using System.Collections.ObjectModel;
using Prism.Events;
using Prism.Regions;
using XPub.Infrastructure;
using XPub.Infrastructure.Prism.Events;
using XPub.Interfaces.Services.Administration;
using XPub.Models.DataModels;
using XPub.Resources;
using XPub.Resources.Enums;
namespace XPub.Supervisor.JobManagement.Module.ViewModels
{
    /// <summary>
    /// SupervisorJobManagementViewModel object derived from the <see cref="MenuViewModel"/> object.
    /// Supervisor role configure menu view model
    //  Used as view model for view that appears as an item in a menu
    /// </summary>

    public class SupervisorJobManagementViewModel : XPubViewModelBase
    {
        #region Fields

        /// <summary>
        /// _eventAggregator field interface
        /// Event aggregator reference
        /// </summary>
        /// <value>IEventAggregator reference</value>
        private readonly IEventAggregator _eventAggregator;

        /// <summary>
        /// _xpubServiceAdmin field interface
        /// Contains references to administration services
        /// </summary>
        /// <value>IXPubServiceAdmin reference </value>
        private readonly IXPubServiceAdmin _xpubServiceAdmin;
        #endregion

        #region Constructor
        /// <summary>
        /// SupervisorJobManagementViewModel constructor
        /// </summary>
        /// <param name="xpubServiceAdmin">XPub administration service reference</param>

        public SupervisorJobManagementViewModel(IXPubServiceAdmin xpubServiceAdmin
            , IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _xpubServiceAdmin = xpubServiceAdmin;

            InitializeTaskPools();
            InitializeJobs();

        }
        #endregion

        #region Property Accessors

        /// <summary>
        /// TaskPools Property Get / Set Accessor
        /// Contains collection of XPubJobManagementTaskPoolDataModel information fort the Task Pool's grid
        /// </summary>
        private ObservableCollection<XPubJobManagementTaskPoolDataModel> _taskPools;
        public ObservableCollection<XPubJobManagementTaskPoolDataModel> TaskPools
        {
            get { return _taskPools; }
            set
            {
                SetProperty(ref _taskPools, value, XPubResource.PropTaskPools);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// ListBoxCollection Property Get / Set Accessor
        /// Contains collection of XPubJobManagementJobInfoDataModel information fort the Job's grid
        /// </summary>
        private ObservableCollection<XPubJobManagementJobInfoDataModel> _listBoxCollection;
        public ObservableCollection<XPubJobManagementJobInfoDataModel> ListBoxCollection
        {
            get { return _listBoxCollection; }
            set
            {
                SetProperty(ref _listBoxCollection, value,  XPubResource.PropListBoxCollection);
                //ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        #endregion

        /// <summary>
        /// OnNavigatedTooverride method
        /// Called when the view screen is navigate to
        /// </summary>
        /// <param name="navigationContext">Provides access to the navigation URI, and to any parameters that were specified within it or externally..</param>
        /// <remarks> Make sure event aggregation has not been garbage collected before use</remarks>
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            var wt = new Tuple<WaitCursorEnums, XPubWaitCursorDataModel>(WaitCursorEnums.WaitCursorEnd, new XPubWaitCursorDataModel
            {
                ViewAppEnums = ViewEnums.SuperJobManagement,
                WaitCursorEnum = WaitCursorEnums.WaitCursorEnd,
                Message = $"Supervisor job management"
            }); ;
            _eventAggregator.GetEvent<WaitCursorEvent>().Publish(wt);
        }

        #region Utility Methods
        /// <summary>
        /// InitializeTaskPools method
        /// Used to initialize the task pool collection 
        /// </summary>
        private void InitializeTaskPools()
        {
            TaskPools = new ObservableCollection<XPubJobManagementTaskPoolDataModel>();
            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task="Correct OCR Text",
                FileName ="File Q",
                AssingedTo="Associate A",
                TimeInQueue = "29 Minutes",
                Status="Not Started"
            });
            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Correct OCR Text",
                FileName = "File M",
                AssingedTo = "Associate B",
                TimeInQueue = "32 Minutes",
                Status = "In Process"
            });

            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Divide Into Major Sections",
                FileName = "File Q",
                AssingedTo = "Associate A",
                TimeInQueue = "29 Minutes",
                Status = "Not Started"
            });
            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Divide Into Major Sections",
                FileName = "File M",
                AssingedTo = "Associate B",
                TimeInQueue = "32 Minutes",
                Status = "In Process"
            });

            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Structural XML Markup",
                FileName = "File Q",
                AssingedTo = "Associate A",
                TimeInQueue = "29 Minutes",
                Status = "Not Started"
            });
            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Structural XML Markup",
                FileName = "File M",
                AssingedTo = "Associate B",
                TimeInQueue = "32 Minutes",
                Status = "In Process"
            });

            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Semantic XML Markup",
                FileName = "File Q",
                AssingedTo = "Associate A",
                TimeInQueue = "29 Minutes",
                Status = "Not Started"
            });
            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "Semantic XML Markup",
                FileName = "File M",
                AssingedTo = "Associate B",
                TimeInQueue = "32 Minutes",
                Status = "In Process"
            });

            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "XML Validation",
                FileName = "File Q",
                AssingedTo = "Associate A",
                TimeInQueue = "29 Minutes",
                Status = "Not Started"
            });
            TaskPools.Add(new XPubJobManagementTaskPoolDataModel
            {
                Task = "XML Validation",
                FileName = "File M",
                AssingedTo = "Associate B",
                TimeInQueue = "32 Minutes",
                Status = "In Process"
            });
        }

        /// <summary>
        /// InitializeJobs method
        /// Used to initialize the job collection 
        /// </summary>
        private void InitializeJobs()
        {
          ListBoxCollection = new ObservableCollection<XPubJobManagementJobInfoDataModel>();

            var lv = new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = string.Empty,
                SectionStatus = string.Empty,
                SectionTextTable = StaticStings.Section1,
                MarkUpSelectorEnum = MarkUpSelectorEnum.MarkUpState
            };
            lv.Sections = new ObservableCollection<XPubJobManagementJobInfoDataModel>();
            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"SectionOne",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.ProofRead
            });
            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"SectionOne",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.StructuralMarkup
            });
            ListBoxCollection.Add(lv);


            lv = new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = StaticStings.Section2,
                SectionStatus = @"Structure Markup",
                SectionTextTable = StaticStings.Section2,
                MarkUpSelectorEnum = MarkUpSelectorEnum.MarkUpSection
            };

            lv.Sections = new ObservableCollection<XPubJobManagementJobInfoDataModel>();
            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"SectionOne",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.ChangeReview
            });
            ListBoxCollection.Add(lv);



            lv = new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = String.Empty,
                SectionStatus = String.Empty,
                SectionMarkUpStateEnum = MarkUpStateEnum.None,
                SectionTextTable = StaticStings.Section3,
                MarkUpSelectorEnum = MarkUpSelectorEnum.MarkUpSection
            };

            lv.Sections = new ObservableCollection<XPubJobManagementJobInfoDataModel>();
            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"Sec. 1",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.ChangeReview
            });

            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"Sec. 2",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.MarkUp
            });
            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"Sec. 3",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.Proof
            });

            lv.Sections.Add(new XPubJobManagementJobInfoDataModel
            {
                Section = "Section",
                SectionText = @"Sec. 4",
                SectionStatus = @"Structure Markup",
                SectionMarkUpStateEnum = MarkUpStateEnum.Proof
            });
            ListBoxCollection.Add(lv);
        }
        #endregion


    }
}
