using DevExpress.Xpf.Accordion;
using DevExpress.Xpf.Core;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using XPub.App.Core.RegionAdapters;
using XPub.App.Views;
using XPub.Infrastructure.Commands;
using XPub.Services.Module;
using XPub.Admin.Configuration.Module;
using XPub.Admin.HumanResources.Module.Module;
using XPub.Supervisor.Configuration.Module;
using XPub.Supervisor.JobManagement.Module;
using XPub.Employee.AssignedWork.Module;
namespace XPub.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// Application's boots trapper and startup class
    /// </summary>
    public partial class App
    {
        #region PrismApplicationBase Implementation
        /// <summary>
        /// OnStartup event handler
        /// Application startup event handler
        /// </summary>
        /// <param name="e"> System.Windows.StartupEventArgs that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            ApplicationThemeHelper.UseDefaultSvgImages = true;
            base.OnStartup(e);
        }
        #endregion

        /// <summary>
        /// CreateShell method 
        /// Use to set the main window view of the application
        /// </summary>
        /// <returns>MainWindow view</returns>
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// RegisterTypes method
        /// Used to register objects for DI
        /// </summary>
        /// <param name="containerRegistry">Confiner extension used for registration</param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new AggregateModuleCatalog();
        //}

        /// <summary>
        /// ConfigureModuleCatalog method
        /// Used to register modules with the ModuleCatalog
        /// </summary>
        /// <param name="moduleCatalog">ModuleCatalog reference</param>
        /// <remarks>
        /// Need to move these modules back to directory loading using the custom AggregateModuleCatalog
        /// </remarks>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {

            var adminHRModule = typeof(AdminHRModule);
            var servicesModule = typeof(ServicesModule);
            var adminConfigModuleModule = typeof(AdminConfigModule);
            var supervisorConfigModuleModule = typeof(SupervisorConfigModule);
            var supervisorJobManagementModule = typeof(SupervisorJobManagementModule);
            var employeeAssignedWorkModule = typeof(EmployeeAssignedWorkModule);





            string[] subs = { servicesModule.Name };

            moduleCatalog.AddModule(new ModuleInfo(servicesModule.Name, servicesModule.AssemblyQualifiedName));
            moduleCatalog.AddModule(new ModuleInfo(adminConfigModuleModule.Name, adminConfigModuleModule.AssemblyQualifiedName, subs));
             moduleCatalog.AddModule(new ModuleInfo(adminHRModule.Name, adminHRModule.AssemblyQualifiedName));
            moduleCatalog.AddModule(new ModuleInfo(supervisorConfigModuleModule.Name, supervisorConfigModuleModule.AssemblyQualifiedName));
            moduleCatalog.AddModule(new ModuleInfo(supervisorJobManagementModule.Name, supervisorJobManagementModule.AssemblyQualifiedName));
            moduleCatalog.AddModule(new ModuleInfo(employeeAssignedWorkModule.Name, employeeAssignedWorkModule.AssemblyQualifiedName));

            //// Module C is defined in the code.
            //Type moduleCType = typeof(ModuleC);
            //moduleCatalog.AddModule(new ModuleInfo()
            //{
            //    ModuleName = moduleCType.Name,
            //    ModuleType = moduleCType.AssemblyQualifiedName,
            //    InitializationMode = InitializationMode.OnDemand,
            //    DependsOn
            //});
            //moduleCatalog.AddModule<AdminConfigModule>();

            //System.InvalidCastException: 'Unable to cast object of type 'Prism.Modularity.ModuleCatalog' to type 'ModularityWithUnity.Desktop.AggregateModuleCatalog
            //var directoryCatalog = new DirectoryModuleCatalog() { ModulePath = @".\DirectoryModules" };
            //directoryCatalog.Load();

            //((AggregateModuleCatalog)moduleCatalog).AddCatalog(directoryCatalog);
        }

        /// <summary>
        /// ConfigureRegionAdapterMappings method
        /// Used to register custom region adapter for use
        /// </summary>
        /// <param name="regionAdapterMappings">Used to register custom region adapters</param>
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            // Custom Adapters
            regionAdapterMappings.RegisterMapping(typeof(AccordionControl),
                Container.Resolve<DxAccordionControlRegionAdapter>());

            regionAdapterMappings.RegisterMapping(typeof(ThemedWindow),
                            Container.Resolve<DxThemedWindowRegionAdapter>());
        }
    }
}
