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

Namespace Modules.Stuff
	Partial Public Class StuffView
		Inherits UserControl

		Public Shared ReadOnly Property Controller() As TeamController
			Get
				Return TeamController.Controller
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
