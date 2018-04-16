using System.Windows;
using DevExpress.Xpf.Docking;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Presentation.Regions;
using Microsoft.Practices.Composite.UnityExtensions;

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
            catalog.AddModule(typeof(Modules.TeamList.TeamListModule));
            catalog.AddModule(typeof(Modules.Contacts.ContactsModule));
            catalog.AddModule(typeof(Modules.Stuff.StuffModule));
            catalog.AddModule(typeof(Modules.Projects.ProjectModule));
            catalog.AddModule(typeof(Modules.Chart.ChartModule));

        }

        protected override Microsoft.Practices.Composite.Presentation.Regions.RegionAdapterMappings ConfigureRegionAdapterMappings() {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
            mappings.RegisterMapping(typeof(DockLayoutManager), Container.Resolve<DockManagerAdapter>());
            return mappings;
        }
    }
}
