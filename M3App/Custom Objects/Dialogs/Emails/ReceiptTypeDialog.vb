Public Class ReceiptTypeDialog
	Public Enum ReceiptType
		Tithes
		Love
		Offering
		Other
	End Enum

	Public ReadOnly Property Amount As Double
		Get
			Return nud_Amount.Value
		End Get
	End Property

	Public Property ReceiptOption As ReceiptType

	Public ReadOnly Property OtherOption As String
		Get
			Return txt_Other.Text
		End Get
	End Property

	Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
		If rdo_Other.Checked AndAlso String.IsNullOrWhiteSpace(txt_Other.Text) Then
			MessageBox.Show("You must enter something that says what this receipt is for. Please enter a value or select a preset type.", "Select Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Rdo_Other_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Other.CheckedChanged
		If rdo_Other.Checked Then
			Me.Size = New Size(440, 419)
		Else
			Me.Size = New Size(440, 368)
		End If

		ReceiptOption = ReceiptType.OTHER
		lbl_Other.Visible = rdo_Other.Checked
		txt_Other.Visible = rdo_Other.Checked
	End Sub

	Private Sub TithesCheckedChanged(sender As Object, e As EventArgs) Handles rdo_Tithes.CheckedChanged
		ReceiptOption = ReceiptType.TITHES
	End Sub

	Private Sub LoveOfferingCheckedChanged(sender As Object, e As EventArgs) Handles rdo_LoveOffering.CheckedChanged
		ReceiptOption = ReceiptType.LOVE
	End Sub

	Private Sub OfferingCheckedChanged(sender As Object, e As EventArgs) Handles rdo_Offering.CheckedChanged
		ReceiptOption = ReceiptType.OFFERING
	End Sub
End Class
