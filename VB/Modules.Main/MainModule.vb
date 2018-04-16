Imports Prism.Modularity
Imports Prism.Regions
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Modules.Main
    Public Class MainModule
        Implements IModule

        Private ReadOnly regionManager As IRegionManager
        Public Sub New(ByVal regionManager As IRegionManager)
            Me.regionManager = regionManager
        End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("MainRegion", GetType(MainView))
        End Sub
    End Class
End Namespace
