﻿Imports System.Windows.Controls
Imports DevExpress.Xpf.Docking
Imports Prism.Regions

Namespace PrismSupportSample
    Public Class DockManagerAdapter
        Inherits RegionAdapterBase(Of DockLayoutManager)
        Public Sub New(ByVal BehaviorFactory As IRegionBehaviorFactory)
            MyBase.New(BehaviorFactory)
        End Sub
        Protected Overrides Function CreateRegion() As IRegion
            Return New SingleActiveRegion()
        End Function
        Protected Overrides Sub Adapt(ByVal region As IRegion, ByVal regionTarget As DockLayoutManager)
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
