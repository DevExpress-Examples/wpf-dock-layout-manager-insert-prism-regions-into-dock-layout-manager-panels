using Prism.Modularity;
using Prism.Regions;

namespace Modules.TeamList {
    public class TeamListModule : IModule {
        private readonly IRegionManager regionManager;
        public TeamListModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        void IModule.Initialize() {
            regionManager.RegisterViewWithRegion("TeamListRegion", typeof(TeamListView));
        }
    }
}
