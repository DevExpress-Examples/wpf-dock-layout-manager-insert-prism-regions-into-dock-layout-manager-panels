using System;
using System.Linq;
using Prism.Modularity;
using Prism.Regions;

namespace Modules.Main
{
    public class MainModule : IModule {
        private readonly IRegionManager regionManager;
        public MainModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        public void Initialize() {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(MainView));
        }
    }
}
