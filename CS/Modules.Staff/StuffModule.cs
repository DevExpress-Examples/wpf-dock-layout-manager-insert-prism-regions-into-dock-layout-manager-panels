using Prism.Modularity;
using Prism.Regions;

namespace Modules.Stuff {
    public class StuffModule: IModule {
        private readonly IRegionManager regionManager;
        public StuffModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        void IModule.Initialize() {
            regionManager.RegisterViewWithRegion("StuffRegion", typeof(StuffView));
        }
    }
}
