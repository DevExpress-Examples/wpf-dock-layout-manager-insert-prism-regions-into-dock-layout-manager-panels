Imports System.Windows
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Prism
Imports Microsoft.Practices.ServiceLocation
Imports Modules.Main
Imports Prism.Modularity
Imports Prism.Regions
Imports Prism.Unity

Namespace PrismSupportSample

    Friend Class Bootstrapper
        Inherits UnityBootstrapper

        Protected Overrides Function CreateShell() As DependencyObject
            Dim shell As Shell = New Shell()
            shell.Show()
            Return shell
        End Function

        Protected Overrides Sub ConfigureModuleCatalog()
            MyBase.ConfigureModuleCatalog()
            Dim catalog As ModuleCatalog = CType(ModuleCatalog, ModuleCatalog)
            catalog.AddModule(GetType(MainModule))
        End Sub

        Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
            Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
            If mappings IsNot Nothing Then
                Dim factory = ServiceLocator.Current.GetInstance(Of IRegionBehaviorFactory)()
                mappings.RegisterMapping(GetType(LayoutPanel), AdapterFactory.Make(Of RegionAdapterBase(Of LayoutPanel))(factory))
            End If

            Return mappings
        End Function
    End Class
End Namespace
