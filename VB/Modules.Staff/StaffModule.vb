Imports Prism.Modularity
Imports Prism.Regions

Namespace Modules.Staff
    Public Class StaffModule
        Implements IModule
        Private ReadOnly regionManager As IRegionManager
        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("StaffRegion", GetType(StaffView))
        End Sub
    End Class
End Namespace
