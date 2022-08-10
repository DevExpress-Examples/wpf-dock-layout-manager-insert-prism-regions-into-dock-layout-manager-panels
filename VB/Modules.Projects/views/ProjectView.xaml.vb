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
Imports System.Windows.Controls
Imports Modules.Infrastructure

Namespace Modules.Projects

    Public Partial Class ProjectView
        Inherits UserControl

        Public Shared ReadOnly Property Controller As TeamController
            Get
                Return TeamController.Controller
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub ProjectList_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            If e.AddedItems.Count > 0 Then
                Controller.SelectedProject = CType(e.AddedItems(0), Project)
            Else
                Controller.SelectedProject = Nothing
            End If
        End Sub
    End Class
End Namespace