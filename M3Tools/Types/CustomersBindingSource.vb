Imports System.ComponentModel

Namespace Types
	Public Class CustomersBindingSource
		Inherits Windows.Forms.BindingSource

		Sub New()
			'MyBase.New(GetType(CustomersCollection), String.Empty)
			MyBase.New(New CustomersCollection(), String.Empty)
			'DataSource = New CustomersCollection()
			'ResetBindings(False)
		End Sub

		Sub New(container As IContainer)
			MyBase.New(container)
		End Sub

		Private Sub RefreshBindings(sender As Object, e As ListChangedEventArgs) Handles Me.ListChanged
			Console.WriteLine("Customers ListChanged")
		End Sub
	End Class
End Namespace
