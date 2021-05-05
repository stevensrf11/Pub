using System;
using System.Collections.Generic;
using XPub.Infrastructure;
using System.Windows.Media;
using Prism.Regions;
using XPub.Resources.Enums;
using XPub.Models.DataModels;
using XPub.Infrastructure.Prism.Events;
using Prism.Events;
using DevExpress.Mvvm;
using XPub.Infrastructure.Modules;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace XPub.Employee.AssignedWork.Module.ViewModels
{
    /// <summary>
    /// EmployeeAssignedWorkViewModel object derived from the <see cref="XPubViewModelBase"/> object
    /// View model for the employee assigned tasks
    /// </summary>
    public class EmployeeAssignedWorkViewModel : XPubViewModelBase
    {
        #region Fields
        /// <summary>
        /// _eventAggregator field interface
        /// Provides multicast publish/subscribe functionality.
        /// </summary>
        /// <value>
        /// IEventAggregator reference
        /// </value>
        private readonly IEventAggregator _eventAggregator;


        #endregion

        #region Property  Accessors
        /// <summary>
        /// CurrentWindowService Get Accessor Property
        /// Provides current window services
        /// </summary>
        /// <value>
        /// ICurrentWindowService reference
        /// </value>
        /// <remarks> Is this service  used</remarks>
        [Required]
        protected virtual ICurrentWindowService CurrentWindowService { get { return null; } }

        /// <summary>
        /// ApplicationJumpListService Get Accessor Property
        /// Provides jump list services  
        /// Allows addition of your own items to the Window's jump list
        /// </summary>
        /// <value>
        /// IApplicationJumpListService reference
        /// </value>
        /// <remarks> Is this service  used</remarks>
        [Required]
        protected virtual IApplicationJumpListService ApplicationJumpListService { get { return null; } }

        /// <summary>
        /// NavigationService Get Accessor Property
        /// Provides navigational  services
        /// </summary>
        /// <value>
        /// INavigationService reference
        /// </value>
        /// <remarks> Is this service  used</remarks>
        [Required]
        protected virtual INavigationService NavigationService { get { return null; } }

        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// Derived class property
        /// </remarks>
        ///public string Title { get; private set; }

        /// <summary>
        /// Icon Get / Set Accessor Property
        /// Used to set Icon for menu selection
        /// </summary>
        /// <value>
        /// ImageSource object
        /// </value>
        public virtual ImageSource Icon { get; set; }


        /// <summary>
        /// SelectedModuleInfo Get / Set Accessor Property
        /// Selected navigational module
        /// </summary>
        /// <value>
        ///  IXPubModuleInfo reference
        /// </value>
        public virtual XPubModuleInfo SelectedModuleInfo { get; set; }

        /// <summary>
        /// Virtual CanShowSplashScreen Get / Set Accessor Property
        /// Indicates whether or not show a splash screen
        /// </summary>
        /// <value>
        /// boolean
        /// </value>
        public virtual bool CanShowSplashScreen { get; set; }

        /// <summary>
        /// Modules Get / Set Accessor Property
        /// Collection navigation modules
        /// </summary>
        /// <value>
        /// Collection of IXPubModuleInfo references
        /// </value>
        public virtual IEnumerable<XPubModuleInfo> Modules { get; protected set; }

        /// <summary>
        /// ModulesLoadedCommand Get  Accessor Property
        /// Command object for loading module information
        /// </summary>
        /// <value>
        /// ICommand reference
        /// </value>
        /// <remarks> Is this service  used</remarks>
        public ICommand ModulesLoadedCommand { get; private set; }
       
        #endregion

        #region Constructor
        /// <summary>
        /// Parameterized  Constructor
        /// </summary>
        /// <param name="eventAggregator"> Publisher  subscriber reference</param>
        public EmployeeAssignedWorkViewModel(IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
          //  CanShowSplashScreen = false;
          // Modules = new List<XPubModuleInfo>() {
          //      ViewModelSource.Create(() => new XPubModuleInfo("XPubGridTasksModule", this, "Grid: Tasks")).SetIcon("GridTasks"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("GridContactsModule", this, "Grid: Contacts")).SetIcon("GridContacts"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("SpreadsheetModule", this, "Spreadsheet")).SetIcon("Spreadsheet"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("RichEditModule", this, "Word Processing")).SetIcon("WordProcessing"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("ReportsModule", this, "Banded Reports")).SetIcon("BandedReports"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("PivotGridModule", this, "Pivot Table")).SetIcon("Pivot"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("SalesDashboard", this, "Analytics")).SetIcon("Analytics"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("PhotoGallery", this, "Photo Gallery Map")).SetIcon("WeatherMap"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("SchedulerModule", this, "Scheduler")).SetIcon("Scheduler"),
          //  //    ViewModelSource.Create(() => new ModuleInfo("PdfViewerDemo", this, "Pdf Viewer")).SetIcon("PDFViewer")
          //  };
          //MetadataLocator.Default = MetadataLocator.Create().AddMetadata<PrefixEnumWithExternalMetadata>();
        }
        #endregion





        #region ViewModelBase Navigation Implementation
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
                ViewAppEnums = ViewEnums.AdminEmployee,
                WaitCursorEnum = WaitCursorEnums.WaitCursorEnd,
                Message = $"Employee Assigned Work"
            }); ;

            _eventAggregator.GetEvent<WaitCursorEvent>().Publish(wt);
            #endregion

        }



    }
}
