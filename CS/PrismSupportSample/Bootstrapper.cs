// Developer Express Code Central Example:
// Using DXDocking for WPF in accordance with Composite Application Guidelines
// 
// This example contains a DXDocking (http://devexpress.com/DXDocking) to Prism
// (http://www.codeplex.com/CompositeWPF) adapter that allows you to use the
// DXDocking for WPF in your composite applications.
// The sample for version
// v10.2.5 supports Prism 4
// 
// See Also:
// Prism: patterns & practices Composite
// Application Guidance for WPF and Silverlight site
// (http://compositewpf.codeplex.com/)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1926

using System.Windows;
using DevExpress.Xpf.Docking;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

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
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
            if(mappings != null) {
                //mappings.RegisterMapping(typeof(DockLayoutManager), ServiceLocator.Current.GetInstance<DockManagerAdapter>());
                mappings.RegisterMapping(typeof(LayoutPanel), ServiceLocator.Current.GetInstance<LayoutPanelAdapter>());

            }
            return mappings;
        } 
    }
}
