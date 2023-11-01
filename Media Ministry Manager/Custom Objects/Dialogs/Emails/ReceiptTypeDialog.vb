Public Class ReceiptTypeDialog

	Public Shared Amount As Double
	Public Shared Type As String

	Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
		If rdo_Other.Checked Then
			If String.IsNullOrWhiteSpace(txt_Other.Text) Then
				MessageBox.Show("You must enter something that says what this receipt is for. Please enter a value or select a preset type.", "Select Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End If

		Type = txt_Other.Text
		Amount = nud_Amount.Value

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

		lbl_Other.Visible = rdo_Other.Checked
		txt_Other.Visible = rdo_Other.Checked
	End Sub

	Private Sub TithesCheckedChanged(sender As Object, e As EventArgs) Handles rdo_Tithes.CheckedChanged
		Type = "Tithes"
	End Sub

	Private Sub LoveOfferingCheckedChanged(sender As Object, e As EventArgs) Handles rdo_LoveOffering.CheckedChanged
		Type = "Love Offering"
	End Sub

	Private Sub OfferingCheckedChanged(sender As Object, e As EventArgs) Handles rdo_Offering.CheckedChanged
		Type = "Offering"
	End Sub
End Class
