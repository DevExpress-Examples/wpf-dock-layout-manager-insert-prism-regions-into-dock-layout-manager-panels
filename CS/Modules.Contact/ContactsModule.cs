using Prism.Modularity;
using Prism.Regions;

namespace Modules.Contacts {
    public class ContactsModule : IModule {
        private readonly IRegionManager regionManager;
        public ContactsModule(IRegionManager regionManager) {
            this.regionManager = regionManager;
        }
        void IModule.Initialize() {
            regionManager.RegisterViewWithRegion("ContactsRegion", typeof(ContactsView));
        }
    }
}
