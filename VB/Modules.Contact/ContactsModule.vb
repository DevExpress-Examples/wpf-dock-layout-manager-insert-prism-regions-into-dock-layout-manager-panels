Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Microsoft.Practices.Composite.Regions
Imports Microsoft.Practices.Composite.Modularity

Namespace Modules.Contacts
	Public Class ContactsModule
		Implements IModule
		Private ReadOnly regionManager As IRegionManager
		Public Sub New(ByVal regionManager As IRegionManager)
			Me.regionManager = regionManager
		End Sub
        Public Sub Initialize() Implements IModule.Initialize
            regionManager.RegisterViewWithRegion("ContactsRegion", GetType(ContactsView))
        End Sub
	End Class
End Namespace
