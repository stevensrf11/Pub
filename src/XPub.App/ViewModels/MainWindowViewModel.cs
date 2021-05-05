using XPub.Infrastructure;
using Prism.Regions;
using XPub.Infrastructure.Commands;
using Prism.Events;
using Prism.Commands;
using XPub.Infrastructure.Prism.Events;
using XPub.Resources.Enums;
using System;
using XPub.Models.DataModels;
using dvvm = DevExpress.Mvvm;
using XPub.Resources;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using System.Windows;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.DataAnnotations;

namespace XPub.App.ViewModels
{

    /// <summary>
    /// MainWindowViewModel ibhect derived fron the  XPubViewModelBase
    /// View model for the main windows of the application  . 
    /// </summary>
    [POCOViewModel]
    public class MainWindowViewModel : XPubViewModelBase
    {
        #region Fields
        /// <summary>
        /// IRegionManager reference field
        /// Defines an interface to manage a set of regions and to attach regions to objects (typically controls).
        /// </summary>
        /// <value>IRegionManager</value>
        private readonly IRegionManager _regionManager;

        /// <summary>
        /// Eventaggregator reference field
        /// Defines an interface to get instances of an event type.
        /// </summary>
        /// <value>IEventAggregator</value>
        private readonly IEventAggregator _eventAggregator;
        #endregion      
        

        #region Property Accessors

        /// <summary>
        /// SplashScreenManager Proerty Get Accessor
        /// SpashScrrenManager service used to provide a wait cutrsor that is rann on a background thread
        /// </summary>
        /// <value>ISplashScreenManagerService reference</value>
        public ISplashScreenManagerService SplashScreenManager { get { return GetService<ISplashScreenManagerService>(); } }

        /// <summary>
        /// CurrentWindow Proerty Get Accessor
        /// CurrentWindowService service used to provide reference to corresponding view
        /// </summary>
        /// <value>ISplashScreenManagerService reference</value>

        public ICurrentWindowService CurrentWindow { get { return GetService<ICurrentWindowService>(); } }



        /// <summary>
        /// SplashScreenService Proerty Get Accessor
        /// SplashScreenService used service used to provide a wait cutrsor that is rann on a background thread
        /// </summary>
        /// <value>ISplashScreenManagerService reference</value>

        protected ISplashScreenService SplashScreenService { get { return ServiceContainer.GetService<ISplashScreenService>(); } }


        /// <summary>
        /// SplashContentGt Property Ge Accessor
        /// Kabek content used in splash manager service
        /// </summary>
        /// <string></string>
        public string _splashContent = "Splash Content";
        public string SplashContent
        {
            get { return _splashContent; }

        }

        /// <summary>
        /// NavigateCommand delegate command used for navigation to a view 
        //
        /// </summary>
        /// <value> PRISM DelegateCommand </value>
        /// <remarks> Note there is no CanExecute event handler</remarks> 
        private Prism.Commands.DelegateCommand<string> _navigateCommand;
        public Prism.Commands.DelegateCommand<string> NavigateCommand => _navigateCommand ?? (_navigateCommand = new Prism.Commands.DelegateCommand<string>(ExecuteNavigateCommand));

        /// <summary>
        /// ItemClickCommand delegate command
        /// </summary>
        /// <value> PRISM DelegateCommand </value>
        /// <remarks> Note there is no CanExecute event handler</remarks> 
        private Prism.Commands.DelegateCommand _itemClickCommand;
        public Prism.Commands.DelegateCommand ItemClickCommand => _itemClickCommand ?? (_itemClickCommand = new Prism.Commands.DelegateCommand(ExecuteItemClickCommand));

        /// <summary>
        /// IsBusy Property Get  Set Accessor
        /// Used to indicate navigaton to a view is in progress
        /// </summary>
        /// <value> bool </value>
        /// <remarks> May not be in uses</remarks>
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value, XPubResource.PropIsBusy); }
        }
        #endregion

        /// <summary>
        /// WaitIndicatorContent Set / Get Priority Acessor
        /// Ued as the wait currosr message content
        /// </summary>
        /// <value>sring</value>
        private string _waitIndicatorContent = "Loading View";
        public string WaitIndicatorContent
        {
            get { return _waitIndicatorContent; }
            set { SetProperty(ref _waitIndicatorContent, value, XPubResource.PropWaitIndicatorContent); }
        }


        #region Constructors
        /// <summary>
        ///MainWindowViewModel's parameterized constructor
        /// </summary>
        /// <param name="regionManager">Region Manager</param>
        /// <param name="applicationCommands">Application commands</param>
        /// <param name="eventAggregator">EventAggregator</param>
        public MainWindowViewModel(IRegionManager regionManager
            , IApplicationCommands applicationCommands
            , IEventAggregator eventAggregator)

        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
            CompositeCommands.NavigateCommand.RegisterCommand(NavigateCommand);
            Title = "Prism Application";

            // Subscribe to the navigation event
            // Note this is a weak reference so either need to regisiter for a string refernce
            // ot otherise verify the eventaggregator has not been garbage collected
            _eventAggregator.GetEvent<WaitCursorEvent>().Subscribe(WaitCursorEventHandler, ThreadOption.UIThread);

        }
        #endregion


        #region PRISM Delegate Commands Implementation
        /// <summary>
        /// Navigate execute event handler
        /// </summary>
        /// <param name="navigationPath">Navigation path</param>
        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrWhiteSpace(navigationPath))
                return;

            if (!string.IsNullOrWhiteSpace(navigationPath))
            {
                //WaitCursorEnums indicator not being shown
                IsBusy = true;
                ShowSplashScreen(true);
                //Thread.Sleep(3000);
                _regionManager.RequestNavigate(RegionNames.ContentRegionAccordion, navigationPath);
            }
        }

        /// <summary>
        /// WaitCursorEventHandler method
        /// Event handler that is called when navigation is complted
        /// </summary>
        /// <param name="waitCursor">Information which contains on what object called the event handler</param>
        private void WaitCursorEventHandler(Tuple<WaitCursorEnums, XPubWaitCursorDataModel> waitCursor)
        {
            IsBusy = false;
            ShowSplashScreen(false);
            // Do some stuff with the parameter here
        }



        /// <summary>
        /// Item clicked exeuted command handler
        /// Handles the accordion subitem clicka
        /// </summary>
        public void ExecuteItemClickCommand()
        {
            //SplashScreenService.ShowSplashScreen();
        }
        #endregion

        #region Utility Method
        /// <summary>
        /// ShowSplashScreen method
        /// Used to show and hide a wait cursor via using a splash screen
        /// Primarily used during navigation
        /// </summary>
        /// <param name="show">Determine whether to hid or show the wait cursor</param>
        /// <remarks>
        /// A time limit need to be applied to allow a timepan the wait cursor can be applied
        /// </remarks>
        protected void ShowSplashScreen(bool show)
        {
            bool isFluent = false;
            var viewModel = new DXSplashScreenViewModel()
            {
                Logo = new Uri(@"pack://application:,,,/DevExpress.Xpf.DemoBase.v20.1;component/DemoLauncher/Images/Logo.svg"),
                Status = "Starting...",
                Title = isFluent ? "Fluent Splash Screen" : "Themed Splash Screen",
                Subtitle = "",
                
                IsIndeterminate = isFluent
            };

            var ssS = SplashScreenManager ;

            var ccC = CurrentWindow;


            var ss = ssS as SplashScreenManagerService;

            var cc = ccC as CurrentWindowService;
            ss.PredefinedSplashScreenType = PredefinedSplashScreenType.WaitIndicator;
            ss.InputBlock = InputBlockMode.Window;
            ss.StartupLocation = WindowStartupLocation.CenterOwner;
            ss.TrackOwnerPosition = true;
            ss.Owner = cc.Window;
            

            if (show)
                SplashScreenManager.Show();
            else
                SplashScreenManager.Close();


        }
        #endregion
    }
}
