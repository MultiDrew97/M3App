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

    Shared Function ConvertStateAbbr(stateCode As String) As String
        Select Case stateCode
            Case "al", "AL"
                Return "Alabama"
            Case "ak", "AK"
                Return "Alaska"
            Case "az", "AZ"
                Return "Arizona"
            Case "ar", "AR"
                Return "Arkansas"
            Case "ca", "CA"
                Return "California"
            Case "co", "CO"
                Return "Colorado"
            Case "ct", "CT"
                Return "Connecticut"
            Case "de", "DE"
                Return "Delaware"
            Case "fl", "FL"
                Return "Florida"
            Case "ga", "GA"
                Return "Georgia"
            Case "hi", "HI"
                Return "Hawaii"
            Case "id", "ID"
                Return "Idaho"
            Case "il", "IL"
                Return "Illinois"
            Case "in", "IN"
                Return "Indiana"
            Case "ia", "IA"
                Return "Iowa"
            Case "ks", "KS"
                Return "Kansas"
            Case "ky", "KY"
                Return "Kentucky"
            Case "la", "LA"
                Return "Louisiana"
            Case "me", "ME"
                Return "Maine"
            Case "md", "MD"
                Return "Maryland"
            Case "ma", "MA"
                Return "Massachusetts"
            Case "mi", "MI"
                Return "Michigan"
            Case "mn", "MN"
                Return "Minnesota"
            Case "ms", "MS"
                Return "Mississippi"
            Case "mo", "MO"
                Return "Missouri"
            Case "mt", "MT"
                Return "Montana"
            Case "ne", "NE"
                Return "Nebraska"
            Case "nv", "NV"
                Return "Nevada"
            Case "nh", "NH"
                Return "New Hampshire"
            Case "nj", "NJ"
                Return "New Jersey"
            Case "nm", "NM"
                Return "New Mexico"
            Case "ny", "NY"
                Return "New York"
            Case "nc", "NC"
                Return "North Carolina"
            Case "nd", "ND"
                Return "North Dakota"
            Case "oh", "OH"
                Return "Ohio"
            Case "ok", "OK"
                Return "Oklahoma"
            Case "or", "OR"
                Return "Oregon"
            Case "pa", "PA"
                Return "Pennsylvania"
            Case "ri", "RI"
                Return "Rhode Island"
            Case "sc", "SC"
                Return "South Carolina"
            Case "sd", "SD"
                Return "South Dakota"
            Case "tn", "TN"
                Return "Tennessee"
            Case "tx", "TX"
                Return "Texas"
            Case "ut", "UT"
                Return "Utah"
            Case "vt", "VT"
                Return "Vermont"
            Case "va", "VA"
                Return "Virgina"
            Case "wa", "WA"
                Return "Washington"
            Case "wv", "WV"
                Return "West Virgina"
            Case "wi", "WI"
                Return "Wisconsin"
            Case "wy", "WY"
                Return "Wyoming"
            Case Else
                Throw New Exceptions.InvalidStateCodeException("The provided state code is invalid.")
        End Select
    End Function

    Shared Function ValidEmail(email As String) As Boolean
        Try
            Return Text.RegularExpressions.Regex.IsMatch(email, My.Resources.EmailRegex2)
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function

    Shared Function ValidID(id As Integer) As Boolean
        Return id >= My.Settings.MinID
    End Function

    Public Shared Sub PrintConsole(title As String, value As Object)
        Console.WriteLine($"------------------------ {title} ------------------------")
        Console.WriteLine(value)
        Console.WriteLine($"---------------------------------------------------------")
    End Sub
End Structure
