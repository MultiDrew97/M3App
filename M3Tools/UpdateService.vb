Imports System.ServiceProcess

Public Class UpdateService

	Protected Overrides Sub OnStart(ByVal args() As String)
		' Add code here to start your service. This method should set things
		' in motion so your service can do its work.
		If UpdateAvailable() Then
			wb_Updater.Url = New Uri(My.Resources.AppUpdateUri)
		End If
	End Sub

	Protected Overrides Sub OnStop()
		' Add code here to perform any tear-down necessary to stop your service.
	End Sub

	Private Function UpdateAvailable() As Boolean
		wb_Updater.Url = New Uri(My.Resources.LatestAppVersionUri)
		Console.WriteLine(wb_Updater.DocumentText)
		Return False
	End Function
End Class
