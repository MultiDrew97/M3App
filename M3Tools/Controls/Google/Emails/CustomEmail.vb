Imports System.Windows.Forms

Public Class CustomEmail
	Private Structure Shortcuts
		Shared Bold As String = "Bold"
		Shared Underline As String = "Underline"
		Shared Italics As String = "Italics"
	End Structure

	Public Property Subject As String
		Get
			Return ip_Subject.Text
		End Get
		Set(value As String)
			ip_Subject.Text = value
		End Set
	End Property

	Public Property Body As String()
		Get
			Return rtb_Body.Lines
		End Get
		Set(value As String())
			rtb_Body.Lines = value
		End Set
	End Property

	Public ReadOnly Property RichTextBody As String
		Get
			Return rtb_Body.Rtf
		End Get
	End Property

	Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		rtb_Body.SelectionFont = fd_Font.Font
		btn_Bold.Checked = fd_Font.Font.Bold
		btn_Italics.Checked = fd_Font.Font.Italic
		btn_Underline.Checked = fd_Font.Font.Underline
	End Sub

	Private Sub ChangeFont(sender As Object, e As EventArgs) Handles btn_ChangeFont.Click
		If fd_Font.ShowDialog = DialogResult.OK Then
			rtb_Body.Font = fd_Font.Font
			btn_Bold.Checked = fd_Font.Font.Bold
			btn_Italics.Checked = fd_Font.Font.Italic
			btn_Underline.Checked = fd_Font.Font.Underline
		End If
	End Sub

	Private Sub BoldText(sender As Object, e As EventArgs) Handles btn_Bold.Click, Bold.Click
		Dim fontStyle = GetCurrentFontStyle()

		If Not rtb_Body.SelectionFont.Bold Then
			fontStyle += Drawing.FontStyle.Bold
		Else
			fontStyle -= Drawing.FontStyle.Bold
		End If

		rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, CType(fontStyle, Drawing.FontStyle))
	End Sub

	Private Sub BoldShortcut(sender As Object, e As EventArgs) Handles Bold.Click, Underline.Click, Italics.Click
		Dim name = CType(sender, ToolStripMenuItem).Name

		Select Case name
			Case Shortcuts.Bold
				btn_Bold.Checked = Not btn_Bold.Checked
			Case Shortcuts.Underline
				btn_Underline.Checked = Not btn_Underline.Checked
			Case Shortcuts.Italics
				btn_Italics.Checked = Not btn_Italics.Checked
		End Select
	End Sub

	Private Sub UnderlineText(sender As Object, e As EventArgs) Handles btn_Underline.Click, Underline.Click
		Dim fontStyle = GetCurrentFontStyle()

		If Not rtb_Body.SelectionFont.Underline Then
			fontStyle += Drawing.FontStyle.Underline
		Else
			fontStyle -= Drawing.FontStyle.Underline
		End If

		rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, CType(fontStyle, Drawing.FontStyle))

	End Sub

	Private Sub ItalicizeText(sender As Object, e As EventArgs) Handles btn_Italics.Click, Italics.Click
		Dim fontStyle = GetCurrentFontStyle()

		If Not rtb_Body.SelectionFont.Italic Then
			fontStyle += Drawing.FontStyle.Italic
		Else
			fontStyle -= Drawing.FontStyle.Italic
		End If

		rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, CType(fontStyle, Drawing.FontStyle))

	End Sub

	Private Function GetCurrentFontStyle() As Integer
		Dim fontStyle As Integer

		If rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Italic And rtb_Body.SelectionFont.Bold Then
			fontStyle = Drawing.FontStyle.Italic + Drawing.FontStyle.Underline + Drawing.FontStyle.Bold
		ElseIf rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Italic Then
			fontStyle = Drawing.FontStyle.Underline + Drawing.FontStyle.Italic
		ElseIf rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Bold Then
			fontStyle = Drawing.FontStyle.Underline + Drawing.FontStyle.Bold
		ElseIf rtb_Body.SelectionFont.Italic And rtb_Body.SelectionFont.Bold Then
			fontStyle = Drawing.FontStyle.Italic + Drawing.FontStyle.Bold
		ElseIf rtb_Body.SelectionFont.Underline Then
			fontStyle = Drawing.FontStyle.Underline
		ElseIf rtb_Body.SelectionFont.Italic Then
			fontStyle = Drawing.FontStyle.Italic
		ElseIf rtb_Body.SelectionFont.Bold Then
			fontStyle = Drawing.FontStyle.Bold
		Else
			fontStyle = 0
		End If

		Return fontStyle
	End Function
End Class
