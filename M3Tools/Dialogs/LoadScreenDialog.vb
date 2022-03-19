Imports System.Windows.Forms

Public Class LoadScreenDialog
	Private Event DataChanging As EventHandler

	Private WithEvents LoadScreen As LoadingScreen

	ReadOnly Property LoadingScreen As LoadingScreen
		Get
			If LoadScreen Is Nothing Or LoadScreen.IsDisposed Then
				LoadScreen = New LoadingScreen
				'ElseIf _loadScreen.IsDisposed Then
				'	_loadScreen = New LoadingScreen
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

	Public Property Closable As Boolean
		Get
			Return LoadingScreen.Closable
		End Get
		Set(value As Boolean)
			LoadingScreen.Closable = value
		End Set
	End Property

	Private Sub DialogClosed(sender As Object, e As EventArgs) Handles LoadScreen.DialogClosing
		LoadScreen.Close()
		'__loadScreen = Nothing
	End Sub

	Public Function ShowDialog() As DialogResult
		LoadingScreen.Show()
	End Function

	Private Sub LoadingScreen_Closing(sender As Object, e As EventArgs) Handles Me.Disposed
		If LoadScreen IsNot Nothing Then
			LoadingScreen.Close()
			LoadingScreen.Dispose()
		End If
	End Sub

	Private Sub LoadScreen_Disposed(sender As Object, e As EventArgs) Handles LoadScreen.Disposed

	End Sub

	Private Sub LoadScreenDialog_DataChanging(sender As Object, e As EventArgs) Handles Me.DataChanging

	End Sub
End Class
