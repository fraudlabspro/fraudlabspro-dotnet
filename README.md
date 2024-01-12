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
Imports Newtonsoft.Json

Module Program
    Sub Main()
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        Dim ScreenOrderPara As New OrderPara With {
            .IPAddress = "146.112.62.105", ' IP Parameter is mandatory
            .FirstName = "Hector",
            .LastName = "Henderson",
            .EmailAddress = "hh5566@gmail.com",
            .BillAddress = "1766 PowderHouse Road",
            .BillCity = "West Palm Beach",
            .BillState = "FL",
            .BillCountry = "US",
            .BillZIPCode = "33401",
            .CardNumber = "4556553172971283",
            .UserPhone = "561-628-8674",
            .UserOrderID = "67398",
            .UserOrderMemo = "Online shop",
            .Amount = "79.89",
            .Quantity = "1",
            .Currency = "USD",
            .PaymentMode = Order.PaymentMethods.CREDIT_CARD,
            .ShippingAddress = "4469 Chestnut Street",
            .ShippingCity = "Tampa",
            .ShippingState = "FL",
            .ShippingZIPCode = "33602",
            .ShippingCountry = "US"
        }

        'ScreenOrder API
        Dim ScreenOrder As New Order
        Dim result = ScreenOrder.ScreenOrder(ScreenOrderPara) ' Send order to FraudLabs Pro

        'pretty-print JSON
        'Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented))

        Dim ipgeolocation = result("ip_geolocation")
        Dim ipgeolocationfields = New ArrayList From {
            "ip",
            "continent",
            "country_code",
            "country_name",
            "region",
            "city",
            "latitude",
            "longitude",
            "zip_code",
            "timezone",
            "isp_name",
            "domain",
            "netspeed",
            "mobile_mnc",
            "mobile_mcc",
            "mobile_brand",
            "elevation",
            "usage_type",
            "is_proxy",
            "is_in_blacklist"
        }

        For Each field In ipgeolocationfields
            Console.WriteLine("ip_geolocation." & field.ToString & ": " & ipgeolocation(field).ToString)
        Next

        Dim billingaddress = result("billing_address")
        Dim billingaddressfields = New ArrayList From {
            "ip_distance_in_km",
            "ip_distance_in_mile",
            "is_ip_country_match"
        }

        For Each field In billingaddressfields
            Console.WriteLine("billing_address." & field.ToString & ": " & billingaddress(field).ToString)
        Next

        Dim shippingaddress = result("shipping_address")
        Dim shippingaddressfields = New ArrayList From {
            "is_address_ship_forward",
            "is_bill_country_match",
            "is_bill_state_match",
            "is_bill_city_match",
            "is_bill_postcode_match",
            "is_export_controlled_country",
            "is_in_blacklist"
        }

        For Each field In shippingaddressfields
            Console.WriteLine("shipping_address." & field.ToString & ": " & shippingaddress(field).ToString)
        Next

        Dim emailaddress = result("email_address")
        Dim emailaddressfields = New ArrayList From {
            "is_free",
            "is_disposable",
            "is_domain_exist",
            "is_new_domain_name",
            "is_in_blacklist"
        }

        For Each field In emailaddressfields
            Console.WriteLine("email_address." & field.ToString & ": " & emailaddress(field).ToString)
        Next

        Dim phonenumber = result("phone_number")
        Dim phonenumberfields = New ArrayList From {
            "is_disposable",
            "is_in_blacklist"
        }

        For Each field In phonenumberfields
            Console.WriteLine("phone_number." & field.ToString & ": " & phonenumber(field).ToString)
        Next

        Dim username = result("username")
        Dim usernamefields = New ArrayList From {
            "is_high_risk",
            "is_in_blacklist"
        }

        For Each field In usernamefields
            Console.WriteLine("username." & field.ToString & ": " & username(field).ToString)
        Next

        Dim creditcard = result("credit_card")
        Dim creditcardfields = New ArrayList From {
            "card_brand",
            "card_type",
            "card_issuing_bank",
            "card_issuing_country",
            "is_prepaid",
            "is_bin_exist",
            "is_bin_country_match",
            "is_in_blacklist"
        }

        For Each field In creditcardfields
            Console.WriteLine("credit_card." & field.ToString & ": " & creditcard(field).ToString)
        Next

        Dim device = result("device")
        Dim devicefields = New ArrayList From {
            "is_malware_exploit",
            "is_in_blacklist"
        }

        For Each field In devicefields
            Console.WriteLine("device." & field.ToString & ": " & device(field).ToString)
        Next

        Console.WriteLine("user_order_id: " & result("user_order_id").ToString)
        Console.WriteLine("fraudlabspro_id: " & result("fraudlabspro_id").ToString)
        Console.WriteLine("fraudlabspro_score: " & result("fraudlabspro_score").ToString)
        Console.WriteLine("fraudlabspro_status: " & result("fraudlabspro_status").ToString)
        Console.WriteLine("fraudlabspro_rules: " & result("fraudlabspro_rules").ToString)
        Console.WriteLine("api_version: " & result("api_version").ToString)
        Console.WriteLine("remaining_credits: " & result("remaining_credits").ToString)
    End Sub
End Module
```


### Get Order Result

#### Parameter Properties

| Parameter Name | Parameter Type | Description                                                  |
| -------------- | -------------- | ------------------------------------------------------------ |
| ID            | string         | FraudLabs Pro transaction ID or Order ID.                    |
| IDType          | string         | ID type. Either: **Order.IDTypes.FLP_ID** or **Order.IDTypes.ORDER_ID** |

```vb.net
Imports FraudLabsPro.FraudLabsPro
Imports Newtonsoft.Json

Module Program
    Sub Main()
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        Dim GetOrderPara As New OrderPara With {
            .ID = "20240112-1EILFK",
            .IDType = Order.IDTypes.FLP_ID
        }

        'Get Order Result API
        Dim OrderResult As New Order
        Dim result = OrderResult.GetOrderResult(GetOrderPara) 'Get order result from FraudLabs Pro

        'pretty-print JSON
        'Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented))

        Dim ipgeolocation = result("ip_geolocation")
        Dim ipgeolocationfields = New ArrayList From {
            "ip",
            "continent",
            "country_code",
            "country_name",
            "region",
            "city",
            "latitude",
            "longitude",
            "zip_code",
            "timezone",
            "isp_name",
            "domain",
            "netspeed",
            "mobile_mnc",
            "mobile_mcc",
            "mobile_brand",
            "elevation",
            "usage_type",
            "is_proxy",
            "is_in_blacklist"
        }

        For Each field In ipgeolocationfields
            Console.WriteLine("ip_geolocation." & field.ToString & ": " & ipgeolocation(field).ToString)
        Next

        Dim billingaddress = result("billing_address")
        Dim billingaddressfields = New ArrayList From {
            "ip_distance_in_km",
            "ip_distance_in_mile",
            "is_ip_country_match"
        }

        For Each field In billingaddressfields
            Console.WriteLine("billing_address." & field.ToString & ": " & billingaddress(field).ToString)
        Next

        Dim shippingaddress = result("shipping_address")
        Dim shippingaddressfields = New ArrayList From {
            "is_address_ship_forward",
            "is_bill_country_match",
            "is_bill_state_match",
            "is_bill_city_match",
            "is_bill_postcode_match",
            "is_export_controlled_country",
            "is_in_blacklist"
        }

        For Each field In shippingaddressfields
            Console.WriteLine("shipping_address." & field.ToString & ": " & shippingaddress(field).ToString)
        Next

        Dim emailaddress = result("email_address")
        Dim emailaddressfields = New ArrayList From {
            "is_free",
            "is_disposable",
            "is_domain_exist",
            "is_new_domain_name",
            "is_in_blacklist"
        }

        For Each field In emailaddressfields
            Console.WriteLine("email_address." & field.ToString & ": " & emailaddress(field).ToString)
        Next

        Dim phonenumber = result("phone_number")
        Dim phonenumberfields = New ArrayList From {
            "is_disposable",
            "is_in_blacklist"
        }

        For Each field In phonenumberfields
            Console.WriteLine("phone_number." & field.ToString & ": " & phonenumber(field).ToString)
        Next

        Dim username = result("username")
        Dim usernamefields = New ArrayList From {
            "is_high_risk",
            "is_in_blacklist"
        }

        For Each field In usernamefields
            Console.WriteLine("username." & field.ToString & ": " & username(field).ToString)
        Next

        Dim creditcard = result("credit_card")
        Dim creditcardfields = New ArrayList From {
            "card_brand",
            "card_type",
            "card_issuing_bank",
            "card_issuing_country",
            "is_prepaid",
            "is_bin_exist",
            "is_bin_country_match",
            "is_in_blacklist"
        }

        For Each field In creditcardfields
            Console.WriteLine("credit_card." & field.ToString & ": " & creditcard(field).ToString)
        Next

        Dim device = result("device")
        Dim devicefields = New ArrayList From {
            "is_malware_exploit",
            "is_in_blacklist"
        }

        For Each field In devicefields
            Console.WriteLine("device." & field.ToString & ": " & device(field).ToString)
        Next

        Console.WriteLine("user_order_id: " & result("user_order_id").ToString)
        Console.WriteLine("fraudlabspro_id: " & result("fraudlabspro_id").ToString)
        Console.WriteLine("fraudlabspro_score: " & result("fraudlabspro_score").ToString)
        Console.WriteLine("fraudlabspro_status: " & result("fraudlabspro_status").ToString)
        Console.WriteLine("fraudlabspro_rules: " & result("fraudlabspro_rules").ToString)
    End Sub
End Module
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
Imports Newtonsoft.Json

Module Program
    Sub Main()
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Set FeedBack Order parameter
        Dim FeedBackPara As New OrderPara With {
            .ID = "20240112-1EILFK",
            .Action = Order.Action.APPROVE,  ' Please refer to reference section for full list of feedback statuses
            .Note = "This customer made a valid purchase before."
        }

        'Feedback Order API
        Dim FeedbackOrder As New Order
        Dim result = FeedbackOrder.FeedbackOrder(FeedBackPara)

        'pretty-print JSON
        'Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented))

        Console.WriteLine("fraudlabspro_id: " & result("fraudlabspro_id").ToString)
    End Sub
End Module
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
Imports Newtonsoft.Json

Module Program
    Sub Main()
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Send SMS Verification API
        Dim SendSMS As New SMSVerification

        'Sets SMS details for authentication purpose
        Dim SMSPara As New SMSVerificationPara With {
            .Tel = "+123456789",
            .CountryCode = "US",
            .Message = "Hi, your OTP is <otp>."
        }

        Dim result = SendSMS.SendSMS(SMSPara)

        'pretty-print JSON
        'Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented))

        Console.WriteLine("tran_id: " & result("tran_id").ToString)
        Console.WriteLine("credits_remaining: " & result("credits_remaining").ToString)
    End Sub
End Module
```



### Get SMS Verification Result

#### Object Properties

| Property Name | Property Type | Description                                                  |
| ------------- | :-----------: | ------------------------------------------------------------ |
| TransactionID |    string     | The unique ID that was returned by the Send SMS Verification that triggered the OTP sms. |
| OTP           |    string     | The OTP that was sent to the recipient’s phone. |

```vb.net
Imports FraudLabsPro.FraudLabsPro
Imports Newtonsoft.Json

Module Program
    Sub Main()
        'Configure FraudLabs Pro API KEY
        FraudLabsProConfig.APIKey = "YOUR_API_KEY"

        'Get Verification Result API
        Dim VerifySMS As New SMSVerification

        'Sets SMS details for authentication purpose
        Dim SMSPara As New SMSVerificationPara With {
            .TransactionID = "UNIQUE_TRANS_ID",
            .OTP = "OTP_RECEIVED"
        }

        Dim result = VerifySMS.VerifySMS(SMSPara)

        'pretty-print JSON
        'Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented))

        Console.WriteLine("result: " & result("result").ToString)
    End Sub
End Module
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
