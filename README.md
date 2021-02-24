FraudLabs Pro VB.NET SDK
========================
This VB.NET module enables user to easily implement fraud detection feature into their solution using the API from https://www.fraudlabspro.com.

Below are the features of this VB.NET module:
- Fraud analysis and scoring
- IP address geolocation & proxy validation
- Email address validation
- Credit card issuing bank validation
- Transaction velocity validation
- Device transaction validation
- Blacklist validation
- Custom rules trigger
- Email notification of fraud orders
- Mobile app notification of fraud orders

This module requires API key to function. You may subscribe a free API key at https://www.fraudlabspro.com

** Compatible with .NET Core 2.1+ **


Usage Example
============
### Screen Order

#### Object Properties

| Property Name                     | Property Type | Description                                                  |
| --------------------------------- | ------------- | ------------------------------------------------------------ |
| IPAddress                         | string        | IP address of online transaction. It supports both IPv4 and IPv6 address format. |
| FirstName                         | string        | User's first name.                                           |
| LastName    | string        | User's last name.                                            |
| UserName   | string        | User's username.                                             |
| Password    | string        | User's password.                                             |
| EmailAddress       | string        | User's email address.                                        |
| UserPhone       | string        | User's phone number.                                         |
| BillAddress     | string        | Street address of billing address.                           |
| BillCity       | string        | City of billing address.                                     |
| BillState       | string        | State of billing address. It supports state codes, e.g. NY (New York), for state or province of United States or Canada. Please refer to [State & Province Codes](https://www.fraudlabspro.com/developer/reference/state-and-province-codes) for complete list. |
| BillZIPCode    | string        | Postal or ZIP code of billing address.                       |
| BillCountry     | string        | Country of billing address. It requires the input of ISO-3166 alpha-2 country code, e.g. US for United States. Please refer to [Country Codes](https://www.fraudlabspro.com/developer/reference/country-codes) for complete list. |
| UserOrderID       | string        | Merchant identifier to uniquely identify a transaction. It supports maximum of 15 characters user order id input. |
| UserOrderMemo         | string        | Merchant description of an order transaction. It supports maximum of 200 characters. |
| Amount       | decimal         | Amount of the transaction.                                   |
| Quantity      | integer       | Total quantity of the transaction.                           |
| Currency      | string        | Currency code used in the transaction. It requires the input of ISO-4217 (3 characters) currency code, e.g. USD for US Dollar. Please refer to [Currency Codes](https://www.fraudlabspro.com/developer/reference/currency-codes) for complete list. |
| Department    | string        | Merchant identifier to uniquely identify a product or service department. |
| PaymentMode | string        | Payment mode of transaction. Valid values: creditcard, affirm, paypal, googlecheckout, bitcoin, cod, moneyorder, wired, bankdeposit, elviauthorized, paymitco, cybersource, sezzle, viabill, amazonpay, pmnts_gateway, giftcard, others. |
| CardNumber         | string        | Billing credit card number or BIN number.                    |
| AvsResult           | string        | The single character AVS result returned by the credit card processor. Please refer to [AVS & CVV2 Response Codes](https://www.fraudlabspro.com/developer/reference/avs-and-cvv2-response-codes) for details. |
| CvvResult            | string        | The single character CVV2 result returned by the credit card processor. Please refer to [AVS & CVV2 Response Codes](https://www.fraudlabspro.com/developer/reference/avs-and-cvv2-response-codes) for details. |
| ShippingAddress    | string        | Street address of shipping address.                          |
| ShippingCity       | string        | City of shipping address.                                    |
| ShippingState      | string        | State of shipping address. It supports state codes, e.g. NY - New York, for state or province of United States or Canada. Please refer to [State & Province Codes](https://www.fraudlabspro.com/developer/reference/state-and-province-codes) for complete list. |
| ShippingZIPCode   | string        | Postal or ZIP code of shipping address.                      |
| ShippingCountry    | string        | Country of shipping address. It requires the input of ISO-3166 alpha-2 country code, e.g. US for United States. Please refer to [Country Codes](https://www.fraudlabspro.com/developer/reference/country-codes) for complete list. |
| FLPCheckSum    | string        | Checksum for the device validation. Please visit [Agent Javascript](https://www.fraudlabspro.com/developer/javascript) to learn about the use of this parameter. |


```vb.net
Imports FraudLabsPro.FraudLabsPro
Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Set ScreenOrder parameter
        Dim ScreenOrderPara As New OrderPara

        'Set order details
        ScreenOrderPara.IPAddress = "146.112.62.105" ' IP Parameter is mandatory
        ScreenOrderPara.FirstName = "Hector"
        ScreenOrderPara.LastName = "Henderson"
        ScreenOrderPara.EmailAddress = "hh5566@gmail.com"

        'Billing Information
        ScreenOrderPara.BillAddress = "1766 PowderHouse Road"
        ScreenOrderPara.BillCity = "West Palm Beach"
        ScreenOrderPara.BillState = "FL"
        ScreenOrderPara.BillCountry = "US"
        ScreenOrderPara.BillZIPCode = "33401"
        ScreenOrderPara.CardNumber = "4556553172971283"
        ScreenOrderPara.UserPhone = "561-628-8674"
        'Order Information
        ScreenOrderPara.UserOrderID = "67398"
        ScreenOrderPara.UserOrderMemo = "Online shop"
        ScreenOrderPara.Amount = "79.89"
        ScreenOrderPara.Quantity = "1"
        ScreenOrderPara.Currency = "USD"
        ScreenOrderPara.PaymentMode = Order.PaymentMethods.CREDIT_CARD

        'Shipping Information
        ScreenOrderPara.ShippingAddress = "4469 Chestnut Street"
        ScreenOrderPara.ShippingCity = "Tampa"
        ScreenOrderPara.ShippingState = "FL"
        ScreenOrderPara.ShippingZIPCode = "33602"
        ScreenOrderPara.ShippingCountry = "US"

        'ScreenOrder API
        Dim ScreenOrder As New Order
        Dim result = ScreenOrder.ScreenOrder(ScreenOrderPara) ' Send order to FraudLabs Pro
        Response.Write("IsCountryMatch: " + result.IsCountryMatch + "</br>")
        Response.Write("IsHighRiskCountry: " + result.IsHighRiskCountry + " </br>")
        Response.Write("DistanceInKM: " + result.DistanceInKM + "</br>")
        Response.Write("DistanceInMile: " + result.DistanceInMile + "</br>")
        Response.Write("IPCountry: " + result.IPCountry + "</br>")
        Response.Write("IPRegion: " + result.IPRegion + "</br>")
        Response.Write("IPCity: " + result.IPCity + "</br>")
        Response.Write("IPContinent: " + result.IPContinent + "</br>")
        Response.Write("IPLatitude: " + result.IPLatitude + "</br>")
        Response.Write("IPLongtitude: " + result.IPLongtitude + "</br>")
        Response.Write("IPTimeZone: " + result.IPTimeZone + "</br>")
        Response.Write("IPElevation: " + result.IPElevation + "</br>")
        Response.Write("IPDomain: " + result.IPDomain + "</br>")
        Response.Write("IPMobileMNC: " + result.IPMobileMNC + "</br>")
        Response.Write("IPMobileMCC: " + result.IPMobileMCC + "</br>")
        Response.Write("IPMobileBrand: " + result.IPMobileBrand + "</br>")
        Response.Write("IPNetSpeed: " + result.IPNetSpeed + "</br>")
        Response.Write("IPISPName: " + result.IPISPName + "</br>")
        Response.Write("IPUsageType: " + result.IPUsageType + "</br>")
        Response.Write("IsFreeEmail: " + result.IsFreeEmail + "</br>")
        Response.Write("IsDisposableEmail: " + result.IsDisposableEmail + "</br>")
        Response.Write("IsNewDomainName: " + result.IsNewDomainName + "</br>")
        Response.Write("IsDomainExists: " + result.IsDomainExists + "</br>")
        Response.Write("IsProxyIPAddress: " + result.IsProxyIPAddress + "</br>")
        Response.Write("IsBinFound: " + result.IsBinFound + "</br>")
        Response.Write("IsBinCountryMatch: " + result.IsBinCountryMatch + "</br>")
        Response.Write("IsBinNameMatch: " + result.IsBinNameMatch + "</br>")
        Response.Write("IsBinPhoneMatch: " + result.IsBinPhoneMatch + "</br>")
        Response.Write("IsBinPrepaid: " + result.IsBinPrepaid + "</br>")
        Response.Write("IsAddressShipForward: " + result.IsAddressShipForward + "</br>")
        Response.Write("IsBillShipCityMatch: " + result.IsBillShipCityMatch + "</br>")
        Response.Write("IsBillShipStateMatch: " + result.IsBillShipStateMatch + "</br>")
        Response.Write("IsBillShipCountryMatch: " + result.IsBillShipCountryMatch + "</br>")
        Response.Write("IsBillShipPostalMatch: " + result.IsBillShipPostalMatch + "</br>")
        Response.Write("IsIPBlacklist: " + result.IsIPBlacklist + "</br>")
        Response.Write("IsEmailBlacklist: " + result.IsEmailBlacklist + "</br>")
        Response.Write("IsCreditCardBlacklist: " + result.IsCreditCardBlacklist + "</br>")
        Response.Write("IsDeviceBlacklist: " + result.IsDeviceBlacklist + "</br>")
        Response.Write("IsUserBlacklist: " + result.IsUserBlacklist + "</br>")
        Response.Write("IsShipAddressBlackList: " + result.IsShipAddressBlackList + "</br>")
        Response.Write("IsPhoneBlacklist: " + result.IsPhoneBlacklist + "</br>")
        Response.Write("IsHighRiskUsernamePassword: " + result.IsHighRiskUsernamePassword + "</br>")
        Response.Write("IsMalwareExploit: " + result.IsMalwareExploit + "</br>")
        Response.Write("IsExportControlledCountry: " + result.IsExportControlledCountry + "</br>")
        Response.Write("UserOrderID: " + result.UserOrderID + "</br>")
        Response.Write("UserOrderMemo: " + result.UserOrderMemo + "</br>")
        Response.Write("FraudLabsProScore: " + result.FraudLabsProScore + "</br>")
        Response.Write("FraudLabsProDistribution: " + result.FraudLabsProDistribution + "</br>")
        Response.Write("FraudLabsProStatus: " + result.FraudLabsProStatus + "</br>")
        Response.Write("FraudLabsProID: " + result.FraudLabsProID + "</br>")
        Response.Write("FraudLabsProVersion: " + result.FraudLabsProVersion + "</br>")
        Response.Write("FraudLabsProErrorCode: " + result.FraudLabsProErrorCode + "</br>")
        Response.Write("FraudLabsProMessage: " + result.FraudLabsProMessage + "</br>")
        Response.Write("FraudLabsProCredit: " + result.FraudLabsProCredit + "</br>")
    End Sub
End Class
```


### Get Order Result

#### Parameter Properties

| Parameter Name | Parameter Type | Description                                                  |
| -------------- | -------------- | ------------------------------------------------------------ |
| ID            | string         | FraudLabs Pro transaction ID or Order ID.                    |
| IDType          | string         | ID type. Either: **Order.IDTypes.FLP_ID** or **Order.IDTypes.ORDER_ID** |

```vb.net
Imports FraudLabsPro.FraudLabsPro
Public Class WebForm3
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Set Get Order Result parameter     
        Dim GetOrder_Result_Parameter As New OrderPara
        GetOrder_Result_Parameter.ID = "20180709-NHAEUK"
        GetOrder_Result_Parameter.IDType = Order.IDTypes.FLP_ID

        'Get Order Result API
        Dim OrderResult As New Order
        Dim result = OrderResult.GetOrderResult(GetOrder_Result_Parameter) 'Get order result from FraudLabs Pro
        Response.Write("IsCountryMatch: " + result.IsCountryMatch + "</br>")
        Response.Write("IsHighRiskCountry: " + result.IsHighRiskCountry + " </br>")
        Response.Write("DistanceInKM: " + result.DistanceInKM + "</br>")
        Response.Write("DistanceInMile: " + result.DistanceInMile + "</br>")
        Response.Write("IPCountry: " + result.IPCountry + "</br>")
        Response.Write("IPRegion: " + result.IPRegion + "</br>")
        Response.Write("IPCity: " + result.IPCity + "</br>")
        Response.Write("IPContinent: " + result.IPContinent + "</br>")
        Response.Write("IPLatitude: " + result.IPLatitude + "</br>")
        Response.Write("IPLongtitude: " + result.IPLongtitude + "</br>")
        Response.Write("IPTimeZone: " + result.IPTimeZone + "</br>")
        Response.Write("IPElevation: " + result.IPElevation + "</br>")
        Response.Write("IPDomain: " + result.IPDomain + "</br>")
        Response.Write("IPMobileMNC: " + result.IPMobileMNC + "</br>")
        Response.Write("IPMobileMCC: " + result.IPMobileMCC + "</br>")
        Response.Write("IPMobileBrand: " + result.IPMobileBrand + "</br>")
        Response.Write("IPNetSpeed: " + result.IPNetSpeed + "</br>")
        Response.Write("IPISPName: " + result.IPISPName + "</br>")
        Response.Write("IPUsageType: " + result.IPUsageType + "</br>")
        Response.Write("IsFreeEmail: " + result.IsFreeEmail + "</br>")
        Response.Write("IsDisposableEmail: " + result.IsDisposableEmail + "</br>")
        Response.Write("IsNewDomainName: " + result.IsNewDomainName + "</br>")
        Response.Write("IsDomainExists: " + result.IsDomainExists + "</br>")
        Response.Write("IsProxyIPAddress: " + result.IsProxyIPAddress + "</br>")
        Response.Write("IsBinFound: " + result.IsBinFound + "</br>")
        Response.Write("IsBinCountryMatch: " + result.IsBinCountryMatch + "</br>")
        Response.Write("IsBinNameMatch: " + result.IsBinNameMatch + "</br>")
        Response.Write("IsBinPhoneMatch: " + result.IsBinPhoneMatch + "</br>")
        Response.Write("IsBinPrepaid: " + result.IsBinPrepaid + "</br>")
        Response.Write("IsAddressShipForward: " + result.IsAddressShipForward + "</br>")
        Response.Write("IsBillShipCityMatch: " + result.IsBillShipCityMatch + "</br>")
        Response.Write("IsBillShipStateMatch: " + result.IsBillShipStateMatch + "</br>")
        Response.Write("IsBillShipCountryMatch: " + result.IsBillShipCountryMatch + "</br>")
        Response.Write("IsBillShipPostalMatch: " + result.IsBillShipPostalMatch + "</br>")
        Response.Write("IsIPBlacklist: " + result.IsIPBlacklist + "</br>")
        Response.Write("IsEmailBlacklist: " + result.IsEmailBlacklist + "</br>")
        Response.Write("IsCreditCardBlacklist: " + result.IsCreditCardBlacklist + "</br>")
        Response.Write("IsDeviceBlacklist: " + result.IsDeviceBlacklist + "</br>")
        Response.Write("IsUserBlacklist: " + result.IsUserBlacklist + "</br>")
        Response.Write("IsShipAddressBlackList: " + result.IsShipAddressBlackList + "</br>")
        Response.Write("IsPhoneBlacklist: " + result.IsPhoneBlacklist + "</br>")
        Response.Write("IsHighRiskUsernamePassword: " + result.IsHighRiskUsernamePassword + "</br>")
        Response.Write("IsMalwareExploit: " + result.IsMalwareExploit + "</br>")
        Response.Write("IsExportControlledCountry: " + result.IsExportControlledCountry + "</br>")
        Response.Write("UserOrderID: " + result.UserOrderID + "</br>")
        Response.Write("UserOrderMemo: " + result.UserOrderMemo + "</br>")
        Response.Write("FraudLabsProScore: " + result.FraudLabsProScore + "</br>")
        Response.Write("FraudLabsProDistribution: " + result.FraudLabsProDistribution + "</br>")
        Response.Write("FraudLabsProStatus: " + result.FraudLabsProStatus + "</br>")
        Response.Write("FraudLabsProID: " + result.FraudLabsProID + "</br>")
        Response.Write("FraudLabsProVersion: " + result.FraudLabsProVersion + "</br>")
        Response.Write("FraudLabsProErrorCode: " + result.FraudLabsProErrorCode + "</br>")
        Response.Write("FraudLabsProMessage: " + result.FraudLabsProMessage + "</br>")
        Response.Write("FraudLabsProCredit: " + result.FraudLabsProCredit + "</br>")
    End Sub
End Class
```


### Feedback

#### Object Properties

| Property Name | Property Type | Description                                                  |
| ------------- | ------------- | ------------------------------------------------------------ |
| ID            | string        | Unique transaction ID generated from **Validate** function.  |
| Action        | string        | Perform APPROVE, REJECT, or REJECT_BLACKLIST action to transaction.	Refer to [reference section](#feedback-status) for status code. |
| Note          | string        | Notes for the feedback request.                              |

```vb.net
Imports FraudLabsPro.FraudLabsPro
Public Class WebForm2
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Set FeedBack Order parameter
        Dim Feedback_Order_Parameter As New OrderPara
        Feedback_Order_Parameter.ID = "20180709-NHAEUK"
        Feedback_Order_Parameter.Action = Order.Action.APPROVE  ' Please refer to reference section for full list of feedback statuses
        Feedback_Order_Parameter.Note = "This customer made a valid purchase before."

        'Feedback Order API
        Dim FeedbackOrder As New Order
        Dim result = FeedbackOrder.FeedbackOrder(Feedback_Order_Parameter)
        Response.Write("FraudLabsProErrorCode: " + result.FraudLabsProErrorCode + "</br>")
        Response.Write("FraudLabsProMessage: " + result.FraudLabsProMessage + "</br>")
    End Sub
End Class

```




## SMS Verification

### Send SMS Verification

#### Object Properties

| Property Name | Property Type | Description                                                  |
| ------------- | :-----------: | ------------------------------------------------------------ |
| Tel           |    string     | The recipient mobile phone number in E164 format which is a plus followed by just numbers with no spaces or parentheses. |
| Message       |    string     | The message template for the SMS. Add <otp> as placeholder for the actual OTP to be generated. Max length is 140 characters. |
| OtpTimeout    |    integer    | Timeout feature for OTP value in seconds. Default is 3600 seconds(1 hour). Max timeout is 86400 seconds(24 hours). |
| CountryCode   |    string     | ISO 3166 country code for the recipient mobile phone number. If parameter is supplied, then some basic telephone number validation is done. |

```vb.net
Imports FraudLabsPro.FraudLabsPro
Public Class WebForm4
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Send SMS Verification API
        Dim Send_SMS_Verification As New SMSVerification

        'Sets SMS details for authentication purpose
        Dim SMS_Details As New SMSVerificationPara
        SMS_Details.Tel = "+123456789"
        SMS_Details.CountryCode = "US"
        SMS_Details.Message = "Hi, your OTP is <otp>."
        SMS_Details.OtpTimeout = 3600

        Dim result = Send_SMS_Verification.SendSMS(SMS_Details)
        Response.Write("TransactionID: " + result.TransactionID + "</br>")
        Response.Write("CreditsRemaining: " + result.CreditsRemaining + "</br>")
        Response.Write("Error: " + result.Error + "</br>")
    End Sub
End Class
```



### Get SMS Verification Result

#### Object Properties

| Property Name | Property Type | Description                                                  |
| ------------- | :-----------: | ------------------------------------------------------------ |
| TransactionID |    string     | The unique ID that was returned by the Send SMS Verification that triggered the OTP sms. |
| OTP           |    string     | The OTP that was sent to the recipient’s phone. |

```vb.net
Imports FraudLabsPro.FraudLabsPro
Public Class WebForm5
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"
        'Get Verification Result API
        Dim Get_Verification_Result As New SMSVerification

        'Sets SMS details for authentication purpose
        Dim SMS_Details As New SMSVerificationPara
        SMS_Details.TransactionID = "UNIQUE_TRANS_ID"
        SMS_Details.OTP = "OTP_RECEIVED"

        Dim result = Get_Verification_Result.VerifySMS(SMS_Details)
         Response.Write("Result: " + result.Result + "</br>")
        Response.Write("Error: " + result.Error + "</br>")
    End Sub
End Class
```



# Reference

#### Payment Method

| Payment Method                       |
| ------------------------------------ |
| Order.PaymentMethods.CREDIT_CARD      |
| Order.PaymentMethods.PAYPAL           |
| Order.PaymentMethods.GOOGLE_CHECKOUT  |
| Order.PaymentMethods.CASH_ON_DELIVERY |
| Order.PaymentMethods.MONEY_ORDER      |
| Order.PaymentMethods.WIRE_TRANSFER    |
| Order.PaymentMethods.BANK_DEPOSIT     |
| Order.PaymentMethods.BITCOIN          |
| Order.PaymentMethods.OTHERS           |



#### Feedback Status

| Feedback Status                      | Description                                 |
| ------------------------------------ | ------------------------------------------- |
| Order.Action.APPROVE          | Approves an order that under review status. |
| Order.Action.REJECT           | Rejects an order than under review status.  |
| Order.Action.REJECT_BLACKLIST | Rejects and blacklists an order.            |




LICENCE
=====================
See the LICENSE file.
