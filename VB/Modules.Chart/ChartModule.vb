Imports Prism.Regions
Imports Prism.Modularity

Namespace Modules.Chart
    Public Class ChartModule
        Implements IModule
        Private ReadOnly regionManager As IRegionManager
        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("ChartRegion", GetType(ChartView))
        End Sub
    End Class
End Namespace
