Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Public Class MyItem
	Private id_Renamed As String
	Private contactName_Renamed As String
	Private groupText_Renamed As String

	Public Sub New(ByVal id As String, ByVal contactName As String, ByVal groupText As String)
		Me.id_Renamed = id
		Me.contactName_Renamed = contactName
		Me.groupText_Renamed = groupText
	End Sub
	Public ReadOnly Property ID() As String
		Get
			Return id_Renamed
		End Get
	End Property
	Public ReadOnly Property ContactName() As String
		Get
			Return contactName_Renamed
		End Get
	End Property
	Public ReadOnly Property GroupText() As String
		Get
			Return groupText_Renamed
		End Get
	End Property
End Class


Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim items As New ArrayList()

		Dim data As IEnumerable = AccessDataSource1.Select(New DataSourceSelectArguments())
		For Each item As Object In data
			Dim row As DataRowView = TryCast(item, DataRowView)
			Dim id As String = row("CustomerId").ToString()
			Dim s As String = row("ContactName").ToString().ToUpper()
			Dim groupText As String = "?"
			If (Not String.IsNullOrEmpty(s)) Then
				Dim c As Char = s.Substring(0, 1)(0)
				If "A"c <= c AndAlso c <= "F"c Then
					groupText = "A-F"
				ElseIf "G"c <= c AndAlso c <= "M"c Then
					groupText = "G-M"
				ElseIf "N"c <= c AndAlso c <= "S"c Then
					groupText = "N-S"
				ElseIf "T"c <= c AndAlso c <= "Z"c Then
					groupText = "T-Z"
				End If
			End If
			items.Add(New MyItem(id, s, groupText))

		Next item

		ASPxTitleIndex1.DataSource = items
		ASPxTitleIndex1.DataBind()
	End Sub
End Class
