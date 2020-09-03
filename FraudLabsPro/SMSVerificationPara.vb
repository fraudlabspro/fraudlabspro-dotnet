Namespace FraudLabsPro
    Public Class SMSVerificationPara
        Private Fmt As String = "json"
        Private transaction_ID As String = ""
        Private OTPCode As String = ""
        Private ID_Type As String = ""
        Public ReadOnly Property Format() As String
            Get
                Return Fmt
            End Get
        End Property
        Public Property TransactionID() As String
            Get
                Return transaction_ID
            End Get
            Set(value As String)
                transaction_ID = value
            End Set
        End Property
        Public Property OTP() As String
            Get
                Return OTPCode
            End Get
            Set(value As String)
                OTPCode = value
            End Set
        End Property
        Private hpNum As String
        Public Property Tel() As String
            Get
                Return hpNum
            End Get
            Set(value As String)
                hpNum = value
            End Set
        End Property
        Private country_Code As String
        Public Property CountryCode() As String
            Get
                Return country_Code
            End Get
            Set(value As String)
                country_Code = value
            End Set
        End Property
        Private messages As String
        Public Property Message() As String
            Get
                Return messages
            End Get
            Set(value As String)
                messages = value
            End Set
        End Property
        Private otp_Timeout As Integer
        Public Property OtpTimeout() As Integer
            Get
                Return otp_Timeout
            End Get
            Set(value As Integer)
                otp_Timeout = value
            End Set
        End Property
        Public Property IDType() As String
            Get
                Return ID_Type
            End Get
            Set(value As String)
                ID_Type = value
            End Set
        End Property
    End Class
End Namespace