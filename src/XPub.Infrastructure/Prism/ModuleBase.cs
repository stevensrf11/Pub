using Prism.Ioc;
using Prism.Modularity;

namespace XPub.Infrastructure.Prism
{
    /// <summary>
    /// ModuleBase abstract object derived from the <see cref="IModule"/> interface.
    /// Serves as the base class for module derived objects
    /// </summary>    

    public abstract class ModuleBase : IModule
    {
       
        /// <summary>
        /// OnInitialized abstract method
        ///  Notifies the module that it has been initialized.
        ///  Use to  obtain container provider services
        /// </summary>
        /// <param name="containerProvider">Container Services</param>
        public abstract void OnInitialized(IContainerProvider containerProvider);
        //
        // Summary:
        //     Used to register types with the container that will be used by your application.

        /// <summary>
        /// RegisterTypes abstract method
        ///  Used to register types with the container that will be used by your application.
        /// </summary>
        /// <param name="containerRegistry"></param>
        public abstract void RegisterTypes(IContainerRegistry containerRegistry);
    }
}
