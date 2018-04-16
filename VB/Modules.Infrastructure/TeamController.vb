Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows

Namespace Modules.Infrastructure

	Public Class TeamController
		Inherits DependencyObject
		Public Shared ReadOnly SelectedTeamProperty As DependencyProperty
		Public Shared ReadOnly SelectedProjectProperty As DependencyProperty
		Shared Sub New()
			Controller = New TeamController()
			Dim ownerType As Type = GetType(TeamController)
			SelectedTeamProperty = DependencyProperty.Register("SelectedTeam", GetType(Team), ownerType)
			SelectedProjectProperty = DependencyProperty.Register("SelectedProject", GetType(Project), ownerType)
		End Sub
		Public Property SelectedTeam() As Team
			Get
				Return CType(GetValue(SelectedTeamProperty), Team)
			End Get
			Set(ByVal value As Team)
				SetValue(SelectedTeamProperty, value)
			End Set
		End Property
		Public Property SelectedProject() As Project
			Get
				Return CType(GetValue(SelectedProjectProperty), Project)
			End Get
			Set(ByVal value As Project)
				SetValue(SelectedProjectProperty, value)
			End Set
		End Property
        Private Shared privateController As TeamController
		Public Shared Property Controller() As TeamController
			Get
				Return privateController
			End Get
			Private Set(ByVal value As TeamController)
				privateController = value
			End Set
		End Property
	End Class
End Namespace
