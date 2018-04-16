Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Microsoft.Practices.Composite.Modularity
Imports Microsoft.Practices.Composite.Regions

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
