using Prism.Modularity;
using Prism.Regions;

namespace Modules.Projects {
    public class ProjectModule : IModule {
        private readonly IRegionManager regionManager;
        public ProjectModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        void IModule.Initialize() {
            regionManager.RegisterViewWithRegion("ProjectsRegion", typeof(ProjectView));
        }
    }
}
