# Quickstart

## Dependencies

This module requires API key to function. You may subscribe a free API key at [https://www.fraudlabspro.com](https://www.fraudlabspro.com)

## Installation

This module is available at NuGet: [https://www.nuget.org/packages/FraudLabsPro](https://www.nuget.org/packages/FraudLabsPro)

## Sample Codes

### Validate Order

You can validate your order as below:

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

### Get Transaction

You can get the details of a transaction as below:

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

You can approve, reject or ignore a transaction as below:

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

### Send SMS Verification

You can send SMS verification for authentication purpose as below:

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

You can verify the OTP sent by Fraudlabs Pro SMS verification API as below:

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