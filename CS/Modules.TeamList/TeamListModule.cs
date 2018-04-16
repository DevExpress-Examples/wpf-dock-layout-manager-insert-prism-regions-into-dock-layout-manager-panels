using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;

namespace Modules.TeamList {
    public class TeamListModule : IModule {
        private readonly IRegionManager regionManager;
        public TeamListModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        public void Initialize() {
            regionManager.RegisterViewWithRegion("TeamListRegion", typeof(TeamListView));
        }
    }
}
