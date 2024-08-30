# FraudLabs Pro VB.NET API

## FraudLabsProConfig Class
```{py:data} APIKEY
FraudLabs Pro API key.

:type: String
```

## Order Class
```{py:class} Order()
Initiate FraudValidation class.
```

```{py:function} GetOrderResult(Data)
Retrieve an existing transaction from FraudLabs Pro fraud detection system.

:param array Data: (Required) The parameters of FraudLabs Pro transaction details.

| Parameter Name | Parameter Type | Description                                                  |
| -------------- | -------------- | ------------------------------------------------------------ |
| ID            | string         | FraudLabs Pro transaction ID or Order ID.                    |
| IDType          | string         | ID type. Either: **Order.IDTypes.FLP_ID** or **Order.IDTypes.ORDER_ID** |

:return: Returns the details about the transaction in JSON object.
:rtype: Object

| Parameter                                     | Type    | Description |
|-----------------------------------------------|---------|--------------|
| ip_geolocation.ip                             | string  | IP address of the transaction. |
| ip_geolocation.continent                      | string  | Estimated continent of the IP address. |
| ip_geolocation.country_code                   | string  | Estimated ISO-3166 alpha-2 country code of the IP address. |
| ip_geolocation.country_name                   | string  | Estimated country of the IP address. |
| ip_geolocation.region                         | string  | Estimated region of the IP address. |
| ip_geolocation.city                           | string  | Estimated city of the IP address. |
| ip_geolocation.latitude                       | decimal | Estimated latitude of the IP address in 4 precisions. |
| ip_geolocation.longitude                      | decimal | Estimated longitude of the IP address in 4 precisions. |
| ip_geolocation.zip_code                       | string  | Estimated ZIP code of the IP address. |
| ip_geolocation.timezone                       | string  | Estimated timezone of the IP address. |
| ip_geolocation.isp_name                       | string  | Estimated ISP name of the IP address. |
| ip_geolocation.domain                         | string  | Estimated domain name of the IP address. |
| ip_geolocation.netspeed                       | string  | Estimated netspeed of the IP address. |
| ip_geolocation.mobile_mnc                     | string  | Estimated mobile mnc information of the IP address, if it is a mobile network. |
| ip_geolocation.mobile_mcc                     | string  | Estimated mobile mcc information of the IP address, if it is a mobile network. |
| ip_geolocation.mobile_brand                   | string  | Estimated mobile brand information of the IP address, if it is a mobile network. |
| ip_geolocation.elevation                      | integer | Estimated elevation of the IP address. |
| ip_geolocation.usage_type                     | string  | Estimated usage type of the IP address. Return values as below: <br/>• Commercial<br/>• Organization<br/>• Government<br/>• Military<br/>• University/College/School<br/>• Library<br/>• Content Delivery Network<br/>• Fixed Line ISP<br/>• Mobile ISP<br/>• Data Center/Web Hosting/Transit<br/>• Search Engine Spider |
| ip_geolocation.is_proxy                       | boolean | Whether the IP address is from a known anonymous proxy server. |
| ip_geolocation.is_in_blacklist                | boolean | Whether the IP address is in our blacklist database. |
| billing_address.distance_in_km                | integer | Distance of location between IP address and bill. Value in kilometer. |
| billing_address.distance_in_mile              | integer | Distance of location between IP address and bill. Value in mile. |
| billing_address.is_ip_country_match           | boolean | Whether country of IP address matches billing address country. |
| shipping_address.is_address_ship_forward      | boolean | Whether the shipping address is in database of known mail drops. |
| shipping_address.is_bill_city_match           | boolean | Whether the billing city matches the shipping city. |
| shipping_address.is_bill_state_match          | boolean | Whether the billing state matches the shipping state. |
| shipping_address.is_bill_country_match        | boolean | Whether the billing country matches the shipping country. |
| shipping_address.is_bill_postcode_match       | boolean | Whether the billing postal/zip code matches the shipping postal/zip code. |
| shipping_address.is_export_controlled_country | boolean | Whether the country is from an embargoed country. |
| shipping_address.is_in_blacklist              | boolean | Whether the ship address is in our blacklist database. |
| email_address.is_free                         | boolean | Whether the email is from free email provider. |
| email_address.is_disposable                   | boolean | Whether the email is a disposable email. Only applicable for Small Plan onward. |
| email_address.is_domain_exists                | boolean | Whether the email domain name is a valid domain. |
| email_address.is_new_domain_name              | boolean | Whether the email domain name a newly registered name. Only applicable for non-free email domain. |
| email_address.is_in_blacklist                 | boolean | Whether the email address is in our blacklist database. |
| phone_number.is_disposable                    | boolean | Whether the phone number is a disposable phone number. Only applicable for Medium Plan onward. |
| phone_number.is_in_blacklist                  | boolean | Whether the user's phone number is in our blacklist database. |
| username.is_high_risk                         | boolean | Whether the username is in our high risk database. |
| username.is_in_blacklist                      | boolean | Whether the username is in our blacklist database. |
| credit_card.card_brand                        | string  | The brand of the card. Available on Medium plan onward only. |
| credit_card.card_type                         | string  | Whether the card is a type of credit or debit. Available on Medium plan onward only. |
| credit_card.card_issuing_bank                 | string  | The name of the bank where the card being issued. Available on Medium plan onward only. |
| credit_card.card_issuing_country              | string  | The ISO-3166 alpha-2 Country Codes where the card being issued. Available on Medium plan onward only. |
| credit_card.is_prepaid                        | boolean | Whether the credit card is a type of prepaid card. |
| credit_card.is_bin_exist                      | boolean | Whether the BIN information matches our BIN list. |
| credit_card.is_bin_country_match              | boolean | Whether the country of issuing bank matches BIN country code. |
| credit_card.is_in_blacklist                   | boolean | Whether the credit card is in our blacklist database. |
| device.is_malware_exploit                     | boolean | Whether the machine is infected. |
| device.is_in_blacklist                        | boolean | Whether the device Id is in our blacklist database. |
| user_order_id                                 | string  | Return the order identifier given by merchant earlier. |
| fraudlabspro_id                               | string  | System own unique identifier to identify this API transaction. |
| fraudlabspro_score                            | integer | Overall score between 1 and 100. 100 is the highest risk and 1 is the lowest risk. |
| fraudlabspro_status                           | string  | Final action based on the rules analysis. Return values: APPROVE \| REJECT \| REVIEW |
| fraudlabspro_rules                            | array   | Return the rules triggered by the system. Available on Mini plan onward only.  |

```

```{py:function} FeedbackOrder(Data)
Approve, reject or ignore a transaction.

:param array Data: (Required) The parameters of order details.

| Parameter    | Type    | Description |
|--------------|---------|---------------------|
| ID          | string  | (required) Unique transaction Id generated by Fraud Check API. |
| Action         | string  | (required) Perform APPROVE, REJECT, or REJECT_BLACKLIST action to transaction.<br/>• APPROVE: Approve a transaction<br/>• REJECT: Reject a transaction<br/>• REJECT_BLACKLIST: Reject and blacklist the transaction<br/>When a transaction was blacklisted, the information will be recorded into the system for future blacklist validation check. |
| Note  | string | (optional) Notes for the feedback request. |
```

```{py:function} ScreenOrder(Data)
Retrieve geolocation information for an IP address.

:param array Data: (Required) The details of a transaction.

| Parameter       | Type    | Description |
|-----------------|---------|-----------------|
| IPAddress              | string  | (required) IP address of online transaction. It supports both IPv4 and IPv6 address format. |
| LastName       | string  | (optional) User's last name. |
| FirstName      | string  | (optional) User's first name. |
| UserName        | string  | User's username.                                             |
| Password        | string  | User's password.                                             |
| EmailAddress           | string  | (optional) User's email address.                                        |
| UserPhone           | string  | (optional) User's phone number.                                         |
| BillAddress       | string  | (optional) Street address of billing address. |
| BillCity       | string  | (optional) City of billing address. |
| BillState      | string  | (optional) State of billing address. It supports state codes, e.g. NY (New York), for state or province of United States or Canada.|
| BillCountry    | string  | (optional) Country of billing address. It requires the input of ISO-3166 alpha-2 country code, e.g. US for United States.|
| BillZIPCode   | string  | (optional) Postal or ZIP code of billing address. |
| ShippingLastName       | string  | (optional) Receiver's last name. |
| ShippingFirstName      | string  | (optional) Receiver's first name. |
| ShippingAddress       | string  | (optional) Street address of shipping address. |
| ShippingCity       | string  | (optional) City of shipping address. |
| ShippingState      | string  | (optional) State of shipping address. It supports state codes, e.g. NY - New York, for state or province of United States or Canada. |
| ShippingCountry    | string  | (optional) Country of shipping address. It requires the input of ISO-3166 alpha-2 country code, e.g. US for United States. |
| ShippingZIPCode   | string  | (optional) Postal or ZIP code of shipping address. |
| CardNumber          | string  | (optional) Billing credit card number or BIN number.                    |
| AvsResult             | string  | (optional) The single character AVS result returned by the credit card processor. |
| CvvResult             | string  | (optional) The single character CVV2 result returned by the credit card processor.<br/> This is not for the input of the actual CVV code from the back of the credit card. |
| UserOrderID   | string  | (optional) Merchant identifier to uniquely identify a transaction. It supports<br/> maximum of 15 characters user order id input. |
| UserOrderMemo          | string        | (optional) Merchant description of an order transaction. It supports maximum of 200 characters. |
| Amount          | float | (optional) Amount of the transaction. |
| Quantity        | integer | (optional) Total quantity of the transaction. |
| Currency        | string  | (optional) Currency code used in the transaction. It requires the input of<br/> ISO-4217 (3 characters) currency code, e.g. USD for US Dollar. |
| Department      | string  | (optional) Merchant identifier to uniquely identify a product or service department. |
| PaymentGateway  | string  | (optional) The name of payment gateway used to capture the payment. |
| PaymentMode    | string  | (optional) Payment mode of transaction. Valid values: creditcard \| paypal \| cod \| bankdeposit \| giftcard \| crypto \| wired \| others |
| FLPCheckSum    | string        | Checksum for the device validation. Please visit [Agent Javascript](https://www.fraudlabspro.com/developer/javascript) to learn about the use of this parameter. |

:return: Returns the geolocation information in array. Refer below table for the fields avaliable in the array
:rtype: array

**RETURN FIELDS**

| Parameter                                     | Type    | Description |
|-----------------------------------------------|---------|--------------|
| ip_geolocation.ip                             | string  | IP address of the transaction. |
| ip_geolocation.continent                      | string  | Estimated continent of the IP address. |
| ip_geolocation.country_code                   | string  | Estimated ISO-3166 alpha-2 country code of the IP address. |
| ip_geolocation.country_name                   | string  | Estimated country of the IP address. |
| ip_geolocation.region                         | string  | Estimated region of the IP address. |
| ip_geolocation.city                           | string  | Estimated city of the IP address. |
| ip_geolocation.latitude                       | decimal | Estimated latitude of the IP address in 4 precisions. |
| ip_geolocation.longitude                      | decimal | Estimated longitude of the IP address in 4 precisions. |
| ip_geolocation.zip_code                       | string  | Estimated ZIP code of the IP address. |
| ip_geolocation.timezone                       | string  | Estimated timezone of the IP address. |
| ip_geolocation.isp_name                       | string  | Estimated ISP name of the IP address. |
| ip_geolocation.domain                         | string  | Estimated domain name of the IP address. |
| ip_geolocation.netspeed                       | string  | Estimated netspeed of the IP address. |
| ip_geolocation.mobile_mnc                     | string  | Estimated mobile mnc information of the IP address, if it is a mobile network. |
| ip_geolocation.mobile_mcc                     | string  | Estimated mobile mcc information of the IP address, if it is a mobile network. |
| ip_geolocation.mobile_brand                   | string  | Estimated mobile brand information of the IP address, if it is a mobile network. |
| ip_geolocation.elevation                      | integer | Estimated elevation of the IP address. |
| ip_geolocation.usage_type                     | string  | Estimated usage type of the IP address. Return values as below: <br/>• Commercial<br/>• Organization<br/>• Government<br/>• Military<br/>• University/College/School<br/>• Library<br/>• Content Delivery Network<br/>• Fixed Line ISP<br/>• Mobile ISP<br/>• Data Center/Web Hosting/Transit<br/>• Search Engine Spider   |
| ip_geolocation.is_proxy                       | boolean | Whether the IP address is from a known anonymous proxy server. |
| ip_geolocation.is_in_blacklist                | boolean | Whether the IP address is in our blacklist database. |
| billing_address.distance_in_km                | integer | Distance of location between IP address and bill. Value in kilometer. |
| billing_address.distance_in_mile              | integer | Distance of location between IP address and bill. Value in mile. |
| billing_address.is_ip_country_match           | boolean | Whether country of IP address matches billing address country. |
| shipping_address.is_address_ship_forward      | boolean | Whether the shipping address is in database of known mail drops. |
| shipping_address.is_bill_city_match           | boolean | Whether the billing city matches the shipping city. |
| shipping_address.is_bill_state_match          | boolean | Whether the billing state matches the shipping state. |
| shipping_address.is_bill_country_match        | boolean | Whether the billing country matches the shipping country. |
| shipping_address.is_bill_postcode_match       | boolean | Whether the billing postal/zip code matches the shipping postal/zip code. |
| shipping_address.is_export_controlled_country | boolean | Whether the country is from an embargoed country. |
| shipping_address.is_in_blacklist              | boolean | Whether the ship address is in our blacklist database. |
| email_address.is_free                         | boolean | Whether the email is from free email provider. |
| email_address.is_disposable                   | boolean | Whether the email is a disposable email. Only applicable for Small Plan onward. |
| email_address.is_domain_exists                | boolean | Whether the email domain name is a valid domain. |
| email_address.is_new_domain_name              | boolean | Whether the email domain name a newly registered name. Only applicable for non-free email domain. |
| email_address.is_in_blacklist                 | boolean | Whether the email address is in our blacklist database. |
| phone_number.is_disposable                    | boolean | Whether the phone number is a disposable phone number. Only applicable for Medium Plan onward. |
| phone_number.is_in_blacklist                  | boolean | Whether the user's phone number is in our blacklist database. |
| username.is_high_risk                         | boolean | Whether the username is in our high risk database. |
| username.is_in_blacklist                      | boolean | Whether the username is in our blacklist database. |
| credit_card.card_brand                        | string  | The brand of the card. Available on Medium plan onward only. |
| credit_card.card_type                         | string  | Whether the card is a type of credit or debit. Available on Medium plan onward only. |
| credit_card.card_issuing_bank                 | string  | The name of the bank where the card being issued. Available on Medium plan onward only. |
| credit_card.card_issuing_country              | string  | The ISO-3166 alpha-2 Country Codes where the card being issued. Available on Medium plan onward only. |
| credit_card.is_prepaid                        | boolean | Whether the credit card is a type of prepaid card. |
| credit_card.is_bin_exist                      | boolean | Whether the BIN information matches our BIN list. |
| credit_card.is_bin_country_match              | boolean | Whether the country of issuing bank matches BIN country code. |
| credit_card.is_in_blacklist                   | boolean | Whether the credit card is in our blacklist database. |
| device.is_malware_exploit                     | boolean | Whether the machine is infected. |
| device.is_in_blacklist                        | boolean | Whether the device Id is in our blacklist database. |
| user_order_id                                 | string  | Return the order identifier given by merchant earlier. |
| fraudlabspro_id                               | string  | System own unique identifier to identify this API transaction. |
| fraudlabspro_score                            | integer | Overall score between 1 and 100. 100 is the highest risk and 1 is the lowest risk. |
| fraudlabspro_status                           | string  | Final action based on the rules analysis. Return values: APPROVE \| REJECT \| REVIEW |
| fraudlabspro_rules                            | array   | Return the rules triggered by the system. Available on Mini plan onward only. |
| api_version                                   | string  | Version of the fraud analysis engine used in this transaction. |
| remaining_credits                             | integer | Balance of queries in your account after this transaction. |
```

## SMSVerification Class
```{py:class} SMSVerification()
Initiate SMSVerification class.
```

```{py:function} SendSMS(Data)
Send SMS Verification for authentication.

:param array Data: (Required) Parameters of sms details.

| Parameter    | Type    | Description |
|--------------|---------|---------------------|
| Tel          | string  | (required) The recipient mobile phone number in E164 format which is a plus followed by just numbers with no spaces or parentheses.  For example, +12015550123  |
| CountryCode | string  | (optional) ISO 3166 country code for the recipient mobile phone number. If parameter is supplied, then some basic telephone number validation is done. |
| Message         | string  | (required) The message template for the SMS. Add &lt;otp&gt; as placeholder for the actual OTP to be generated. Max length is 140 characters.  For example, Your OTP for the transaction is &lt;otp&gt;  |
| OtpTimeout  | integer |  (optional) Timeout feature for OTP value in seconds. Default is 3600 seconds(1 hour). Min timeout is 15 seconds whereas max timeout is 86400 seconds(24 hours). |


:return: Returns the details about the transaction in JSON object.
:rtype: Object

| Parameter         | Type   | Description |
|-------------------|--------|-------------|
| tran_id           | string | Unique ID (20 characters) for this particular API call. |
| credits_remaining | string | Number of remaining credits for sending SMS. |

```

```{py:function} VerifySMS(Data)
Get SMS Verification result.

:param array Data: (Required) Parameters of sms details.

| Parameter         | Type   | Description |
|-------------------|--------|-------------|
| TransactionID           | string | (required) Unique ID (20 characters) for this particular API call. |
| OTP               | string | (required) The OTP that was sent to the recipient’s phone. |

:return: Returns the details about the transaction in JSON object.
:rtype: Object

| Parameter         | Type   | Description |
|-------------------|--------|-------------|
| result           | string | Indicates if the input parameters matched a valid OTP. Y if a valid OTP is found and N if no valid OTP found. |
```