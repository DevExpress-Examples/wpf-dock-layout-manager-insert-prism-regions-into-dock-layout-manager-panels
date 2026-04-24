Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Prism
Imports Modules.Main
Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Navigation.Regions
Imports Prism.Unity
Imports System.Windows

Namespace PrismSupportSample
    Public Partial Class App
        Inherits PrismApplication

        Protected Overrides Function CreateShell() As Window
            Return Container.Resolve(Of Shell)()
        End Function

        Protected Overrides Sub RegisterTypes(containerRegistry As IContainerRegistry)
        End Sub

        Protected Overrides Sub ConfigureModuleCatalog(moduleCatalog As IModuleCatalog)
            moduleCatalog.AddModule(Of MainModule)()
        End Sub

        Protected Overrides Sub ConfigureRegionAdapterMappings(regionAdapterMappings As RegionAdapterMappings)
            MyBase.ConfigureRegionAdapterMappings(regionAdapterMappings)
            Dim factory = Container.Resolve(Of IRegionBehaviorFactory)()
            regionAdapterMappings.RegisterMapping(GetType(LayoutPanel), AdapterFactory.Make(Of RegionAdapterBase(Of LayoutPanel))(factory))
        End Sub
    End Class
End Namespace
