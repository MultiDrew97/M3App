Public Class SummaryCtrl
	<ComponentModel.Browsable(False)>
	<ComponentModel.Category("Data")>
	Property Display As Object
		Get
			Return pg_Summary.SelectedObject
		End Get
		Set(value As Object)
			pg_Summary.SelectedObject = value

			If Not IsNothing(value) Then
				pg_Summary.ExpandAllGridItems()
			End If
		End Set
	End Property

	' TODO: Create custom summary page for this. No controls provide desired look and feel

	'' Summary
	''	* Basics
	''		- Name:	Customer Name
	''		- Email: Customer Email
	'' * Address
	''		- Street: Customer Street Address
	''		- City: Customer City
	''		- State: Customer State
	''		- Zip Code: Customer Zip Code
End Class
