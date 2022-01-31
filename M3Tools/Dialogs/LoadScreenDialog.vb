Imports System.Windows.Forms

Public Class LoadScreenDialog
	Private Event DataChanging As EventHandler

	Private WithEvents __loadScreen As LoadingScreen

	ReadOnly Property LoadScreen As LoadingScreen
		Get
			If __loadScreen Is Nothing Then
				__loadScreen = New LoadingScreen
			ElseIf __loadScreen.IsDisposed Then
				__loadScreen = New LoadingScreen
			End If

			Return __loadScreen
		End Get
	End Property

	Public Property LoadText As String
		Get
			Return LoadScreen.LoadText
		End Get
		Set(value As String)
			LoadScreen.LoadText = value
		End Set
	End Property

	Public Property Image As Drawing.Bitmap
		Get
			Return LoadScreen.Image
		End Get
		Set(value As Drawing.Bitmap)
			LoadScreen.Image = value
		End Set
	End Property

	Public Property Closable As Boolean
		Get
			Return LoadScreen.Closable
		End Get
		Set(value As Boolean)
			LoadScreen.Closable = value
		End Set
	End Property

	Private Sub DialogClosed(sender As Object, e As EventArgs) Handles __loadScreen.DialogClosing
		__loadScreen.Close()
		'__loadScreen = Nothing
	End Sub

	Public Function ShowDialog() As DialogResult
		LoadScreen.Show()
	End Function

	Private Sub LoadingScreen_Closing(sender As Object, e As EventArgs) Handles Me.Disposed
		If __loadScreen IsNot Nothing Then
			LoadScreen.Close()
			LoadScreen.Dispose()
		End If
	End Sub

	Private Sub LoadScreen_Disposed(sender As Object, e As EventArgs) Handles __loadScreen.Disposed

	End Sub

	Private Sub LoadScreenDialog_DataChanging(sender As Object, e As EventArgs) Handles Me.DataChanging

	End Sub
End Class
