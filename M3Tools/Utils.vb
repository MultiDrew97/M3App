Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Windows.Forms

Public Structure Utils
	Shared Function ToSecureString(password As String) As SecureString
		Dim secureString As New SecureString()

		For Each ch As Char In password
			secureString.AppendChar(ch)
		Next

		secureString.MakeReadOnly()

		Return secureString
	End Function

	Shared ReadOnly Property DefaultFileName(fileName As String) As String
		Get
			Return fileName.Split(CType("\\", Char()))(fileName.Split(CType("\\", Char())).Length - 1).Split(CType(".", Char()))(0) + " " + DateTime.UtcNow.ToString("MM/dd/yyyy")
		End Get
	End Property

	Shared Sub Wait(Optional seconds As Integer = 5)
		'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

		For i As Integer = 0 To seconds * 100
			Threading.Thread.Sleep(10)
			Application.DoEvents()
		Next
	End Sub

	Shared Function ToUnsecureString(password As SecureString) As String
		Dim returnValue = IntPtr.Zero
		Try
			returnValue = Marshal.SecureStringToGlobalAllocUnicode(password)
			Return Marshal.PtrToStringUni(returnValue)
		Catch ex As Exception
			Marshal.ZeroFreeGlobalAllocUnicode(returnValue)
			Return String.Join(": ", {"Error", password.Length})
		End Try
	End Function
End Structure
