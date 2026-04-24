Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Navigation.Regions

Namespace Modules.Main

    Public Class MainModule
        Implements IModule

        Private ReadOnly regionManager As IRegionManager

        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub

        Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        End Sub

        Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
            regionManager.RegisterViewWithRegion("MainRegion", GetType(MainView))
        End Sub
    End Class
End Namespace
