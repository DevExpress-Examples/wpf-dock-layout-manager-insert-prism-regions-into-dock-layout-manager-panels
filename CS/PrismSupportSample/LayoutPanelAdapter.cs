using DevExpress.Xpf.Docking;
using Prism.Regions;

namespace PrismSupportSample {
    public class LayoutPanelAdapter : RegionAdapterBase<LayoutPanel> {
        public LayoutPanelAdapter(IRegionBehaviorFactory behaviorFactory) :
            base(behaviorFactory) {
        }
        protected override IRegion CreateRegion() {
            return new SingleActiveRegion();
        }
        protected override void Adapt(IRegion region, LayoutPanel regionTarget) {
            region.Views.CollectionChanged += (d, e) =>
            {
                if(e.NewItems != null)
                    regionTarget.Content = e.NewItems[0];
            };
        }
    }
}
