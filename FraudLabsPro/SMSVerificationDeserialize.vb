Imports System.Net

Namespace FraudLabsPro
    Public Class SMSVerificationDeserialize
        Private smsResult As String
        Public Property result() As String
            Get
                Return smsResult
            End Get
            Set(value As String)
                smsResult = value
            End Set
        End Property
        Private smsError As String
        Public Property [error]() As String
            Get
                Return smsError
            End Get
            Set(value As String)
                smsError = value
            End Set
        End Property
        Private transactionID As String
        Public Property tran_id() As String
            Get
                Return transactionID
            End Get
            Set(value As String)
                transactionID = value
            End Set
        End Property
        Private CreditRemaining As String
        Public Property credits_remaining() As String
            Get
                Return CreditRemaining
            End Get
            Set(value As String)
                CreditRemaining = value
            End Set
        End Property
    End Class
End Namespace

