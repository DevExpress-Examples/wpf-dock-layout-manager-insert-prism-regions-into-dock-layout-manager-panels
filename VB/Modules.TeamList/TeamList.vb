Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Modules.Infrastructure

Namespace Modules.TeamList
	Public Class TeamList
		Shared Sub New()
			Teams = Modules.Infrastructure.TeamList.CreateSampleData()
		End Sub
		Public Shared Teams As List(Of Team)
	End Class
End Namespace
