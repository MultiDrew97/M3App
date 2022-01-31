Imports System.ComponentModel

Public NotInheritable Class LoadingScreen

	'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
	'  of the Project Designer ("Properties" under the "Project" menu).
	Event TextChange As EventHandler
	Event ClosableChanged As EventHandler
	Friend Event DialogClosing As EventHandler

	Private __closable As Boolean = False
	'Private __gifBitmap As GifBitmap

	Property LoadText As String
		Get
			Return lbl_LoadText.Text
		End Get
		Set(value As String)
			lbl_LoadText.Text = value
			RaiseEvent TextChange(Me, New EventArgs)
		End Set
	End Property

	Property Closable As Boolean
		Get
			Return __closable
		End Get
		Set(value As Boolean)
			__closable = value
			RaiseEvent ClosableChanged(Me, New EventArgs)
		End Set
	End Property

	Public Property Image As Drawing.Bitmap
		Get
			Return CType(pic_Load.Image, Drawing.Bitmap)
		End Get
		Set(value As Drawing.Bitmap)
			pic_Load.Image = value
			'If value.RawFormat.Guid = Drawing.Imaging.ImageFormat.Gif.Guid Then
			'	tmr_Timer.Enabled = True
			'	__gifBitmap.ClearGifFrames()
			'	__gifBitmap.LoadGif()
			'Else
			'	tmr_Timer.Enabled = False
			'End If
		End Set
	End Property

	Private Sub LoadingScreen_ClosableChanged(sender As Object, e As EventArgs) Handles Me.ClosableChanged
		Opacity = 100
		btn_Close.Enabled = __closable
		btn_Close.Visible = __closable
		UseWaitCursor = Not __closable
		'__gifBitmap.Toggle()
	End Sub

	Private Sub TimerTicking(sender As Object, e As EventArgs) Handles tmr_Timer.Tick
		'__gifBitmap.Tick()
	End Sub

	'Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
	'	'__gifBitmap = New GifBitmap(tmr_Timer, pic_Loading) ', My.Resources.Loading_Loop_3)
	'End Sub

	Public Sub CloseScreen(sender As Object, e As EventArgs) Handles btn_Close.Click
		Me.Close()
		RaiseEvent DialogClosing(Me, New EventArgs)
	End Sub

	Friend Sub Reset()
		LoadText = ""
		Closable = False
		Image = My.Resources.Loading_Loop_3
	End Sub
End Class
