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

# Developer Documentation
To learn more about installation, usage, and code examples, please visit the developer documentation at [https://fraudlabspro-dotnet.readthedocs.io/en/latest/index.html.](https://fraudlabspro-dotnet.readthedocs.io/en/latest/index.html)

# Reference

#### Payment Method

| Payment Method                       |
| ------------------------------------ |
| Order.PaymentMethods.CREDIT_CARD      |
| Order.PaymentMethods.PAYPAL           |
| Order.PaymentMethods.CASH_ON_DELIVERY |
| Order.PaymentMethods.BANK_DEPOSIT     |
| Order.PaymentMethods.GIFT_CARD        |
| Order.PaymentMethods.CRYPTO           |
| Order.PaymentMethods.WIRE_TRANSFER    |
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
