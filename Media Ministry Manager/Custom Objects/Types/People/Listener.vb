Option Strict On

Namespace Types
    Public Class Listener
        Inherits Person
        Public Property EmailAddress As MimeKit.MailboxAddress

		Public Sub New(listenerID As Integer, firstName As String, lastName As String, Optional email As String = "")
			MyBase.New(listenerID, firstName, lastName)
			Me.EmailAddress = New MimeKit.MailboxAddress(Me.Name, email)
		End Sub
	End Class
End Namespace