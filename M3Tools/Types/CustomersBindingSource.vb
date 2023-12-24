Imports System.ComponentModel

Namespace Types
	Public Class CustomersBindingSource
		Inherits Windows.Forms.BindingSource

		Sub New()
			MyBase.New(New CustomersCollection(), String.Empty)
			ResetBindings(False)
		End Sub
	End Class
End Namespace
