Imports System.Windows.Forms

Namespace Dialogs
	Public Class EmailBodySelection
		Private ReadOnly Property Subject As String
			Get
				Select Case TabControl1.SelectedTab.Name
					Case tp_Templates.Name
						Return ts_Templates.TemplateSubject
					Case tp_Custom.Name
						Return CustomEmail1.Subject
					Case Else
						Return Nothing
				End Select
			End Get
		End Property

		Private ReadOnly Property Body As String
			Get
				Select Case TabControl1.SelectedTab.Name
					Case tp_Templates.Name
						Return ts_Templates.TemplateValue
					Case tp_Custom.Name
						Return CustomEmail1.Body
					Case Else
						Return Nothing
				End Select
			End Get
		End Property

		Private ReadOnly Property BodyType As String
			Get
				Select Case TabControl1.SelectedTab.Name
					Case tp_Templates.Name
						Return "html"
					Case tp_Custom.Name
						Return "plain"
					Case Else
						Return Nothing
				End Select
			End Get
		End Property

		ReadOnly Property Content As Types.GTools.EmailContent
			Get
				Return New Types.GTools.EmailContent(Subject, Body, BodyType)
			End Get
		End Property


		Private Sub FinishDialog(sender As Object, e As EventArgs) Handles OK_Button.Click
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub CancelDialog(sender As Object, e As EventArgs) Handles Cancel_Button.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub BodySelectorLoaded(sender As Object, e As EventArgs) Handles MyBase.Load
			'ts_Templates.AddRange(
			'	{
			'	New Types.Template() With {.Name = "Sermon", .Text = My.Resources.DefaultSermonEmail, .Subject = "New Sermon"},
			'	New Types.Template() With {.Name = "Reciept", .Text = My.Resources.DefaultReceiptEmail, .Subject = "Thank you"}
			'	})
			ts_Templates.Reload()
		End Sub

		Sub New(templates As Types.TemplateList)

			' This call is required by the designer.
			InitializeComponent()

			' Add any initialization after the InitializeComponent() call.
			ts_Templates.AddRange(templates)
		End Sub
	End Class
End Namespace