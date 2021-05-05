using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XPub.Infrastructure.Prism;
using XPub.Interfaces.Services.Administration;
using XPub.Services.Administration;
using XPub.Services.Module.Views;

namespace XPub.Services.Module
{
    [Module(ModuleName = "XPub.Services.Module.ServiceModule")]
    public class ServicesModule :  ModuleBase
    {
        public override void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IXPubServiceAdmin, XPubServiceAdmin>();
        }
    }
}