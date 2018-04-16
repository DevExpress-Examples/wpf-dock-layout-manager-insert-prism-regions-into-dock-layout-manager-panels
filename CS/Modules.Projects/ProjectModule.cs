using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;

namespace Modules.Projects {
    public class ProjectModule : IModule {
        private readonly IRegionManager regionManager;
        public ProjectModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        public void Initialize() {
            regionManager.RegisterViewWithRegion("ProjectsRegion", typeof(ProjectView));
        }
    }
}
