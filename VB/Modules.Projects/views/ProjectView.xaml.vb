Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports Modules.Infrastructure

Namespace Modules.Projects
	Partial Public Class ProjectView
		Inherits UserControl

		Public Shared ReadOnly Property Controller() As TeamController
			Get
				Return TeamController.Controller
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
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
