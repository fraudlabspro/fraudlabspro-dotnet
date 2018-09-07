Namespace FraudLabsPro
    Public Class SMSVerificationResult
        Public Sub New(ByVal SMSVerificationDeserialize As SMSVerificationDeserialize)
            Result = SMSVerificationDeserialize.result
            [Error] = SMSVerificationDeserialize.error
            TransactionID = SMSVerificationDeserialize.tran_id
            CreditsRemaining = SMSVerificationDeserialize.credits_remaining
        End Sub
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
        Private transaction_ID As String
        Public Property TransactionID() As String
            Get
                Return transaction_ID
            End Get
            Set(value As String)
                transaction_ID = value
            End Set
        End Property
        Private Credits_Remaining As String
        Public Property CreditsRemaining() As String
            Get
                Return Credits_Remaining
            End Get
            Set(value As String)
                Credits_Remaining = value
            End Set
        End Property
    End Class
End Namespace
