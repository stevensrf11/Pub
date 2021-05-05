using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XPub.Employee.AssignedWork.Module.ViewModels;
using XPub.Employee.AssignedWork.Module.Views;
using XPub.Infrastructure;
using XPub.Infrastructure.Prism;

namespace XPub.Employee.AssignedWork.Module
{
    [Module(ModuleName = "XPub.Employee.AssignedWork.Module.EmployeeAssignedWorkModule")]
    /// <summary>
    /// EmployeeAssignedWorkModule object derived from the <seealso cref="ModuleBase"/> object
    /// </summary>

    public class EmployeeAssignedWorkModule : ModuleBase
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
        /// EmployeeAssignedWorkModule parameterized constructor
        /// Initializes the _regionManager field
        /// </summary>
        /// <param name="regionManager"></param>
        public EmployeeAssignedWorkModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region ModuleBase Implementation
        /// <summary>
        /// OnInitialized override method
        /// Registers the accordion employee assigned menu to the accordion region
        /// </summary>
        /// <param name="containerProvider">Container Services</param>
        public override void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.Regions[RegionNames.RegionAccordion].Add(containerProvider.Resolve<EmployeeAssignedWorkMenu>());
        }

        /// <summary>
        /// RegisterTypes override method
        /// Used to registers the EmployeeAssignedWork view for navigation
        /// </summary>
        /// <param name="containerRegistry"></param>

        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Reference to ViewA needs to be removed
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<EmployeeAssignedWork, EmployeeAssignedWorkViewModel>();

        }
        #endregion

    }
}