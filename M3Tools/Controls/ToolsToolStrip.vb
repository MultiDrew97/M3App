Imports System.ComponentModel
Imports NPOI.OpenXmlFormats.Spreadsheet
Imports SPPBC.M3Tools.Events.Customers
Imports System.Windows.Forms

<DefaultEvent("FilterChanged")>
Public Class ToolsToolStrip
	Inherits Windows.Forms.ToolStrip
	Public Event Import As EventHandler
	Public Event Add As EventHandler
	Public Event Email As EventHandler
	Public Event FilterChanged As EventHandler(Of String)

	Public WriteOnly Property Count As String
		Set(value As String)
			tsl_Count.Text = value
		End Set
	End Property

	<DefaultValue("")>
	Public Property ListType As String

	Private Property Filter As String
		Get
			Return tst_Filter.Text
		End Get
		Set(value As String)
			tst_Filter.Text = value
		End Set
	End Property

	Private Sub ImportEntries(sender As Object, e As EventArgs) Handles tsb_Import.Click
		RaiseEvent Import(sender, e)
	End Sub

	Private Sub AddEntry(sender As Object, e As EventArgs) Handles tsb_New.Click
		RaiseEvent Add(sender, e)
	End Sub

	Private Sub SendEmails(sender As Object, e As EventArgs) Handles tsb_Emails.Click
		RaiseEvent Email(sender, e)
	End Sub

	Private Sub FilterUpdated(sender As Object, e As EventArgs) Handles tst_Filter.TextChanged
		RaiseEvent FilterChanged(sender, Filter)
	End Sub

	Private Sub ToolsToolStrip_LayoutCompleted(sender As Object, e As EventArgs) Handles Me.LayoutCompleted
		If String.IsNullOrEmpty(ListType) Then
			Return
		End If

		tsb_New.ToolTipText = String.Format(tsb_New.ToolTipText, ListType)
		tsb_Import.ToolTipText = String.Format(tsb_Import.ToolTipText, ListType)
		tst_Filter.ToolTipText = String.Format(tst_Filter.ToolTipText, ListType)
	End Sub
End Class
