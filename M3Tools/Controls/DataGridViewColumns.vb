Imports System.Windows.Forms

Public MustInherit Class DataGridViewImageButtonColumn
	Inherits DataGridViewButtonColumn
	Property ButtonImage As Drawing.Bitmap

	Protected Sub New(cellTemplate As DataGridViewCell)
		Me.CellTemplate = cellTemplate
		Width = 22
		Resizable = DataGridViewTriState.False
	End Sub
End Class

Public Class DataGridViewImageButtonDeleteColumn
	Inherits DataGridViewImageButtonColumn

	Public Sub New()
		MyBase.New(New DataGridViewImageButtonDeleteCell())
	End Sub
End Class

Public Class DataGridViewImageButtonEditColumn
	Inherits DataGridViewImageButtonColumn

	Public Sub New()
		MyBase.New(New DataGridViewImageButtonEditCell())
	End Sub
End Class