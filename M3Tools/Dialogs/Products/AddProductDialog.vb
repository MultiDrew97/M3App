Imports System.Windows.Forms

Namespace Dialogs
	Public Class AddProductDialog

		Public ReadOnly Property Item As Types.Item

		Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
			Me.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
			Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.Close()
		End Sub

	End Class
End Namespace
