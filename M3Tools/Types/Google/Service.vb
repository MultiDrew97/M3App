Namespace Types.GTools
	Public Interface IGoogleService(Of T)
		''' <summary>
		''' Gets the account information for the current user.
		''' </summary>
		''' <returns>The account info for the current user</returns>
		ReadOnly Property UserAccount As T
	End Interface
End Namespace