Option Strict On

'needed for database work
'got the database set up information from here
'https://support.microsoft.com/en-us/help/308656/how-to-open-a-sql-server-database-by-using-the-sql-server-net-data-pro
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security

Namespace Database
    Friend Class Database
        Implements IDisposable

        Private __connection As SqlConnection
		Private ReadOnly __command As SqlCommand
		Private ReadOnly __connectionString As New SqlConnectionStringBuilder(My.Resources.DefaultConnectionString)

		<Description("The username to use for the database connection")>
		<SettingsBindable(True)>
		Friend Property Username As String
            Get
                Return __connectionString.UserID
            End Get
            Set(value As String)
                __connectionString.UserID = value
            End Set
        End Property

		<PasswordPropertyText(True)>
		<Description("The password to use for the database connection")>
		<SettingsBindable(True)>
		Friend Property Password As String
            Get
                Return __connectionString.Password
                'Return If(__connectionString.Password <> String.Empty, __mask, String.Empty)
            End Get
            Set(value As String)
                'Dim temp = If(value <> String.Empty And value <> __mask, value, My.Settings.DefaultPassword)
                'Console.WriteLine(temp)
                '__connectionString.Password = temp
                __connectionString.Password = value
            End Set
        End Property

		<Description("The initial catalog to use for the database connection")>
		<SettingsBindable(True)>
		Friend Property InitialCatalog As String
            Get
                Return __connectionString.InitialCatalog
            End Get
            Set(value As String)
                __connectionString.InitialCatalog = value
            End Set
        End Property

		Sub New(username As String, password As String, Optional catalog As String = Nothing)
			Me.Username = username
			Me.Password = password
			InitialCatalog = If(catalog, My.Resources.DefaultCatalog)
		End Sub

		Public Function Connect(Optional connectionString As String = Nothing) As SqlCommand
			'Connect to the database that I have createed for Media Ministry
			__connection = New SqlConnection(If(connectionString, __connectionString.ConnectionString))

			''create the command object that will be used for queriying the server
			'myCmd = myConn.CreateCommand

			'open the connection
			__connection.Open()

			Return __connection.CreateCommand()
		End Function

		Public Sub Close()
            'close connection
            If __connection IsNot Nothing Then
                __connection.Close()
                __connection.Dispose()
            End If

            If __command IsNot Nothing Then
                __command.Dispose()
            End If

            Dispose(True)
        End Sub
    End Class
End Namespace