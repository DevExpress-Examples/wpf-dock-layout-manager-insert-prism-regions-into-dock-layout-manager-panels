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
