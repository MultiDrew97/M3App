Imports System.Windows.Forms

Public MustInherit Class DataGridViewImageButtonCell
	Inherits DataGridViewButtonCell

	Protected _ButtonImage As Drawing.Bitmap

	Property ButtonState As VisualStyles.PushButtonState

	Protected Sub New(image As Drawing.Bitmap)
		MyBase.FlatStyle = FlatStyle.Flat
		Me._ButtonImage = image
	End Sub

	'Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, elementState As DataGridViewElementStates, value As Object,
	' formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
	'	'MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

	'	' Draw the cell background, if specified.
	'	If (paintParts And DataGridViewPaintParts.Background).Equals(DataGridViewPaintParts.Background) Then
	'		Using CellBackground As New SolidBrush(cellStyle.BackColor)
	'			graphics.FillRectangle(CellBackground, cellBounds)
	'		End Using
	'	End If

	'	' Draw the cell borders, if specified.
	'	If (paintParts And DataGridViewPaintParts.Border).Equals(DataGridViewPaintParts.Border) Then
	'		PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle)
	'	End If

	'	' Because the area in which to draw the button needs to be known,
	'	' start with the current bounds of the cell and the rectangle
	'	' representing the borders (DataGridViewAdvancedBorderStyle)
	'	Dim ButtonArea As Rectangle = cellBounds,
	'		ButtonBorderAllowance As Rectangle = BorderWidths(advancedBorderStyle)

	'	' Because there are some adjustments to be made
	'	Dim ImageHeight As Integer = Math.Min(ButtonArea.Height, If(Me._ButtonImage Is Nothing, 9999I, Me._ButtonImage.Size.Height)),
	'		ImageWidth As Integer = Math.Min(ButtonArea.Width, If(Me._ButtonImage Is Nothing, 9999I, Me._ButtonImage.Width)),
	'		WidthDiff As Integer = CInt((cellBounds.Width - Math.Min(32I, ImageWidth)) / 2I) - ButtonBorderAllowance.Width,
	'		HeightDiff As Integer = CInt((cellBounds.Height - Math.Min(32I, ImageHeight)) / 2I) - ButtonBorderAllowance.Height

	'	' Because, now the borders are known, the area needs to be amended. Moving the
	'	' (X,Y) in and down allows for the top and left borders while shrinking height
	'	' and width allows for bottom and right
	'	With ButtonArea
	'		.X += ButtonBorderAllowance.X
	'		.Y += ButtonBorderAllowance.Y
	'		.Height -= (ButtonBorderAllowance.Height * 2)
	'		.Width -= (ButtonBorderAllowance.Width * 2)
	'	End With

	'	' Because this is where the image will be drawn
	'	Dim ImageArea As New Rectangle(ButtonArea.X + WidthDiff, ButtonArea.Y + HeightDiff, ImageWidth, ImageHeight)

	'	' Because the last step is to paint the button image
	'	ButtonRenderer.DrawButton(graphics, ButtonArea, Me._ButtonImage, ImageArea, False, Me.ButtonState)
	'End Sub

	'MustOverride Sub LoadImages()
End Class
Public Class DataGridViewImageButtonEditCell
	Inherits DataGridViewImageButtonCell

	Public Sub New()
		MyBase.New(My.Resources.edit)
	End Sub

	'Protected Overrides Sub Paint(graphics As Drawing.Graphics, clipBounds As Drawing.Rectangle, cellBounds As Drawing.Rectangle, rowIndex As Integer, elementState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
	'	MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
	'End Sub

	'Public Overrides Sub LoadImages()
	'	Throw New NotImplementedException()
	'End Sub
End Class

Public Class DataGridViewImageButtonDeleteCell
	Inherits DataGridViewImageButtonCell

	Public Sub New()
		MyBase.New(My.Resources.delete)
	End Sub

	'Protected Overrides Sub Paint(graphics As Drawing.Graphics, clipBounds As Drawing.Rectangle, cellBounds As Drawing.Rectangle, rowIndex As Integer, elementState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
	'	MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
	'End Sub

	'Public Overrides Sub LoadImages()
	'	Throw New NotImplementedException()
	'End Sub
End Class
