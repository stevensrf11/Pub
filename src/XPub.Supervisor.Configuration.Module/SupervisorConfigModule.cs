using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XPub.Infrastructure;
using XPub.Supervisor.Configuration.Module.ViewModels;
using XPub.Supervisor.Configuration.Module.Views;

namespace XPub.Supervisor.Configuration.Module
{
    [Module(ModuleName = "XPub.Supervisor.Configuration.Module.SupervisorConfigModule")]
    [ModuleDependency("XPub.Services.Module.ServiceModule")]
    /// <summary>
    /// SupervisorConfigModule object derived from the <seealso cref="ModuleBase"/> object
    /// </summary>
    public class SupervisorConfigModule : IModule
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
        /// SupervisorConfigModule parameterized constructor
        /// Initializes the _regionManager field
        /// </summary>
        /// <param name="regionManager"></param>
        public SupervisorConfigModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region ModuleBase Implementation
        /// <summary>
        /// OnInitialized override method
        /// Registers the accordion supervisor configuration menu item  to the accordion region
        /// </summary>
        /// <param name="containerProvider">Container Services</param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.Regions[RegionNames.RegionAccordion].Add(containerProvider.Resolve<SupervisorConfigMenu>());

        }

        /// <summary>
        /// RegisterTypes override method
        /// Used to registers the SupervisorConfigCreateJob view for navigation
        /// </summary>
        /// <param name="containerRegistry"></param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Reference to ViewA needs to be removed
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<SupervisorConfigCreateJob, SupervisorConfigCreateJobViewModel>();

        }
        #endregion
    }
}