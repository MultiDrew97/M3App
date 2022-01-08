Public Class GenericInputPair
    Public Shadows Event TextChanged As EventHandler

    Public Property LabelText As String
        Get
            Return lbl_InputLabel.Text
        End Get
        Set(value As String)
            lbl_InputLabel.Text = value
        End Set
    End Property

    Public ReadOnly Property TextLength As Integer
        Get
            Return txt_Input.TextLength
        End Get
    End Property

    Public Property Mask As String
        Get
            Return txt_Input.Mask
        End Get
        Set(value As String)
            txt_Input.Mask = value
        End Set
    End Property

    Public Property UseSystemPasswordChar As Boolean
        Get
            Return txt_Input.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            txt_Input.UseSystemPasswordChar = value
        End Set
    End Property

    Public Shadows Property Text As String
        Get
            Return txt_Input.Text
        End Get
        Set(value As String)
            txt_Input.Text = value
        End Set
    End Property

    Public Property TextAlign As Windows.Forms.HorizontalAlignment
        Get
            Return txt_Input.TextAlign
        End Get
        Set(value As Windows.Forms.HorizontalAlignment)
            txt_Input.TextAlign = value
        End Set
    End Property

	Private Sub InputTextChanged(sender As Object, e As EventArgs) Handles txt_Input.TextChanged
		RaiseEvent TextChanged(Me, e)
	End Sub
End Class
