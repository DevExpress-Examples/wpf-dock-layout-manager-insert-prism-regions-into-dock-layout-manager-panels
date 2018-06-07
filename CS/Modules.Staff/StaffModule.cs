﻿// Developer Express Code Central Example:
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

using Prism.Modularity;
using Prism.Regions;

namespace Modules.Staff {
    public class StaffModule: IModule {
        private readonly IRegionManager regionManager;
        public StaffModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        void IModule.Initialize() {
            regionManager.RegisterViewWithRegion("StaffRegion", typeof(StaffView));
        }
    }
}