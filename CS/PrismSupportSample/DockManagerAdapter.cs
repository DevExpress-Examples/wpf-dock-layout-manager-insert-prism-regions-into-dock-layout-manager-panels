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

using System.Collections.Generic;
using System.Windows.Controls;
using DevExpress.Xpf.Docking;
using Microsoft.Practices.Prism.Regions;

namespace PrismSupportSample {
    public class DockManagerAdapter : RegionAdapterBase<DockLayoutManager> {
        public DockManagerAdapter(IRegionBehaviorFactory BehaviorFactory)
            : base(BehaviorFactory) {
        }
        protected override Microsoft.Practices.Prism.Regions.IRegion CreateRegion() {
            return new SingleActiveRegion();
        }
        protected override void Adapt(Microsoft.Practices.Prism.Regions.IRegion region, DockLayoutManager regionTarget) {
            BaseLayoutItem[] items = regionTarget.GetItems();
            foreach(BaseLayoutItem item in items) {
                string regionName = RegionManager.GetRegionName(item);
                if(!string.IsNullOrEmpty(regionName)) {
                    LayoutPanel panel = item as LayoutPanel;
                    if(panel != null && panel.Content == null) {
                        ContentControl control = new ContentControl();
                        RegionManager.SetRegionName(control, regionName);
                        panel.Content = control;
                    }
                }
            }
        }
    }
}
