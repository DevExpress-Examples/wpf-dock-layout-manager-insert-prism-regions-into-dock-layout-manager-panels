using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Composite.Modularity;

namespace Modules.Contacts {
    public class ContactsModule : IModule {
        private readonly IRegionManager regionManager;
        public ContactsModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        public void Initialize() {
            regionManager.RegisterViewWithRegion("ContactsRegion", typeof(ContactsView));
        }
    }
}
