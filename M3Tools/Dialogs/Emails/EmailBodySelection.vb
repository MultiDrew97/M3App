Imports System.Windows.Forms

Namespace Dialogs
	Public Class EmailBodySelection
		Private ReadOnly Property Subject As String
			Get
				Select Case TabControl1.SelectedIndex
					Case tp_Templates.TabIndex
						Return ts_Templates.TemplateSubject
					Case tp_Custom.TabIndex
						Return CustomEmail1.Subject
					Case Else
						Return Nothing
				End Select
			End Get
		End Property

		Private ReadOnly Property Body As String
			Get
				Select Case TabControl1.SelectedIndex
					Case tp_Templates.TabIndex
						Return ts_Templates.TemplateValue
					Case tp_Custom.TabIndex
						Return CustomEmail1.Body
					Case Else
						Return Nothing
				End Select
			End Get
		End Property

		Private ReadOnly Property BodyType As Types.GTools.EmailType
			Get
				Select Case TabControl1.SelectedIndex
					Case tp_Templates.TabIndex
						Return Types.GTools.EmailType.HTML
					Case tp_Custom.TabIndex
						Return Types.GTools.EmailType.PLAIN
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

		WriteOnly Property Templates As Types.TemplateList
			Set(templates As Types.TemplateList)
				ts_Templates.AddRange(templates)
			End Set
		End Property


		Private Sub FinishDialog(sender As Object, e As EventArgs) Handles OK_Button.Click
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub CancelDialog(sender As Object, e As EventArgs) Handles Cancel_Button.Click
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub Reload() Handles MyBase.Load
			ts_Templates.Reload()
		End Sub
	End Class
End Namespace
