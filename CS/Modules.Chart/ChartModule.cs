using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;

namespace Modules.Chart {
    public class ChartModule: IModule {
        private readonly IRegionManager regionManager;
        public ChartModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        public void Initialize() {
            regionManager.RegisterViewWithRegion("ChartRegion", typeof(ChartView));
        }
    }
}
