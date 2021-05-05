using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XPub.Infrastructure;
using XPub.Supervisor.JobManagement.Module.ViewModels;
using XPub.Supervisor.JobManagement.Module.Views;

namespace XPub.Supervisor.JobManagement.Module
{
    /// <summary>
    /// SupervisorJobManagementModule object derived from the <seealso cref="ModuleBase"/> object
    /// </summary>

    public class SupervisorJobManagementModule : IModule
    {
        #region Fields
        /// <summary>
        /// _regionManager field
        /// </summary>
        /// <value>IRegionManager reference </value>
        private readonly IRegionManager _regionManager;
        #endregion

        #region Constructors
        /// <summary>
        /// SupervisorJobManagementModule parameterized constructor
        /// Initializes the _regionManager field
        /// </summary>
        /// <param name="regionManager"></param>
        public SupervisorJobManagementModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        #endregion

        #region ModuleBase Implementation
        /// <summary>
        /// OnInitialized override method
        /// Registers the accordion supervisor job management menu item to the accordion region
        /// </summary>
        /// <param name="containerProvider">Container Services</param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.Regions[RegionNames.RegionAccordion].Add(containerProvider.Resolve<SupervisorJobManagementMenu>());

        }
        /// <summary>
        /// RegisterTypes override method
        /// Used to registers the SupervisorJobManagement view for navigation
        /// </summary>
        /// <param name="containerRegistry"></param>

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Reference to ViewA needs to be removed
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<SupervisorJobManagement, SupervisorJobManagementViewModel>();

        }
        #endregion
    }
}