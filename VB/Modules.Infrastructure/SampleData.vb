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
Imports System.Windows.Media
Imports System.Collections
Imports System.Windows.Media.Imaging

Namespace Modules.Infrastructure
	Public Class TeamList
		Inherits DependencyObject
		Public Shared Function CreateSampleData() As List(Of Team)

			Dim lead1 As New Person() With {.Email = "team1@team.com", .FirstName = "John", .LastName = "Doe", .Phone = "111-2222", .Icq = "77-77-77", .JobTitle = "Team lead", .Photo = New BitmapImage(New Uri("/Images/1.png", UriKind.Relative))}
			Dim lead2 As New Person() With {.Email = "team2@team.com", .FirstName = "Jane", .LastName = "Doe", .Phone = "222-3333", .Icq = "88-88-88", .JobTitle = "Team lead", .Photo = New BitmapImage(New Uri("/Images/2.png", UriKind.Relative))}

			Dim person1 As New Person() With {.JobTitle = "Developer", .FirstName = "James", .LastName = "Sheppard", .Icq = "11-11-11"}
			Dim person2 As New Person() With {.JobTitle = "Designer", .FirstName = "Kate", .LastName = "Locke", .Icq = "22-22-22"}
			Dim person3 As New Person() With {.JobTitle = "Developer", .FirstName = "Clarie", .LastName = "Ford", .Icq = "33-33-33"}
			Dim person4 As New Person() With {.JobTitle = "Developer", .FirstName = "Jack", .LastName = "Littleton", .Icq = "44-44-44"}
			Dim person5 As New Person() With {.JobTitle = "Designer", .FirstName = "Hugo", .LastName = "Pace", .Icq = "55-55-55"}

			Dim project1 As New Project("Project 1") With {.BugsTotal = 15, .IssuesTotal = 26}
			project1.IssuesData.AddRange(New Point() { New Point(0, 58), New Point(1, 63), New Point(2, 40), New Point(3, 44), New Point(4, 26) })
			project1.BugsData.AddRange(New Point() { New Point(0, 10), New Point(1, 20), New Point(2, 19), New Point(3, 13), New Point(4, 15) })
			Dim project2 As New Project("Project 2") With {.BugsTotal = 20, .IssuesTotal = 40}
			project2.IssuesData.AddRange(New Point() { New Point(0, 18), New Point(1, 12), New Point(2, 42), New Point(3, 35), New Point(4, 40) })
			project2.BugsData.AddRange(New Point() { New Point(0, 9), New Point(1, 6), New Point(2, 20), New Point(3, 13), New Point(4, 20) })
			Dim project3 As New Project("Project 3") With {.BugsTotal = 9, .IssuesTotal = 20}
			project3.IssuesData.AddRange(New Point() { New Point(0, 18), New Point(1, 44), New Point(2, 30), New Point(3, 25), New Point(4, 20) })
			project3.BugsData.AddRange(New Point() { New Point(0, 8), New Point(1, 13), New Point(2, 11), New Point(3, 9), New Point(4, 9) })
			Dim project4 As New Project("Project 4") With {.BugsTotal = 15, .IssuesTotal = 26}
			project4.IssuesData.AddRange(New Point() { New Point(0, 58), New Point(1, 63), New Point(2, 40), New Point(3, 44), New Point(4, 26) })
			project4.BugsData.AddRange(New Point() { New Point(0, 10), New Point(1, 20), New Point(2, 19), New Point(3, 13), New Point(4, 15) })

			Dim team1 As New Team() With {.TeamName = "Team 1"}
			team1.TeamLead = lead1
			team1.Projects = New List(Of Project)()
			team1.Projects.AddRange(New Project() { project1, project2 })
			team1.Stuff = New List(Of Person)()
			team1.Stuff.AddRange(New Person() { lead1, person1, person2 })

			Dim team2 As New Team() With {.TeamName = "Team 2"}
			team2.TeamLead = lead2
			team2.Projects = New List(Of Project)()
			team2.Projects.AddRange(New Project() { project3, project4 })
			team2.Stuff = New List(Of Person)()
			team2.Stuff.AddRange(New Person() { lead2, person3, person4, person5 })

			Dim list As New List(Of Team)()
			list.AddRange(New Team() { team1, team2 })
			Return list
		End Function
	End Class

	Public Class Team
		Inherits DependencyObject

		Public Shared ReadOnly TeamNameProperty As DependencyProperty
		Public Shared ReadOnly TeamLeadProperty As DependencyProperty
		Public Shared ReadOnly ProjectsProperty As DependencyProperty
		Public Shared ReadOnly StuffProperty As DependencyProperty

		Shared Sub New()
			Dim ownerType As Type = GetType(Team)
			TeamNameProperty = DependencyProperty.Register("TeamName", GetType(String), ownerType)
			TeamLeadProperty = DependencyProperty.Register("TeamLead", GetType(Person), ownerType)
			ProjectsProperty = DependencyProperty.Register("Projects", GetType(List(Of Project)), ownerType)
			StuffProperty = DependencyProperty.Register("Stuff", GetType(List(Of Person)), ownerType)
		End Sub

		Public Property TeamName() As String
			Get
				Return CType(GetValue(TeamNameProperty), String)
			End Get
			Set(ByVal value As String)
				SetValue(TeamNameProperty, value)
			End Set
		End Property
		Public Property TeamLead() As Person
			Get
				Return CType(GetValue(TeamLeadProperty), Person)
			End Get
			Set(ByVal value As Person)
				SetValue(TeamLeadProperty, value)
			End Set
		End Property
		Public Property Projects() As List(Of Project)
			Get
				Return CType(GetValue(ProjectsProperty), List(Of Project))
			End Get
			Set(ByVal value As List(Of Project))
				SetValue(ProjectsProperty, value)
			End Set
		End Property
		Public Property Stuff() As List(Of Person)
			Get
				Return CType(GetValue(StuffProperty), List(Of Person))
			End Get
			Set(ByVal value As List(Of Person))
				SetValue(StuffProperty, value)
			End Set
		End Property
	End Class

	Public Class Person
		Public Property JobTitle() As String
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property Photo() As ImageSource
		Public Property Icq() As String
		Public Property Phone() As String
		Public Property Email() As String
	End Class
	Public Class Project
		Inherits DependencyObject
		Public Shared ReadOnly BugsDataProperty As DependencyProperty
		Public Shared ReadOnly IssuesDataProperty As DependencyProperty

		Shared Sub New()
			Dim ownerType As Type = GetType(Team)
			BugsDataProperty = DependencyProperty.Register("BugsData", GetType(ArrayList), ownerType)
			IssuesDataProperty = DependencyProperty.Register("IssuesData", GetType(ArrayList), ownerType)
		End Sub

		Public Property Title() As String
		Public Property IssuesTotal() As Integer
		Public Property BugsTotal() As Integer
		Public Property BugsData() As ArrayList
			Get
				Return CType(GetValue(BugsDataProperty), ArrayList)
			End Get
			Set(ByVal value As ArrayList)
				SetValue(BugsDataProperty, value)
			End Set
		End Property
		Public Property IssuesData() As ArrayList
			Get
				Return CType(GetValue(IssuesDataProperty), ArrayList)
			End Get
			Set(ByVal value As ArrayList)
				SetValue(IssuesDataProperty, value)
			End Set
		End Property
		Public Sub New(ByVal Title As String)
			Me.Title = Title
			IssuesData = New ArrayList()
			BugsData = New ArrayList()
		End Sub
	End Class

End Namespace
