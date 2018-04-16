using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
