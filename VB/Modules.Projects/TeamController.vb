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
		Public Shared Property Controller() As TeamController
	End Class
End Namespace
