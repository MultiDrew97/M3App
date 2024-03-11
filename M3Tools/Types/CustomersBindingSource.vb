Imports System.ComponentModel

Namespace Types
	Public Class CustomersBindingSource
		Inherits Windows.Forms.BindingSource

		Private ReadOnly _customers As New CustomersCollection

		Shadows ReadOnly Property SupportsFiltering As Boolean = True

		Shadows ReadOnly Property DataSource As CustomersCollection
			Get
				If DesignMode Then
					Return New CustomersCollection From {
						New Customer()
					}
				End If

				Return _customers
			End Get
		End Property

		'Sub New()
		'	'MyBase.New(New CustomersCollection(), String.Empty)
		'	MyBase.New()
		'	DataSource = _customers
		'	ResetBindings(False)
		'End Sub

		Shadows Property Filter As String
			Get
				Return MyBase.Filter
			End Get
			Set(value As String)
				'If Not String.IsNullOrEmpty(value) Then
				'	value = $"[Name] like '%{value}%' OR [Email] like '%{value}%'"
				'End If

				MyBase.Filter = value
				_customers.Filter = value
			End Set
		End Property
	End Class
End Namespace
