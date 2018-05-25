using System.Windows;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Prism;
using Microsoft.Practices.ServiceLocation;
using Modules.Main;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;

namespace PrismSupportSample {
    class Bootstrapper : UnityBootstrapper {
        protected override DependencyObject CreateShell() {
            Shell shell = new Shell();
            shell.Show();
            return shell;
        }

        protected override void ConfigureModuleCatalog() {
            base.ConfigureModuleCatalog();
            ModuleCatalog catalog = (ModuleCatalog)this.ModuleCatalog;
            catalog.AddModule(typeof(MainModule));
        }
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
            if (mappings != null) {
                var factory = ServiceLocator.Current.GetInstance<IRegionBehaviorFactory>();
                mappings.RegisterMapping(typeof(LayoutPanel), AdapterFactory.Make<RegionAdapterBase<LayoutPanel>>(factory));
            }
            return mappings;
        }
    }
}