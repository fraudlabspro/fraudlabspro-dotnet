﻿Imports System.Uri
Imports System.Security.Cryptography
Imports Newtonsoft.Json

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
            Const GOOGLE_CHECKOUT = "GOOGLECHECKOUT"
            Const CASH_ON_DELIVERY = "COD"
            Const MONEY_ORDER = "MONEYORDER"
            Const WIRE_TRANSFER = "WIRED"
            Const BANK_DEPOSIT = "BANKDEPOSIT"
            Const BITCOIN = "BITCOIN"
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
        Public Function ScreenOrder(ByVal para As OrderPara) As OrderResult
            Try
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
                    {"payment_mode", para.PaymentMode},
                    {"bin_no", para.BinNo},
                    {"card_hash", Fraudlabspro_Hash(para.CardNumber)},
                    {"avs_result", para.AvsResult},
                    {"cvv_result", para.CvvResult},
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
                url = "https://api.fraudlabspro.com/v1/order/screen"
                Dim request As New Http
                Dim rawJson As String
                rawJson = request.PostMethod(url, post)

                Dim DeserializedResult As OrderResultObj = JsonConvert.DeserializeObject(Of OrderResultObj)(rawJson)
                Dim OrderResult As New OrderResult(DeserializedResult)
                Return OrderResult
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function

        'Feedback Order API
        'Sends decision back to FraudLabs Pro
        Public Function FeedbackOrder(ByVal para As OrderPara) As OrderResult
            Try
                Dim apikey As String = FraudLabsProConfig.APIKey
                Dim format As String = para.Format
                Dim id As String = para.ID
                Dim action As String = para.Action
                Dim url As String
                url = "https://api.fraudlabspro.com/v1/order/feedback?key=" & apikey
                Dim post As String = "&format=" & System.Web.HttpUtility.UrlEncode(format) & "&id=" & System.Web.HttpUtility.UrlEncode(id) & "&action=" & System.Web.HttpUtility.UrlEncode(action)

                Dim request As New Http
                Dim rawJson As String
                rawJson = request.PostMethod(url, post)

                Dim DeserializedResult As OrderResultObj = JsonConvert.DeserializeObject(Of OrderResultObj)(rawJson)
                Dim OrderResult As New OrderResult(DeserializedResult)
                Return OrderResult
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function

        'GetOrderResult API
        'Function to get transaction result.
        Public Function GetOrderResult(ByVal para As OrderPara) As OrderResult
            Try
                Dim apikey As String = FraudLabsProConfig.APIKey
                Dim format As String = para.Format
                Dim id As String = para.ID
                Dim id_type As String = para.IDType
                Dim url As String
                url = "https://api.fraudlabspro.com/v1/order/result?key=" & apikey &
        "&format=" & System.Web.HttpUtility.UrlEncode(format) &
        "&id=" & System.Web.HttpUtility.UrlEncode(id) &
          "&id_type=" & System.Web.HttpUtility.UrlEncode(id_type)
                Dim request As New Http
                Dim rawJson As String
                rawJson = request.GetMethod(url)

                Dim DeserializedResult As OrderResultObj = JsonConvert.DeserializeObject(Of OrderResultObj)(rawJson)
                Dim OrderResult As New OrderResult(DeserializedResult)
                Return OrderResult
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function
        Private Function Fraudlabspro_Hash(ByVal s As String) As String
            Dim i As Integer = 0
            Dim hash As String = "fraudlabspro_" + s

            For i = 1 To 65536
                hash = Me.SHA1("fraudlabspro_" + hash)
            Next
            Return hash
        End Function
        Private Function SHA1(ByVal s As String) As String
            Dim sha As New SHA1CryptoServiceProvider
            Dim bytes() As Byte
            Dim x As String = ""

            bytes = System.Text.Encoding.ASCII.GetBytes(s)
            bytes = sha.ComputeHash(bytes)

            For Each b As Byte In bytes
                x += b.ToString("x2")
            Next

            Return x
        End Function
    End Class
End Namespace
