using System.Collections.Generic;
using System.Windows.Controls;
using DevExpress.Xpf.Docking;
using Microsoft.Practices.Composite.Presentation.Regions;

namespace PrismSupportSample {
    public class DockManagerAdapter : RegionAdapterBase<DockLayoutManager> {
        public DockManagerAdapter(IRegionBehaviorFactory BehaviorFactory)
            : base(BehaviorFactory) {
        }
        protected override Microsoft.Practices.Composite.Regions.IRegion CreateRegion() {
            return new SingleActiveRegion();
        }
        protected override void Adapt(Microsoft.Practices.Composite.Regions.IRegion region, DockLayoutManager regionTarget) {
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
