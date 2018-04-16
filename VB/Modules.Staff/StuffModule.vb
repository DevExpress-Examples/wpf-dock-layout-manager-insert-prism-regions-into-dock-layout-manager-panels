Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Microsoft.Practices.Composite.Modularity
Imports Microsoft.Practices.Composite.Regions

Namespace Modules.Stuff
	Public Class StuffModule
		Implements IModule
		Private ReadOnly regionManager As IRegionManager
		Public Sub New(ByVal regionManager As IRegionManager)
			Me.regionManager = regionManager
		End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("StuffRegion", GetType(StuffView))
        End Sub
	End Class
End Namespace
