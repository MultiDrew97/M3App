Option Strict On

'needed for database work
'got the database set up information from here
'https://support.microsoft.com/en-us/help/308656/how-to-open-a-sql-server-database-by-using-the-sql-server-net-data-pro
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MathNet.Numerics.LinearAlgebra.Factorization
Imports System.Security.Policy
Imports System.Text.Json

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
		Property Password As String

		<SettingsBindable(True)>
		<DefaultValue("")>
		<Description("The URL value to use for API calls")>
		Friend Property BaseUrl As String

		Private ReadOnly Property Auth As String
			Get
				Return Convert.ToBase64String(Text.Encoding.UTF8.GetBytes($"{Username}:{Password}"))
			End Get
		End Property

		Sub New(username As String, password As String, Optional baseUrl As String = Nothing)
			Me.Username = username
			Me.Password = password
			Me.BaseUrl = baseUrl
		End Sub

		Friend Function Consume(Of T)(method As M3API.Method, path As String, Optional payload As String = Nothing) As Task(Of T)
			Dim req As Net.HttpWebRequest, res As Net.HttpWebResponse

			req = CType(Net.WebRequest.Create(BaseUrl + path), Net.HttpWebRequest)
			req.Method = method.ToString.ToUpper
			req.Accept = "application/json"
			req.Headers.Add(Net.HttpRequestHeader.Authorization, $"Basic {Auth}")

			If Not String.IsNullOrWhiteSpace(payload) Then
				req.ContentType = "application/json"
				Using stream = req.GetRequestStream()
					stream.Write(Text.Encoding.UTF8.GetBytes(payload), 0, Text.Encoding.UTF8.GetByteCount(payload))
				End Using
			End If

			res = CType(req.GetResponseAsync().Result, Net.HttpWebResponse)

			Return Task.FromResult(JSON.ConvertFromJSON(Of T)(New IO.StreamReader(res.GetResponseStream).ReadToEnd))
		End Function
	End Class
End Namespace