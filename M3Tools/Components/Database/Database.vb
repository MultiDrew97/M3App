Option Strict On

'needed for database work
'got the database set up information from here
'https://support.microsoft.com/en-us/help/308656/how-to-open-a-sql-server-database-by-using-the-sql-server-net-data-pro
Imports System.ComponentModel

' TODO: Go through all functions and make sure that all schema values are present in database

Namespace Database

	Friend Enum ColumnSelection
		ID
		Email
		Stock
		Price
	End Enum

	Friend Class Database
		<SettingsBindable(True)>
		<DefaultValue("")>
		<Description("The username to use with the API calls")>
		Friend Property Username As String

		<PasswordPropertyText(True)>
		<SettingsBindable(True)>
		<DefaultValue("")>
		<Description("The password to use with the API calls")>
		Friend Property Password As String

		<SettingsBindable(True)>
		<DefaultValue("")>
		<Description("The URL value to use for API calls")>
		Friend Property BaseUrl As String

		Private ReadOnly Property Auth As String
			Get
				Return Convert.ToBase64String(Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"))
			End Get
		End Property

		'Sub New(username As String, password As String, Optional baseUrl As String = Nothing)
		'	Me.Username = username
		'	Me.Password = password
		'	Me.BaseUrl = baseUrl
		'End Sub

		Friend Sub Consume(method As Method, path As String, Optional payload As String = Nothing)
			Me.Consume(method, path, If(Not String.IsNullOrWhiteSpace(payload), Text.Encoding.UTF8.GetBytes(payload), Nothing))
		End Sub

		Private Sub Consume(method As Method, path As String, Optional payload As Byte() = Nothing)
			Dim req As Net.HttpWebRequest

			req = CType(Net.WebRequest.Create(BaseUrl + path), Net.HttpWebRequest)
			req.Method = method.ToString.ToUpper
			req.Accept = "application/json"
			req.Headers.Add(Net.HttpRequestHeader.Authorization, $"Basic {Auth}")

			If payload IsNot Nothing Then
				req.ContentType = "application/json"
				Using stream = req.GetRequestStream()
					stream.Write(payload, 0, payload.Count)
				End Using
			End If

			VerifyResponse(CType(req.GetResponseAsync().Result, Net.HttpWebResponse))
		End Sub

		Friend Function Consume(Of T)(method As Method, path As String, Optional payload As String = Nothing) As Task(Of T)
			Return Me.Consume(Of T)(method, path, If(Not String.IsNullOrWhiteSpace(payload), Text.Encoding.UTF8.GetBytes(payload), Nothing))
		End Function

		Private Function Consume(Of T)(method As Method, path As String, Optional payload As Byte() = Nothing) As Task(Of T)
			Dim req As Net.HttpWebRequest ', res As Net.HttpWebResponse

			req = CType(Net.WebRequest.Create(BaseUrl + path), Net.HttpWebRequest)
			req.Method = method.ToString.ToUpper
			req.Accept = "application/json"
			req.Headers.Add(Net.HttpRequestHeader.Authorization, $"Basic {Auth}")

			If payload IsNot Nothing Then
				req.ContentType = "application/json"
				Using stream = req.GetRequestStream()
					stream.Write(payload, 0, payload.Count)
				End Using
			End If

			Using res = VerifyResponse(CType(req.GetResponseAsync().Result, Net.HttpWebResponse))
				Return Task.FromResult(JSON.ConvertFromJSON(Of T)(New IO.StreamReader(res.GetResponseStream).ReadToEnd))
			End Using
		End Function

		Private Function VerifyResponse(res As Net.HttpWebResponse) As Net.HttpWebResponse
			Select Case res.StatusCode
				Case Net.HttpStatusCode.Unauthorized
					Throw New Exceptions.AuthorizationException(res.StatusDescription)
				Case Net.HttpStatusCode.NotFound
					Throw New Exceptions.PathNotFoundException(res.StatusDescription)
				Case Net.HttpStatusCode.Forbidden
					Throw New Exceptions.ApiException(res.StatusDescription)
				Case Else
					Return res
			End Select
		End Function
	End Class
End Namespace
