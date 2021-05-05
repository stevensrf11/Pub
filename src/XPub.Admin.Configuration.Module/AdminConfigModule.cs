using XPub.Admin.Configuration.Module.ViewModels;
using XPub.Admin.Configuration.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XPub.Infrastructure;
using XPub.Infrastructure.Prism;


namespace XPub.Admin.Configuration.Module
{
    
    [Module(ModuleName = "XPub.Admin.Configuration.Module.AdminConfigModule")]
    [ModuleDependency("XPub.Services.Module.ServiceModule")]
    //[ModuleDependency("ServiceModule")]
    /// <summary>
    /// AdminConfigModule object derived from the <seealso cref="ModuleBase"/> object
    /// </summary>
    public class AdminConfigModule : ModuleBase
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
        /// AdminConfigModule parameterized constructor
        /// Initializes the _regionManager field
        /// </summary>
        /// <param name="regionManager"></param>
        public AdminConfigModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region ModuleBase Implementation
        /// <summary>
        /// OnInitialized override method
        /// Registers the accordion configuration menu to the accordion region
        /// </summary>
        /// <param name="containerProvider">Container Services</param>
        public override void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.Regions[RegionNames.RegionAccordion].Add(containerProvider.Resolve<AdminConfigMenu>());

        }

        /// <summary>
        /// RegisterTypes override method
        /// Used to registers the AdminConfigCreateJob view for navigation
        /// </summary>
        /// <param name="containerRegistry"></param>
        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Reference to ViewA needs to be removed
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<AdminConfigCreateJob, AdminConfigCreateJobViewModel>();

        }
        #endregion
    }
}