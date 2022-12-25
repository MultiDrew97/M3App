Imports System.ComponentModel
Imports System.Data.SqlClient
'Imports SPPBC.M3Tools.Types

Namespace Database
    ' TODO: Revamp this area as well
    Public NotInheritable Class ListenerDatabase
        Private ReadOnly tableName As String = "Listeners"
        <EditorBrowsable()>
        <Description("The username to use for the database connection")>
        <SettingsBindable(True)>
        Public Property Username As String
            Get
                Return db_Connection.Username
            End Get
            Set(value As String)
                db_Connection.Username = value
            End Set
        End Property

        'The password to use for the database connection
        <PasswordPropertyText(True)>
        <SettingsBindable(True)>
        <Description("The password to use for the database connection")>
        Public Property Password As String
            Get
                Return db_Connection.Password
            End Get
            Set(value As String)
                db_Connection.Password = value
            End Set
        End Property

        <Bindable(True)>
        <Description("The initial catalog to use for the database connection")>
        <SettingsBindable(True)>
        Public Property InitialCatalog As String
            Get
                Return db_Connection.InitialCatalog
            End Get
            Set(value As String)
                db_Connection.InitialCatalog = value
            End Set
        End Property

        Public Sub AddListener(name As String, email As String)
            AddListener(New SqlParameter("Name", name), New SqlParameter("Email", email))
        End Sub

        Private Sub AddListener(ParamArray params As SqlParameter())
            Using _cmd = db_Connection.Connect()
                _cmd.CommandType = CommandType.StoredProcedure
                _cmd.CommandText = $"[{My.Settings.Schema}].[sp_AddListener]"
                _cmd.Parameters.AddRange(params)

                _cmd.ExecuteNonQuery()
            End Using
        End Sub

        Public Sub RemoveListener(listenerID As Integer)
            If Not Utils.ValidID(listenerID) Then
                Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
            End If

            RemoveListener(New SqlParameter("ListenerID", listenerID))
        End Sub

        Public Sub RemoveListener(ParamArray param As SqlParameter())
            Using _cmd = db_Connection.Connect()
                _cmd.CommandType = CommandType.StoredProcedure
                _cmd.CommandText = $"[{My.Settings.Schema}].[sp_RemoveListener]"
                _cmd.Parameters.AddRange(param)

                _cmd.ExecuteNonQuery()
            End Using
        End Sub

        Public Sub UpdateListener(listenerID As Integer, fName As String, lName As String, email As String)
            UpdateListener(listenerID, $"{fName} {lName}", email)
        End Sub

        Public Sub UpdateListener(listenerID As Integer, name As String, email As String)
            If Not Utils.ValidID(listenerID) Then
                Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
            End If

            UpdateListener(New Types.Listener(listenerID, name, email))
        End Sub

        Public Sub UpdateListener(listener As Types.Listener)
            UpdateListener(New SqlParameter("ListenerID", listener.Id), New SqlParameter("Name", listener.Name), New SqlParameter("Email", listener.Email))
        End Sub

        Private Sub UpdateListener(ParamArray params As SqlParameter())
            Using _cmd = db_Connection.Connect()
                _cmd.CommandText = $"[{My.Settings.Schema}].[sp_UpdateListener]"
                _cmd.CommandType = CommandType.StoredProcedure
                _cmd.Parameters.AddRange(params)

                _cmd.ExecuteNonQuery()
            End Using
        End Sub

        Public Function GetListeners() As Types.DBEntryCollection(Of Types.Listener)
            Dim listeners As New Types.DBEntryCollection(Of Types.Listener)

            Using _cmd = db_Connection.Connect()
                _cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}]"

                Using reader = _cmd.ExecuteReader
                    Do While reader.Read()
                        listeners.Add(New Types.Listener(
                            CInt(reader("ListenerID")),
                            CStr(reader("Name")),
                            CStr(reader("Email"))
                        ))
                    Loop
                End Using
            End Using

            Return listeners
        End Function

        Public Function GetListener(emailAddress As String) As Types.Listener
            Return GetListener("Email", New SqlParameter("EmailAddress", emailAddress))
        End Function

        Public Function GetListener(listenerID As Integer) As Types.Listener
            If Not Utils.ValidID(listenerID) Then
                Throw New ArgumentException($"ID values must be greater than or equal to {My.Settings.MinID}")
            End If

            Return GetListener("ID", New SqlParameter("ListenerID", listenerID))
        End Function

        Public Function GetListener(column As String, ParamArray params As SqlParameter()) As Types.Listener
            Using _cmd = db_Connection.Connect()
                _cmd.Parameters.AddRange(params)
                Dim cmdText As String = ""

                Select Case column
                    Case "Email"
                        cmdText = "WHERE {column}=@EmailAddress"
                    Case "ID"
                        cmdText = "WHERE {column}=@ListenerID"
                End Select

                _cmd.CommandText = $"SELECT * FROM [{My.Settings.Schema}].[{tableName}] {cmdText}"

                Using reader = _cmd.ExecuteReaderAsync().Result
                    Do While reader.Read()
                        Return New Types.Listener(
                            CInt(reader("ListenerID")),
                            CStr(reader("Name")),
                            CStr(reader("Email"))
                        )
                    Loop
                End Using
            End Using

            Return Nothing
        End Function
    End Class
End Namespace