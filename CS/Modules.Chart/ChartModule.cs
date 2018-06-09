using Prism.Modularity;
using Prism.Regions;

namespace Modules.Chart {
    public class ChartModule: IModule {
        private readonly IRegionManager regionManager;
        public ChartModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        void IModule.Initialize() {
            regionManager.RegisterViewWithRegion("ChartRegion", typeof(ChartView));
        }
    }
}
