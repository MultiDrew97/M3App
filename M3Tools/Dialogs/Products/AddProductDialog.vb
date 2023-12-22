Imports System.Windows.Forms
Imports SPPBC.M3Tools.Events.Inventory

Namespace Dialogs
	Public Class AddProductDialog
		Public Event ItemAdded As InventoryEventHandler
		Private Event PageChangedEvent As EventHandler

		Private ReadOnly Property ItemName As String
			Get
				Return txt_Name.Text
			End Get
		End Property

		Private ReadOnly Property ItemStock As Integer
			Get
				Return CInt(nud_Stock.Value)
			End Get
		End Property
		Private ReadOnly Property ItemPrice As Double
			Get
				Return CDec(txt_Price.Text)
			End Get
		End Property
		Private ReadOnly Property ItemAvailable As Boolean
			Get
				Return ItemPrice > 0 Or chk_Available.Checked
			End Get
		End Property

		Private ReadOnly Property ItemDescription As String
			Get
				Return rtb_Description.Text
			End Get
		End Property

		Private ReadOnly Property ValidProduct() As Boolean
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property Product As Types.Product
			Get
				Return New Types.Product(-1, ItemName, ItemStock, ItemPrice, ItemAvailable)
			End Get
		End Property

		Private Sub PreviousStep(sender As Object, e As EventArgs) Handles btn_Cancel.Click
			Select Case tc_Creation.SelectedIndex
				Case tp_Basics.TabIndex
					Dim res = MessageBox.Show("Are you sure you want to cancel product creation?", "Cancel Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

					If Not res = DialogResult.Yes Then
						Exit Sub
					End If

					DialogResult = DialogResult.Cancel
					Close()
				Case Else
					tc_Creation.SelectedIndex -= 1
					RaiseEvent PageChangedEvent(Me, e)
			End Select
		End Sub

		Private Sub NextStep(sender As Object, e As EventArgs) Handles btn_Create.Click
			Select Case tc_Creation.SelectedIndex
				Case tp_Summary.TabIndex
					If Not ValidProduct Then
						MessageBox.Show("There were errors in your product submission. Please try again.", "Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If

					RaiseEvent ItemAdded(Me, New InventoryEventArgs(Product, M3Tools.Events.EventType.Added))

					DialogResult = DialogResult.OK
					Close()
				Case Else
					tc_Creation.SelectedIndex += 1
					RaiseEvent PageChangedEvent(Me, e)
			End Select
		End Sub

		Private Sub PageChanged(sender As Object, e As EventArgs) Handles Me.PageChangedEvent, tc_Creation.SelectedIndexChanged
			btn_Cancel.Text = If(tc_Creation.SelectedIndex <= tp_Basics.TabIndex, "Cancel", "Back")
			btn_Create.Text = If(tc_Creation.SelectedIndex >= tp_Summary.TabIndex, "Create", "Next")
			sc_Summary.Display = If(tc_Creation.SelectedIndex = tp_Summary.TabIndex, Product, Nothing)
		End Sub
	End Class
End Namespace
