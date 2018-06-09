Imports Prism.Modularity
Imports Prism.Regions

Namespace Modules.TeamList
    Public Class TeamListModule
        Implements IModule
        Private ReadOnly regionManager As IRegionManager
        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("TeamListRegion", GetType(TeamListView))
        End Sub
    End Class
End Namespace
