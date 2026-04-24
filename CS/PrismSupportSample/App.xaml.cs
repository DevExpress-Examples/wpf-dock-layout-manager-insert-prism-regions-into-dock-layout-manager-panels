using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Prism;
using Modules.Main;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;
using Prism.Unity;
using System.Windows;

namespace PrismSupportSample {
    public partial class App : PrismApplication {
        protected override Window CreateShell() {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            moduleCatalog.AddModule<MainModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings) {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            var factory = Container.Resolve<IRegionBehaviorFactory>();
            regionAdapterMappings.RegisterMapping(typeof(LayoutPanel), AdapterFactory.Make<RegionAdapterBase<LayoutPanel>>(factory));
        }
    }
}
