Imports System.Uri

Namespace FraudLabsPro
    Public Class SMSVerification
        'Send SMS Verification API
        'Send SMS with verification code and custom message for authentication purpose.
        Public Function SendSMS(ByVal para As SMSVerificationPara)
            Try
                Dim apiKey As String = FraudLabsProConfig.APIKey
                Dim data As New Dictionary(Of String, String)

                data.Add("format", para.Format)
                data.Add("tel", para.Tel)
                data.Add("country_code", para.CountryCode)
                data.Add("mesg", para.Message)
                Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())
                Dim url As String
                url = "https://api.fraudlabspro.com/v1/verification/send?key=" & apiKey & "&" & datastr
                Dim request As New Http
                Dim rawJson As String
                rawJson = request.GetMethod(url)
                Dim js As New System.Web.Script.Serialization.JavaScriptSerializer
                Dim DeserializedResult = js.Deserialize(Of SMSVerificationDeserialize)(rawJson)
                Dim SMSVerificationResult As New SMSVerificationResult(DeserializedResult)

                Return SMSVerificationResult
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function
        'Get Verification Result API
        'Verify that an OTP sent by Send SMS Verification API is valid.
        Public Function VerifySMS(ByVal para As SMSVerificationPara)
            Try
                Dim apikey As String = FraudLabsProConfig.APIKey
                Dim transactionid As String = para.TransactionID
                Dim otp As String = para.OTP
                Dim format As String = para.Format
                Dim data As New Dictionary(Of String, String)
                data.Add("format", format)
                data.Add("tran_id", transactionid)
                data.Add("otp", otp)
                Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())
                Dim url As String
                url = "https://api.fraudlabspro.com/v1/verification/result?key=" & apikey & "&" & datastr
                Dim request As New Http
                Dim rawJson As String
                rawJson = request.GetMethod(url)
                Dim js As New System.Web.Script.Serialization.JavaScriptSerializer
                Dim DeserializedResult = js.Deserialize(Of SMSVerificationDeserialize)(rawJson)
                Dim SMSVerificationResult As New SMSVerificationResult(DeserializedResult)

                Return SMSVerificationResult
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function
    End Class
End Namespace

