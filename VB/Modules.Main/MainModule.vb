Imports Prism.Modularity
Imports Prism.Regions

Namespace Modules.Main

    Public Class MainModule
        Implements IModule

        Private ReadOnly regionManager As IRegionManager

        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub

        Public Sub Initialize()
            regionManager.RegisterViewWithRegion("MainRegion", GetType(MainView))
        End Sub

        Private Sub IModule_Initialize() Implements IModule.Initialize
            Initialize()
        End Sub
    End Class
End Namespace
