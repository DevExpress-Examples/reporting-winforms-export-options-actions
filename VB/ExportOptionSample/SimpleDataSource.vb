Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ExportOptionSample
	Public Class SimpleData
		Public Property ID() As Integer
		Public Property Name() As String
		Public Property Age() As Integer

		Public Function GetData() As List(Of SimpleData)
			Dim rand = New Random()
			Dim list As New List(Of SimpleData)()
			For i As Integer = 0 To 99
				list.Add(New SimpleData() With {
					.ID = i,
					.Name = "Name " & i,
					.Age = rand.Next(18, 45)
				})
			Next i
			Return list
		End Function
	End Class
End Namespace
