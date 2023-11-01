Imports System.Runtime.Serialization

Namespace Exceptions
    <Serializable>
    Public Class InvalidStateCodeException
        Inherits Exception

        Sub New()
            MyBase.New()
        End Sub

        Sub New(message As String)
            MyBase.New(message)
        End Sub

        Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

        Protected Sub New(info As SerializationInfo, context As StreamingContext)
            MyBase.New(info, context)
        End Sub
    End Class
End Namespace
