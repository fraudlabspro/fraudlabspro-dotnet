Imports System.Net

Namespace FraudLabsPro
    Public Class SMSVerificationResultObj
        Private smsResult As String
        Public Property Result() As String
            Get
                Return smsResult
            End Get
            Set(value As String)
                smsResult = value
            End Set
        End Property
        Private smsError As String
        Public Property [Error]() As String
            Get
                Return smsError
            End Get
            Set(value As String)
                smsError = value
            End Set
        End Property
        Private transactionID As String
        Public Property Tran_id() As String
            Get
                Return transactionID
            End Get
            Set(value As String)
                transactionID = value
            End Set
        End Property
        Private CreditRemaining As String
        Public Property Credits_remaining() As String
            Get
                Return CreditRemaining
            End Get
            Set(value As String)
                CreditRemaining = value
            End Set
        End Property
    End Class
End Namespace

