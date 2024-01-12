Imports System.Uri
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace FraudLabsPro
    Public Class SMSVerification
        'Send SMS Verification API
        'Send SMS with verification code and custom message for authentication purpose.
        Public Function SendSMS(para As SMSVerificationPara) As JObject
            Dim apiKey As String = FraudLabsProConfig.APIKey
            Dim data As New Dictionary(Of String, String) From {
                    {"key", FraudLabsProConfig.APIKey},
                    {"format", para.Format},
                    {"source", para.Source},
                    {"source_version", FraudLabsProConfig.Version},
                    {"tel", para.Tel},
                    {"country_code", para.CountryCode},
                    {"mesg", para.Message},
                    {"otp_timeout", para.OtpTimeout}
                }

            Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())
            Dim post As String = datastr
            Dim url As String
            url = "https://api.fraudlabspro.com/v2/verification/send"
            Dim request As New Http
            Dim rawJson As String
            rawJson = request.PostMethod(url, post)

            Dim SMSVerificationResult As JObject = JsonConvert.DeserializeObject(Of JObject)(rawJson)
            Return SMSVerificationResult
        End Function
        'Get Verification Result API
        'Verify that an OTP sent by Send SMS Verification API is valid.
        Public Function VerifySMS(para As SMSVerificationPara) As JObject
            Dim apikey As String = FraudLabsProConfig.APIKey
            Dim transactionid As String = para.TransactionID
            Dim otp As String = para.OTP
            Dim format As String = para.Format
            Dim data As New Dictionary(Of String, String) From {
                    {"format", format},
                    {"tran_id", transactionid},
                    {"otp", otp}
                }
            Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())
            Dim url As String
            url = "https://api.fraudlabspro.com/v2/verification/result?key=" & apikey & "&" & datastr
            Dim request As New Http
            Dim rawJson As String
            rawJson = request.GetMethod(url)

            Dim SMSVerificationResult As JObject = JsonConvert.DeserializeObject(Of JObject)(rawJson)
            Return SMSVerificationResult
        End Function
    End Class
End Namespace

