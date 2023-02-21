Imports System.Security.Cryptography

Namespace FraudLabsPro
    Public Class OrderPara
        'Common Parameter
        Private Fmt As String = "json"
        'Parameter for Screen Order
        Private Flp_Check_Sum As String = ""
        Private User_Name As String = ""
        Private Password_ As String = ""
        'Billing Information
        Private IP As String = ""
        Private First_Name As String = ""
        Private Last_Name As String = ""
        Private Email As String = ""
        Private Email_Domain As String = ""
        Private User_Phone As String = ""
        Private Bill_Address As String = ""
        Private Bill_City As String = ""
        Private Bill_State As String = ""
        Private Bill_Country As String = ""
        Private Bill_ZIPCode As String = ""
        'Order Information
        Private User_Order_Id As String = ""
        Private User_Order_Memo As String = ""
        Private Amnt As Decimal = 0
        Private Qty As Integer = 1
        Private Currenc As String = "USD"
        Private Dpartment As String = ""
        Private Payment_Mode As String = ""
        'Credit Card Information
        Private Card_Number As String = ""
        Private Bin_No As String = ""
        Private Avs_Result As String = ""
        Private Cvv_Result As String = ""
        'Shipping Information
        Private Shipping_Address As String = ""
        Private Shipping_City As String = ""
        Private Shipping_State As String = ""
        Private Shipping_ZIPCode As String = ""
        Private Shipping_Country As String = ""
        'Common Parameter for following Function
        Private Identity As String = ""
        'Parameter for Feedback Order
        Private Status As String = ""
        Private Memo As String = ""
        Public Source As String = "sdk-net"
        'Parameter for Get Order Result
        Private ID_Type As String = ""

        'Screen Order GetSet
        Public Property FLPCheckSum As String
            Get
                Return Flp_Check_Sum
            End Get
            Set(value As String)
                Flp_Check_Sum = value
            End Set
        End Property
        Public Property IPAddress() As String
            Get
                Return IP
            End Get
            Set(value As String)
                IP = value

            End Set
        End Property
        Public Property FirstName() As String
            Get
                Return First_Name
            End Get
            Set(value As String)

                First_Name = value

            End Set
        End Property
        Public Property LastName() As String
            Get
                Return Last_Name
            End Get
            Set(value As String)
                Last_Name = value

            End Set
        End Property
        Public Property Username() As String
            Get
                Return User_Name
            End Get
            Set(value As String)
                User_Name = value
            End Set
        End Property
        Public Property Password() As String
            Get
                Return Password_
            End Get
            Set(value As String)
                Password_ = value
            End Set
        End Property
        Public Property EmailAddress() As String
            Get
                Return Email
            End Get
            Set(value As String)
                Email = value
                Dim startindex As Integer = Email.IndexOf("@")
                Email_Domain = Email.Substring(startindex + 1)
            End Set
        End Property
        Public Property EmailDomain() As String
            Get
                Return Email_Domain
            End Get
            Set(value As String)
                Email_Domain = value
            End Set
        End Property
        Public Property UserPhone() As String
            Get
                Return User_Phone
            End Get
            Set(value As String)

                User_Phone = value
            End Set
        End Property
        Public Property BillAddress() As String
            Get
                Return Bill_Address
            End Get
            Set(value As String)

                Bill_Address = value
            End Set
        End Property
        Public Property BillCity() As String
            Get
                Return Bill_City
            End Get
            Set(value As String)

                Bill_City = value
            End Set
        End Property
        Public Property BillState() As String
            Get
                Return Bill_State
            End Get
            Set(value As String)

                Bill_State = value
            End Set
        End Property
        Public Property BillZIPCode() As String
            Get
                Return Bill_ZIPCode
            End Get
            Set(value As String)

                Bill_ZIPCode = value
            End Set
        End Property
        Public Property BillCountry() As String
            Get
                Return Bill_Country
            End Get
            Set(value As String)

                Bill_Country = value
            End Set
        End Property
        Public Property UserOrderID() As String
            Get
                Return User_Order_Id
            End Get
            Set(value As String)

                User_Order_Id = value
            End Set
        End Property
        Public Property UserOrderMemo() As String
            Get
                Return User_Order_Memo
            End Get
            Set(value As String)

                User_Order_Memo = value
            End Set
        End Property
        Public Property Amount() As Decimal
            Get
                Return Amnt
            End Get
            Set(value As Decimal)

                Amnt = value
            End Set
        End Property
        Public Property Quantity() As Integer
            Get
                Return Qty
            End Get
            Set(value As Integer)

                Qty = value
            End Set
        End Property
        Public Property Currency() As String
            Get
                Return Currenc
            End Get
            Set(value As String)

                Currenc = value
            End Set
        End Property
        Public Property Department() As String
            Get
                Return Dpartment
            End Get
            Set(value As String)

                Dpartment = value
            End Set
        End Property
        Public Property PaymentMode() As String
            Get
                Return Payment_Mode
            End Get
            Set(value As String)

                Payment_Mode = value
            End Set
        End Property
        Public Property CardNumber() As String
            Get
                Return Card_Number
            End Get
            Set(value As String)
                Card_Number = value
                Bin_No = Card_Number.Substring(0, 6)
            End Set
        End Property
        Public Property BinNo() As String
            Get
                Return Bin_No
            End Get
            Set(value As String)
                Bin_No = value
            End Set
        End Property
        Public Property AvsResult() As String
            Get
                Return Avs_Result
            End Get
            Set(value As String)

                Avs_Result = value
            End Set
        End Property
        Public Property CvvResult() As String
            Get
                Return Cvv_Result
            End Get
            Set(value As String)

                Cvv_Result = value
            End Set
        End Property
        Public Property ShippingAddress() As String
            Get
                Return Shipping_Address
            End Get
            Set(value As String)

                Shipping_Address = value
            End Set
        End Property
        Public Property ShippingCity() As String
            Get
                Return Shipping_City
            End Get
            Set(value As String)

                Shipping_City = value
            End Set
        End Property
        Public Property ShippingState() As String
            Get
                Return Shipping_State
            End Get
            Set(value As String)

                Shipping_State = value
            End Set
        End Property
        Public Property ShippingZIPCode() As String
            Get
                Return Shipping_ZIPCode
            End Get
            Set(value As String)

                Shipping_ZIPCode = value
            End Set
        End Property
        Public Property ShippingCountry() As String
            Get
                Return Shipping_Country
            End Get
            Set(value As String)

                Shipping_Country = value
            End Set
        End Property
        Public ReadOnly Property Format() As String
            Get
                Return Fmt
            End Get
        End Property
        'Common Parameter GetSet
        Public Property ID() As String
            Get
                Return Identity
            End Get
            Set(value As String)
                Identity = value
            End Set
        End Property
        'FeedBack Order GetSet
        Public Property Action() As String
            Get
                Return Status
            End Get
            Set(value As String)
                Status = value
            End Set
        End Property
        Public Property Note() As String
            Get
                Return Memo
            End Get
            Set(value As String)
                Memo = value
            End Set
        End Property
        'Get Order Result GetSet
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