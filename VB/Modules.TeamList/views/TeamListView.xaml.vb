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

Namespace Modules.TeamList
	''' <summary>
	''' Interaction logic for TeamListView.xaml
	''' </summary>
	Partial Public Class TeamListView
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub list_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
			TeamController.Controller.SelectedTeam = CType(e.AddedItems(0), Team)
		End Sub
	End Class
End Namespace
