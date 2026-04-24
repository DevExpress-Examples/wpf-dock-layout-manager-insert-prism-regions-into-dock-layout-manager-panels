using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;

namespace Modules.Main {
    public class MainModule : IModule {
        private readonly IRegionManager regionManager;

        public MainModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(MainView));
        }
    }
}
