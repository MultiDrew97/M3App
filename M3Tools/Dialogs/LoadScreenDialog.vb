Imports System.ComponentModel
Imports System.Windows.Forms

Public Class LoadScreenDialog
	Private Event DataChanging As EventHandler

	Private WithEvents LoadScreen As LoadingScreen

	Private ReadOnly Property LoadingScreen As LoadingScreen
		Get
			If LoadScreen Is Nothing OrElse LoadScreen.IsDisposed Then
				LoadScreen = New LoadingScreen
			End If

			Return LoadScreen
		End Get
	End Property

	Public Property LoadText As String
		Get
			Return LoadingScreen.LoadText
		End Get
		Set(value As String)
			LoadingScreen.LoadText = value
		End Set
	End Property

	Public Property Image As Drawing.Bitmap
		Get
			Return LoadingScreen.Image
		End Get
		Set(value As Drawing.Bitmap)
			LoadingScreen.Image = value
		End Set
	End Property

	<DefaultValue(False)>
	Public Property Closable As Boolean
		Get
			Return LoadingScreen.Closable
		End Get
		Set(value As Boolean)
			LoadingScreen.Closable = value
		End Set
	End Property

	Private Sub DialogClosed(sender As Object, e As EventArgs) Handles LoadScreen.DialogClosing
		'LoadScreen.Close()
		'__loadScreen = Nothing
	End Sub

	Public Function ShowDialog() As DialogResult
		LoadingScreen.Show()
	End Function

	Private Sub DialogDisposed(sender As Object, e As EventArgs) Handles Me.Disposed
		If LoadScreen IsNot Nothing Then
			LoadingScreen.Close()
			LoadingScreen.Dispose()
		End If
	End Sub

	Public Sub ShowError(message As String)
		Image = My.Resources.ErrorImage
		LoadText = message
	End Sub
End Class
