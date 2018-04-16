using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;

namespace Modules.Stuff {
    public class StuffModule: IModule {
        private readonly IRegionManager regionManager;
        public StuffModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        public void Initialize() {
            regionManager.RegisterViewWithRegion("StuffRegion", typeof(StuffView));
        }
    }
}
