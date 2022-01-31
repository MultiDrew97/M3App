Public Class GifBitmap
	Private ReadOnly GifFrames As New List(Of GifFrame)
	Private PlayIndex As Integer = 0
	Private ReadOnly __picBox As Windows.Forms.PictureBox
	Private ReadOnly __timer As Windows.Forms.Timer
	Private __image As Drawing.Bitmap

	Sub New(ByRef timer As Windows.Forms.Timer, ByRef picBox As Windows.Forms.PictureBox, ByVal image As Drawing.Bitmap)
		__timer = timer
		__picBox = picBox
		__image = image
		ClearGifFrames()
		LoadGif()
	End Sub

	Friend Sub LoadGif()
		ClearGifFrames()
		StripGifFramesFromBitmap()
		__timer.Start()
	End Sub


	Friend Sub ClearGifFrames()
		__timer.Stop()
		For i As Integer = GifFrames.Count - 1 To 0 Step -1
			GifFrames(i).Frame.Dispose()
		Next
		GifFrames.Clear()
		PlayIndex = 0
	End Sub

	Public Sub Tick()
		__timer.Interval = GifFrames(PlayIndex).Delay
		__image = GifFrames(PlayIndex).Frame
		PlayIndex += 1
		If PlayIndex = GifFrames.Count Then PlayIndex = 0
	End Sub

	Public Sub Toggle()
		__timer.Enabled = Not __timer.Enabled
	End Sub

	Private Sub StripGifFramesFromBitmap()
		Const PIID_FRAMEDELAY As Integer = &H5100
		Dim fd As New Drawing.Imaging.FrameDimension(__image.FrameDimensionsList(0))
		Dim framecount As Integer = __image.GetFrameCount(fd)
		If framecount > 1 Then
			Dim fdv() As Byte = __image.GetPropertyItem(PIID_FRAMEDELAY).Value
			For i As Integer = 0 To framecount - 1
				Dim framedelay As Integer = (BitConverter.ToInt32(fdv, 4 * i)) * 10
				If framedelay = 0 Then framedelay = 90
				Try
					__picBox.Image.SelectActiveFrame(fd, i)
					GifFrames.Add(New GifFrame(__image, framedelay))
				Catch ex As Exception
					ClearGifFrames()
					Throw New Exceptions.GifException("An Unexpected Error Occurred Stripping Frame (" & i.ToString & "}")
					Exit For
				End Try
			Next
		Else
			Throw New Exceptions.GifException("The Gif file is not an animated type gif image.")
		End If
	End Sub

	Private Class GifFrame
		Public Property Frame As Drawing.Bitmap
		Public Property Delay As Integer

		Public Sub New(ByVal frm As Drawing.Bitmap, ByVal dly As Integer)
			Me.Frame = New Drawing.Bitmap(frm)
			Me.Delay = dly
		End Sub
	End Class
End Class
