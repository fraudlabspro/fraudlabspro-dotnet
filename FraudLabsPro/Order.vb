Imports System.Uri
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace FraudLabsPro
    'FraudLabsPro Order Class
    'Validates order for possible fraud and feedback user decision.
    Public Class Order
        'Order Status
        Structure Action
            Const APPROVE = "APPROVE"
            Const REJECT = "REJECT"
            Const REJECT_BLACKLIST = "REJECT_BLACKLIST"
        End Structure
        'Payment Methods
        Structure PaymentMethods
            Const CREDIT_CARD = "CREDITCARD"
            Const PAYPAL = "PAYPAL"
            Const CASH_ON_DELIVERY = "COD"
            Const BANK_DEPOSIT = "BANKDEPOSIT"
            Const GIFT_CARD = "GIFTCARD"
            Const CRYPTO = "CRYPTO"
            Const WIRE_TRANSFER = "WIRED"
            Const OTHERS = "OTHERS"
        End Structure
        'ID Types       
        Structure IDTypes
            Const FLP_ID = "fraudlabspro_id"
            Const ORDER_ID = "user_order_id"
        End Structure

        'Screen Order API
        'Screen an order transaction for payment fraud.
        'This REST API will detects all possibles fraud traits based on the input parameters supplied.
        'The more input parameter supplied, the higher accuracy of fraud detection.
        Public Function ScreenOrder(para As OrderPara) As JObject
            'Configuration Information
            'Billing Information
            'Order Information
            'CreditCard Information
            'Shipping Information
            Dim data As New Dictionary(Of String, String) From {
                    {"key", FraudLabsProConfig.APIKey},
                    {"format", para.Format},
                    {"source", para.Source},
                    {"source_version", FraudLabsProConfig.Version},
                    {"ip", para.IPAddress},
                    {"first_name", para.FirstName},
                    {"last_name", para.LastName},
                    {"username_hash", Fraudlabspro_Hash(para.Username)},
                    {"password_hash", Fraudlabspro_Hash(para.Password)},
                    {"email", para.EmailAddress},
                    {"email_domain", para.EmailDomain},
                    {"email_hash", Fraudlabspro_Hash(para.EmailAddress)},
                    {"user_phone", para.UserPhone},
                    {"bill_addr", para.BillAddress},
                    {"bill_city", para.BillCity},
                    {"bill_state", para.BillState},
                    {"bill_zip_code", para.BillZIPCode},
                    {"bill_country", para.BillCountry},
                    {"user_order_id", para.UserOrderID},
                    {"user_order_memo", para.UserOrderMemo},
                    {"amount", para.Amount},
                    {"quantity", para.Quantity},
                    {"currency", para.Currency},
                    {"department", para.Department},
                    {"payment_gateway", para.PaymentGateway},
                    {"payment_mode", para.PaymentMode},
                    {"bin_no", para.BinNo},
                    {"card_hash", Fraudlabspro_Hash(para.CardNumber)},
                    {"avs_result", para.AvsResult},
                    {"cvv_result", para.CvvResult},
                    {"ship_first_name", para.ShippingFirstName},
                    {"ship_last_name", para.ShippingLastName},
                    {"ship_addr", para.ShippingAddress},
                    {"ship_city", para.ShippingCity},
                    {"ship_state", para.ShippingState},
                    {"ship_zip_code", para.ShippingZIPCode},
                    {"ship_country", para.ShippingCountry},
                    {"flp_checksum", para.FLPCheckSum}
                }

            Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())
            Dim post As String = datastr
            Dim url As String
            url = "https://api.fraudlabspro.com/v2/order/screen"
            Dim request As New Http
            Dim rawJson As String
            rawJson = request.PostMethod(url, post)

            Dim OrderResult As JObject = JsonConvert.DeserializeObject(Of JObject)(rawJson)
            Return OrderResult
        End Function

        'Feedback Order API
        'Sends decision back to FraudLabs Pro
        Public Function FeedbackOrder(para As OrderPara) As JObject
            Dim data As New Dictionary(Of String, String) From {
                {"key", FraudLabsProConfig.APIKey},
                {"format", para.Format},
                {"source", para.Source},
                {"source_version", FraudLabsProConfig.Version},
                {"id", para.ID},
                {"action", para.Action}
            }

            Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())
            Dim post As String = datastr

            Dim url As String
            url = "https://api.fraudlabspro.com/v2/order/feedback"
            Dim request As New Http
            Dim rawJson As String
            rawJson = request.PostMethod(url, post)

            Dim OrderResult As JObject = JsonConvert.DeserializeObject(Of JObject)(rawJson)
            Return OrderResult
        End Function

        'GetOrderResult API
        'Function to get transaction result.
        Public Function GetOrderResult(para As OrderPara) As JObject
            Dim data As New Dictionary(Of String, String) From {
                {"key", FraudLabsProConfig.APIKey},
                {"format", para.Format},
                {"id", para.ID},
                {"id_type", para.IDType}
            }

            Dim datastr As String = String.Join("&", data.[Select](Function(x) x.Key & "=" & EscapeDataString(x.Value)).ToArray())

            Dim url As String
            url = "https://api.fraudlabspro.com/v2/order/result?" & datastr
            Dim request As New Http
            Dim rawJson As String
            rawJson = request.GetMethod(url)

            Dim OrderResult As JObject = JsonConvert.DeserializeObject(Of JObject)(rawJson)
            Return OrderResult
        End Function
        Private Function Fraudlabspro_Hash(s As String) As String
            Dim hash As String = "fraudlabspro_" + s

            Dim i As Integer
            For i = 1 To 65536
                hash = SHA1("fraudlabspro_" + hash)
            Next
            Return hash
        End Function
        Private Function SHA1(s As String) As String
            Dim sha As New SHA1CryptoServiceProvider
            Dim bytes() As Byte
            Dim x As String = ""

            bytes = Text.Encoding.ASCII.GetBytes(s)
            bytes = sha.ComputeHash(bytes)

            For Each b As Byte In bytes
                x += b.ToString("x2")
            Next

            Return x
        End Function
    End Class
End Namespace
