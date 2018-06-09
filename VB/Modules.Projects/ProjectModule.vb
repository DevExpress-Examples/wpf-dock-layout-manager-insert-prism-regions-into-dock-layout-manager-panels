Imports Prism.Regions
Imports Prism.Modularity

Namespace Modules.Projects
    Public Class ProjectModule
        Implements IModule
        Private ReadOnly regionManager As IRegionManager
        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("ProjectsRegion", GetType(ProjectView))
        End Sub
    End Class
End Namespace
