Imports System.ComponentModel

Public Class GenericInputPair
	Public Shadows Event TextChanged As EventHandler

	<DefaultValue("Label1")>
	Public Property LabelText As String
		Get
			Return lbl_InputLabel.Text
		End Get
		Set(value As String)
			lbl_InputLabel.Text = value
		End Set
	End Property

	Public ReadOnly Property TextLength As Integer
		Get
			Return txt_Input.TextLength
		End Get
	End Property

	Public Property Mask As String
		Get
			Return txt_Input.Mask
		End Get
		Set(value As String)
			txt_Input.Mask = value
		End Set
	End Property

	<DefaultValue(False)>
	Public Property UseSystemPasswordChar As Boolean
		Get
			Return txt_Input.UseSystemPasswordChar
		End Get
		Set(value As Boolean)
			txt_Input.UseSystemPasswordChar = value
		End Set
	End Property

	Public Overrides Property Text As String
		Get
			Return If(txt_Input.Text <> Placeholder, txt_Input.Text, "")
		End Get
		Set(value As String)
			txt_Input.Text = If(value <> Placeholder AndAlso value <> "", value, Placeholder)
		End Set
	End Property

	Public Property TextAlign As Windows.Forms.HorizontalAlignment
		Get
			Return txt_Input.TextAlign
		End Get
		Set(value As Windows.Forms.HorizontalAlignment)
			txt_Input.TextAlign = value
		End Set
	End Property

	<DefaultValue(False)>
	Public Property [ReadOnly] As Boolean
		Get
			Return txt_Input.ReadOnly
		End Get
		Set(value As Boolean)
			txt_Input.ReadOnly = value
		End Set
	End Property

	<DefaultValue("Input...")>
	Public Property Placeholder As String = "Input..."

	Private Sub InputTextChanged(sender As Object, e As EventArgs) Handles txt_Input.TextChanged
		' TODO: Potentially move placeholder/color logic here?

		RaiseEvent TextChanged(Me, e)
	End Sub

	Private Sub InputGotFocus(sender As Object, e As EventArgs) Handles txt_Input.GotFocus
		If txt_Input.Text <> Placeholder Then
			Return
		End If

		txt_Input.Text = ""
		txt_Input.ForeColor = Drawing.SystemColors.WindowText
	End Sub

	Private Sub InputLostFocus(sender As Object, e As EventArgs) Handles txt_Input.LostFocus
		If txt_Input.Text <> "" Then
			Return
		End If

		txt_Input.Text = Placeholder
		txt_Input.ForeColor = Drawing.SystemColors.ControlDark
	End Sub

	Private Sub GenericInputPair_Load(sender As Object, e As EventArgs) Handles Me.Load
		Text = If(Text <> "", Text, Placeholder)
		txt_Input.ForeColor = If(Text <> "", Drawing.SystemColors.WindowText, Drawing.SystemColors.ControlDark)
	End Sub
End Class
