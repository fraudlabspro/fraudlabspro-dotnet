Namespace FraudLabsPro
    Public Class OrderResultObj
        Private iscountrymatch As String
        Public Property is_country_match() As String
            Get
                Return iscountrymatch
            End Get
            Set(value As String)
                iscountrymatch = value
            End Set
        End Property
        Private ishighriskcountry As String
        Public Property is_high_risk_country() As String
            Get
                Return ishighriskcountry
            End Get
            Set(value As String)
                ishighriskcountry = value
            End Set
        End Property
        Private distanceinkm As String
        Public Property distance_in_km() As String
            Get
                Return distanceinkm
            End Get
            Set(value As String)
                distanceinkm = value
            End Set
        End Property
        Private distanceinmile As String
        Public Property distance_in_mile() As String
            Get
                Return distanceinmile
            End Get
            Set(value As String)
                distanceinmile = value
            End Set
        End Property
        Private ipcountry As String
        Public Property ip_country() As String
            Get
                Return ipcountry
            End Get
            Set(value As String)
                ipcountry = value
            End Set
        End Property
        Private ipregion As String
        Public Property ip_region() As String
            Get
                Return ipregion
            End Get
            Set(value As String)
                ipregion = value
            End Set
        End Property
        Private ipcity As String
        Public Property ip_city() As String
            Get
                Return ipcity
            End Get
            Set(value As String)
                ipcity = value
            End Set
        End Property
        Private ipcontinent As String
        Public Property ip_continent() As String
            Get
                Return ipcontinent
            End Get
            Set(value As String)
                ipcontinent = value
            End Set
        End Property
        Private iplatitude As String
        Public Property ip_latitude() As String
            Get
                Return iplatitude
            End Get
            Set(value As String)
                iplatitude = value
            End Set

        End Property
        Private iplongtitude As String
        Public Property ip_longitude() As String
            Get
                Return iplongtitude
            End Get
            Set(value As String)
                iplongtitude = value

            End Set
        End Property
        Private iptimezone As String
        Public Property ip_timezone() As String
            Get
                Return iptimezone
            End Get
            Set(value As String)
                iptimezone = value
            End Set
        End Property
        Private ipelevation As String
        Public Property ip_elevation() As String
            Get
                Return ipelevation
            End Get
            Set(value As String)
                ipelevation = value
            End Set
        End Property
        Private ipdomain As String
        Public Property ip_domain() As String
            Get
                Return ipdomain
            End Get
            Set(value As String)
                ipdomain = value
            End Set
        End Property
        Private ipmobilemnc As String
        Public Property ip_mobile_mnc() As String
            Get
                Return ipmobilemnc
            End Get
            Set(value As String)
                ipmobilemnc = value
            End Set
        End Property
        Private ipmobilemcc As String
        Public Property ip_mobile_mcc() As String
            Get
                Return ipmobilemcc
            End Get
            Set(value As String)
                ipmobilemcc = value
            End Set
        End Property
        Private ipmobilebrand As String
        Public Property ip_mobile_brand() As String
            Get
                Return ipmobilebrand
            End Get
            Set(value As String)
                ipmobilebrand = value

            End Set
        End Property
        Private ipnetspeed As String
        Public Property ip_netspeed() As String
            Get
                Return ipnetspeed
            End Get
            Set(value As String)
                ipnetspeed = value
            End Set
        End Property
        Private ipispname As String
        Public Property ip_isp_name() As String
            Get
                Return ipispname
            End Get
            Set(value As String)
                ipispname = value
            End Set
        End Property
        Private ipusagetype As String
        Public Property ip_usage_type() As String
            Get
                Return ipusagetype
            End Get
            Set(value As String)
                ipusagetype = value
            End Set
        End Property
        Private isfreeemail As String
        Public Property is_free_email() As String
            Get
                Return isfreeemail
            End Get
            Set(value As String)
                isfreeemail = value
            End Set
        End Property
        Private isdisposalbeemail As String
        Public Property is_disposable_email() As String
            Get
                Return isdisposalbeemail
            End Get
            Set(value As String)
                isdisposalbeemail = value
            End Set
        End Property
        Private isnewdomainname As String
        Public Property is_new_domain_name() As String
            Get
                Return isnewdomainname
            End Get
            Set(value As String)
                isnewdomainname = value
            End Set
        End Property
        Private isdomainexists As String
        Public Property is_domain_exists() As String
            Get
                Return isdomainexists
            End Get
            Set(value As String)
                isdomainexists = value
            End Set
        End Property
        Private isproxyipaddress As String
        Public Property is_proxy_ip_address() As String
            Get
                Return isproxyipaddress
            End Get
            Set(value As String)
                isproxyipaddress = value
            End Set
        End Property
        Private isbinfound As String
        Public Property is_bin_found() As String
            Get
                Return isbinfound
            End Get
            Set(value As String)
                isbinfound = value
            End Set
        End Property
        Private isbincountrymatch As String
        Public Property is_bin_country_match() As String
            Get
                Return isbincountrymatch
            End Get
            Set(value As String)
                isbincountrymatch = value
            End Set
        End Property
        Private isbinnamematch As String
        Public Property is_bin_name_match() As String
            Get
                Return isbinnamematch
            End Get
            Set(value As String)
                isbinnamematch = value
            End Set
        End Property
        Private isbinphonematch As String
        Public Property is_bin_phone_match() As String
            Get
                Return isbinphonematch
            End Get
            Set(value As String)
                isbinphonematch = value
            End Set
        End Property
        Private isbinprepaid As String
        Public Property is_bin_prepaid() As String
            Get
                Return isbinprepaid
            End Get
            Set(value As String)
                isbinprepaid = value
            End Set
        End Property
        Private isaddressshipforward As String
        Public Property is_address_ship_forward() As String
            Get
                Return isaddressshipforward
            End Get
            Set(value As String)
                isaddressshipforward = value
            End Set
        End Property
        Private isbillshipcitymatch As String
        Public Property is_bill_ship_city_match() As String
            Get
                Return isbillshipcitymatch
            End Get
            Set(value As String)
                isbillshipcitymatch = value
            End Set
        End Property
        Private isbillshipstatematch As String
        Public Property is_bill_ship_state_match() As String
            Get
                Return isbillshipstatematch
            End Get
            Set(value As String)
                isbillshipstatematch = value
            End Set
        End Property
        Private isbillshipcountrymatch As String
        Public Property is_bill_ship_country_match() As String
            Get
                Return isbillshipcountrymatch
            End Get
            Set(value As String)
                isbillshipcountrymatch = value
            End Set
        End Property
        Private isbillshippostalmatch As String
        Public Property is_bill_ship_postal_match() As String
            Get
                Return isbillshippostalmatch
            End Get
            Set(value As String)
                isbillshippostalmatch = value
            End Set
        End Property
        Private isipblacklist As String
        Public Property is_ip_blacklist() As String
            Get
                Return isipblacklist
            End Get
            Set(value As String)
                isipblacklist = value
            End Set
        End Property
        Private isemailblacklist As String
        Public Property is_email_blacklist() As String
            Get
                Return isemailblacklist
            End Get
            Set(value As String)
                isemailblacklist = value
            End Set
        End Property
        Private iscreditcardblacklist As String
        Public Property is_credit_card_blacklist() As String
            Get
                Return iscreditcardblacklist
            End Get
            Set(value As String)
                iscreditcardblacklist = value
            End Set
        End Property
        Private isdeviceblacklist As String
        Public Property is_device_blacklist() As String
            Get
                Return isdeviceblacklist
            End Get
            Set(value As String)
                isdeviceblacklist = value
            End Set
        End Property
        Private isuserblacklist As String
        Public Property is_user_blacklist() As String
            Get
                Return isuserblacklist
            End Get
            Set(value As String)
                isuserblacklist = value
            End Set
        End Property
        Private isshipaddressblacklist As String
        Public Property is_ship_address_blacklist() As String
            Get
                Return isshipaddressblacklist
            End Get
            Set(value As String)
                isshipaddressblacklist = value
            End Set
        End Property
        Private isphoneblacklist As String
        Public Property is_phone_blacklist() As String
            Get
                Return isphoneblacklist
            End Get
            Set(value As String)
                isphoneblacklist = value
            End Set
        End Property
        Private ishighriskusernamepassword As String
        Public Property is_high_risk_username_password() As String
            Get
                Return ishighriskusernamepassword
            End Get
            Set(value As String)
                ishighriskusernamepassword = value
            End Set
        End Property
        Private ismalwareexploit As String
        Public Property is_malware_exploit() As String
            Get
                Return ismalwareexploit
            End Get
            Set(value As String)
                ismalwareexploit = value
            End Set
        End Property
        Private isexportcontrolledcountry As String
        Public Property is_export_controlled_country() As String

            Get
                Return isexportcontrolledcountry
            End Get
            Set(value As String)
                isexportcontrolledcountry = value
            End Set
        End Property
        Private userorderid As String
        Public Property user_order_id() As String
            Get
                Return userorderid
            End Get
            Set(value As String)
                userorderid = value
            End Set
        End Property
        Private userordermemo As String
        Public Property user_order_memo() As String
            Get
                Return userordermemo
            End Get
            Set(value As String)
                userordermemo = value
            End Set
        End Property
        Private fraudlabsproscore As String
        Public Property fraudlabspro_score() As String
            Get
                Return fraudlabsproscore
            End Get
            Set(value As String)
                fraudlabsproscore = value
            End Set
        End Property
        Private fraudlabsprodistribution As String
        Public Property fraudlabspro_distribution() As String
            Get
                Return fraudlabsprodistribution
            End Get
            Set(value As String)
                fraudlabsprodistribution = value
            End Set
        End Property
        Private fraudlabsprostatus As String
        Public Property fraudlabspro_status() As String
            Get
                Return fraudlabsprostatus
            End Get
            Set(value As String)
                fraudlabsprostatus = value
            End Set
        End Property
        Private fraudlabsproid As String
        Public Property fraudlabspro_id() As String
            Get
                Return fraudlabsproid
            End Get
            Set(value As String)
                fraudlabsproid = value
            End Set
        End Property
        Private fraudlabsproversion As String
        Public Property fraudlabspro_version() As String
            Get
                Return fraudlabsproversion
            End Get
            Set(value As String)
                fraudlabsproversion = value
            End Set
        End Property
        Private fraudlabsproerrorcode As String
        Public Property fraudlabspro_error_code() As String
            Get
                Return fraudlabsproerrorcode
            End Get
            Set(value As String)
                fraudlabsproerrorcode = value
            End Set
        End Property
        Private fraudlabspromessage As String
        Public Property fraudlabspro_message() As String
            Get
                Return fraudlabspromessage
            End Get
            Set(value As String)
                fraudlabspromessage = value
            End Set
        End Property
        Private fraudlabsprocredits As String
        Public Property fraudlabspro_credits() As String
            Get
                Return fraudlabsprocredits
            End Get
            Set(value As String)
                fraudlabsprocredits = value
            End Set
        End Property
    End Class
End Namespace