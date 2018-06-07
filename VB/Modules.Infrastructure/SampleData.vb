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

            Dim lead1 As New Person() With { _
                .Email = "team1@team.com", _
                .FirstName = "John", _
                .LastName = "Doe", _
                .Phone = "111-2222", _
                .Icq = "77-77-77", _
                .JobTitle = "Team lead", _
                .Photo = New BitmapImage(New Uri("/Images/1.png", UriKind.Relative)) _
            }
            Dim lead2 As New Person() With { _
                .Email = "team2@team.com", _
                .FirstName = "Jane", _
                .LastName = "Doe", _
                .Phone = "222-3333", _
                .Icq = "88-88-88", _
                .JobTitle = "Team lead", _
                .Photo = New BitmapImage(New Uri("/Images/2.png", UriKind.Relative)) _
            }

            Dim person1 As New Person() With { _
                .JobTitle = "Developer", _
                .FirstName = "James", _
                .LastName = "Sheppard", _
                .Icq = "11-11-11" _
            }
            Dim person2 As New Person() With { _
                .JobTitle = "Designer", _
                .FirstName = "Kate", _
                .LastName = "Locke", _
                .Icq = "22-22-22" _
            }
            Dim person3 As New Person() With { _
                .JobTitle = "Developer", _
                .FirstName = "Clarie", _
                .LastName = "Ford", _
                .Icq = "33-33-33" _
            }
            Dim person4 As New Person() With { _
                .JobTitle = "Developer", _
                .FirstName = "Jack", _
                .LastName = "Littleton", _
                .Icq = "44-44-44" _
            }
            Dim person5 As New Person() With { _
                .JobTitle = "Designer", _
                .FirstName = "Hugo", _
                .LastName = "Pace", _
                .Icq = "55-55-55" _
            }

            Dim project1 As New Project("Project 1") With { _
                .BugsTotal = 15, _
                .IssuesTotal = 26 _
            }
            project1.IssuesData.AddRange(New Point() { _
                New Point(0, 58), _
                New Point(1, 63), _
                New Point(2, 40), _
                New Point(3, 44), _
                New Point(4, 26) _
            })
            project1.BugsData.AddRange(New Point() { _
                New Point(0, 10), _
                New Point(1, 20), _
                New Point(2, 19), _
                New Point(3, 13), _
                New Point(4, 15) _
            })
            Dim project2 As New Project("Project 2") With { _
                .BugsTotal = 20, _
                .IssuesTotal = 40 _
            }
            project2.IssuesData.AddRange(New Point() { _
                New Point(0, 18), _
                New Point(1, 12), _
                New Point(2, 42), _
                New Point(3, 35), _
                New Point(4, 40) _
            })
            project2.BugsData.AddRange(New Point() { _
                New Point(0, 9), _
                New Point(1, 6), _
                New Point(2, 20), _
                New Point(3, 13), _
                New Point(4, 20) _
            })
            Dim project3 As New Project("Project 3") With { _
                .BugsTotal = 9, _
                .IssuesTotal = 20 _
            }
            project3.IssuesData.AddRange(New Point() { _
                New Point(0, 18), _
                New Point(1, 44), _
                New Point(2, 30), _
                New Point(3, 25), _
                New Point(4, 20) _
            })
            project3.BugsData.AddRange(New Point() { _
                New Point(0, 8), _
                New Point(1, 13), _
                New Point(2, 11), _
                New Point(3, 9), _
                New Point(4, 9) _
            })
            Dim project4 As New Project("Project 4") With { _
                .BugsTotal = 15, _
                .IssuesTotal = 26 _
            }
            project4.IssuesData.AddRange(New Point() { _
                New Point(0, 58), _
                New Point(1, 63), _
                New Point(2, 40), _
                New Point(3, 44), _
                New Point(4, 26) _
            })
            project4.BugsData.AddRange(New Point() { _
                New Point(0, 10), _
                New Point(1, 20), _
                New Point(2, 19), _
                New Point(3, 13), _
                New Point(4, 15) _
            })

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
                Return DirectCast(GetValue(TeamNameProperty), String)
            End Get
            Set(ByVal value As String)
                SetValue(TeamNameProperty, value)
            End Set
        End Property
        Public Property TeamLead() As Person
            Get
                Return DirectCast(GetValue(TeamLeadProperty), Person)
            End Get
            Set(ByVal value As Person)
                SetValue(TeamLeadProperty, value)
            End Set
        End Property
        Public Property Projects() As List(Of Project)
            Get
                Return DirectCast(GetValue(ProjectsProperty), List(Of Project))
            End Get
            Set(ByVal value As List(Of Project))
                SetValue(ProjectsProperty, value)
            End Set
        End Property
        Public Property Stuff() As List(Of Person)
            Get
                Return DirectCast(GetValue(StuffProperty), List(Of Person))
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
                Return DirectCast(GetValue(BugsDataProperty), ArrayList)
            End Get
            Set(ByVal value As ArrayList)
                SetValue(BugsDataProperty, value)
            End Set
        End Property
        Public Property IssuesData() As ArrayList
            Get
                Return DirectCast(GetValue(IssuesDataProperty), ArrayList)
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
