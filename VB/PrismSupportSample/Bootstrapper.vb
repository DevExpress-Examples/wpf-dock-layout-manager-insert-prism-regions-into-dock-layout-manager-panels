Imports System.Windows
Imports DevExpress.Xpf.Docking
Imports Microsoft.Practices.Unity
Imports Prism.Regions
Imports Prism.Modularity
Imports Prism.Unity

Namespace PrismSupportSample
    Friend Class Bootstrapper
        Inherits UnityBootstrapper
        Protected Overrides Function CreateShell() As DependencyObject
            Dim shell As New Shell()
            shell.Show()
            Return shell
        End Function


        Protected Overrides Sub ConfigureModuleCatalog()
            MyBase.ConfigureModuleCatalog()

            Dim catalog As ModuleCatalog = CType(Me.ModuleCatalog, ModuleCatalog)
            catalog.AddModule(GetType(Modules.TeamList.TeamListModule))
            catalog.AddModule(GetType(Modules.Contacts.ContactsModule))
            catalog.AddModule(GetType(Modules.Staff.StaffModule))
            catalog.AddModule(GetType(Modules.Projects.ProjectModule))
            catalog.AddModule(GetType(Modules.Chart.ChartModule))

        End Sub

        Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
            Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
            mappings.RegisterMapping(GetType(DockLayoutManager), Container.Resolve(Of DockManagerAdapter)())
            Return mappings
        End Function
    End Class
End Namespace
