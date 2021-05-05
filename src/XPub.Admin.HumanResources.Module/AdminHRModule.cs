using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XPub.Admin.HumanResources.Module.Views;
using XPub.Infrastructure;
using XPub.Infrastructure.Prism;
using XPub.Admin.HumanResources.Module.ViewModels;
using XPub.Infrastructure.ViewModels;

namespace XPub.Admin.HumanResources.Module.Module
{
    [Module(ModuleName = "XPub.Admin.HumanResources.Module.AdminHRModule")]
    /// <summary>
    /// AdminHRModule object derived from the <seealso cref="ModuleBase"/> object
    /// </summary>

    public class AdminHRModule : ModuleBase
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
        /// AdminHRModule parameterized constructor
        /// Initializes the _regionManager field
        /// </summary>
        /// <param name="regionManager"></param>
        public AdminHRModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region ModuleBase Implementation
        /// <summary>
        /// OnInitialized override method
        /// Registers the accordion hr menu to the accordion region
        /// </summary>
        /// <param name="containerProvider">Container Services</param>
        public override void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.Regions[RegionNames.RegionAccordion].Add(containerProvider.Resolve<AdminHRMenu>());

        }
        /// <summary>
        /// RegisterTypes override method
        /// Used to registers the AdminEmployees view for navigation
        /// Used to registers the XPubEmployeeViewModel view for dependency injection
        /// </summary>
        /// <param name="containerRegistry"></param>
        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
              containerRegistry.Register<XPubEmployeeViewModel>();
              containerRegistry.RegisterForNavigation<AdminEmployees, AdminEmployeesViewModel>();
           
        }
        #endregion
    }
}