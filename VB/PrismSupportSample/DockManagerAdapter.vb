' Developer Express Code Central Example:
' Using DXDocking for WPF in accordance with Composite Application Guidelines
' 
' This example contains a DXDocking (http://devexpress.com/DXDocking) to Prism
' (http://www.codeplex.com/CompositeWPF) adapter that allows you to use the
' DXDocking for WPF in your composite applications.
' The sample for version
' v10.2.5 supports Prism 4
' 
' See Also:
' Prism: patterns & practices Composite
' Application Guidance for WPF and Silverlight site
' (http://compositewpf.codeplex.com/)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1926


Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Docking
Imports Microsoft.Practices.Prism.Regions

Namespace PrismSupportSample
	Public Class DockManagerAdapter
		Inherits RegionAdapterBase(Of DockLayoutManager)
		Public Sub New(ByVal BehaviorFactory As IRegionBehaviorFactory)
			MyBase.New(BehaviorFactory)
		End Sub
		Protected Overrides Function CreateRegion() As Microsoft.Practices.Prism.Regions.IRegion
			Return New SingleActiveRegion()
		End Function
		Protected Overrides Sub Adapt(ByVal region As Microsoft.Practices.Prism.Regions.IRegion, ByVal regionTarget As DockLayoutManager)
			Dim items() As BaseLayoutItem = regionTarget.GetItems()
			For Each item As BaseLayoutItem In items
				Dim regionName As String = RegionManager.GetRegionName(item)
				If (Not String.IsNullOrEmpty(regionName)) Then
					Dim panel As LayoutPanel = TryCast(item, LayoutPanel)
					If panel IsNot Nothing AndAlso panel.Content Is Nothing Then
						Dim control As New ContentControl()
						RegionManager.SetRegionName(control, regionName)
						panel.Content = control
					End If
				End If
			Next item
		End Sub
	End Class
End Namespace
