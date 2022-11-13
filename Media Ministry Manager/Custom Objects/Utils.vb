Option Strict On

Imports SPPBC.M3Tools

Namespace Helpers
	Public Structure Utils
		Shared Sub Wait(ByVal seconds As Integer)
			'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

			For i As Integer = 0 To seconds * 100
				Threading.Thread.Sleep(10)
				Application.DoEvents()
			Next
		End Sub

		Shared Sub CloseOpenForms()
			'Close all open windows. Figuring this out will allow me to change from only clearing when primary form closes to when all forms close.
			'improving efficiency in memory management
			Dim attempts = 0
			Do
				Try
					My.Application.OpenForms(0).Close()
					attempts = 0
				Catch ex As InvalidOperationException
					Console.WriteLine("Form of name {0} falied to close", My.Application.OpenForms(0).Name)
					attempts += 1
				End Try
			Loop While My.Application.OpenForms.Count > 0 And attempts < 3
		End Sub

		Shared Sub Logout()
			My.Settings.Username = ""
			My.Settings.Password = ""
			My.Settings.KeepLoggedIn = False
			My.Settings.Save()
			Frm_Login.Show()
		End Sub

		Shared Sub SpecialClose(sender As Object)
			Dim temp As New MainMenuStrip()
			If Not sender.GetType() = temp.GetType Then
				Frm_Main.Show()
			End If

			temp.Dispose()
		End Sub
	End Structure
End Namespace
