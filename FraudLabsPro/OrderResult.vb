Namespace FraudLabsPro
    Public Class OrderResult
        Friend Sub New(ByVal OrderDeserialize As OrderDeserialize)
            IsCountryMatch = OrderDeserialize.is_country_match
            IsHighRiskCountry = OrderDeserialize.is_high_risk_country
            DistanceInKM = OrderDeserialize.distance_in_km
            DistanceInMile = OrderDeserialize.distance_in_mile
            IPCountry = OrderDeserialize.ip_country
            IPRegion = OrderDeserialize.ip_region
            IPCity = OrderDeserialize.ip_city
            IPContinent = OrderDeserialize.ip_continent
            IPLatitude = OrderDeserialize.ip_latitude
            IPLongtitude = OrderDeserialize.ip_longitude
            IPTimeZone = OrderDeserialize.ip_timezone
            IPElevation = OrderDeserialize.ip_elevation
            IPDomain = OrderDeserialize.ip_domain
            IPMobileMNC = OrderDeserialize.ip_mobile_mnc
            IPMobileMCC = OrderDeserialize.ip_mobile_mcc
            IPMobileBrand = OrderDeserialize.ip_mobile_brand
            IPNetSpeed = OrderDeserialize.ip_netspeed
            IPISPName = OrderDeserialize.ip_isp_name
            IPUsageType = OrderDeserialize.ip_usage_type
            IsFreeEmail = OrderDeserialize.is_free_email
            IsDisposableEmail = OrderDeserialize.is_disposable_email
            IsNewDomainName = OrderDeserialize.is_new_domain_name
            IsDomainExists = OrderDeserialize.is_domain_exists
            IsProxyIPAddress = OrderDeserialize.is_proxy_ip_address
            IsBinFound = OrderDeserialize.is_bin_found
            IsBinCountryMatch = OrderDeserialize.is_bin_country_match
            IsBinNameMatch = OrderDeserialize.is_bin_name_match
            IsBinPhoneMatch = OrderDeserialize.is_bin_phone_match
            IsBinPrepaid = OrderDeserialize.is_bin_prepaid
            IsAddressShipForward = OrderDeserialize.is_address_ship_forward
            IsBillShipCityMatch = OrderDeserialize.is_bill_ship_city_match
            IsBillShipStateMatch = OrderDeserialize.is_bill_ship_state_match
            IsBillShipCountryMatch = OrderDeserialize.is_bill_ship_country_match
            IsBillShipPostalMatch = OrderDeserialize.is_bill_ship_postal_match
            IsIPBlacklist = OrderDeserialize.is_ip_blacklist
            IsEmailBlacklist = OrderDeserialize.is_email_blacklist
            IsCreditCardBlacklist = OrderDeserialize.is_credit_card_blacklist
            IsDeviceBlacklist = OrderDeserialize.is_device_blacklist
            IsUserBlacklist = OrderDeserialize.is_user_blacklist
            IsShipAddressBlackList = OrderDeserialize.is_ship_address_blacklist
            IsPhoneBlacklist = OrderDeserialize.is_phone_blacklist
            IsHighRiskUsernamePassword = OrderDeserialize.is_high_risk_username_password
            IsMalwareExploit = OrderDeserialize.is_malware_exploit
            IsExportControlledCountry = OrderDeserialize.is_export_controlled_country
            UserOrderID = OrderDeserialize.user_order_id
            UserOrderMemo = OrderDeserialize.user_order_memo
            FraudLabsProScore = OrderDeserialize.fraudlabspro_score
            FraudLabsProDistribution = OrderDeserialize.fraudlabspro_distribution
            FraudLabsProStatus = OrderDeserialize.fraudlabspro_status
            FraudLabsProID = OrderDeserialize.fraudlabspro_id
            FraudLabsProVersion = OrderDeserialize.fraudlabspro_version
            FraudLabsProErrorCode = OrderDeserialize.fraudlabspro_error_code
            FraudLabsProMessage = OrderDeserialize.fraudlabspro_message
            FraudLabsProCredit = OrderDeserialize.fraudlabspro_credits
        End Sub
        Private isCountry_Match As String
        Public Property IsCountryMatch() As String
            Get
                Return isCountry_Match
            End Get
            Set(value As String)
                isCountry_Match = value
            End Set
        End Property
        Private is_HighRiskCountry As String
        Public Property IsHighRiskCountry() As String
            Get
                Return is_HighRiskCountry
            End Get
            Set(value As String)
                is_HighRiskCountry = value
            End Set
        End Property
        Private Distance_InKM As String
        Public Property DistanceInKM() As String
            Get
                Return Distance_InKM
            End Get
            Set(value As String)
                Distance_InKM = value
            End Set
        End Property
        Private Distance_InMile As String
        Public Property DistanceInMile() As String
            Get
                Return Distance_InMile
            End Get
            Set(value As String)
                Distance_InMile = value
            End Set
        End Property
        Private IP_Country As String
        Public Property IPCountry() As String
            Get
                Return IP_Country
            End Get
            Set(value As String)
                IP_Country = value
            End Set
        End Property
        Private IP_Region As String
        Public Property IPRegion() As String
            Get
                Return IP_Region
            End Get
            Set(value As String)
                IP_Region = value
            End Set
        End Property
        Private IP_City As String
        Public Property IPCity() As String
            Get
                Return IP_City
            End Get
            Set(value As String)
                IP_City = value
            End Set
        End Property
        Private IP_Continent As String
        Public Property IPContinent() As String
            Get
                Return IP_Continent
            End Get
            Set(value As String)
                IP_Continent = value
            End Set
        End Property
        Private IP_Latitude As String
        Public Property IPLatitude() As String
            Get
                Return IP_Latitude
            End Get
            Set(value As String)
                IP_Latitude = value
            End Set
        End Property
        Private IP_Longtitude As String
        Public Property IPLongtitude() As String
            Get
                Return IP_Longtitude
            End Get
            Set(value As String)
                IP_Longtitude = value
            End Set
        End Property
        Private IP_TimeZone As String
        Public Property IPTimeZone() As String
            Get
                Return IP_TimeZone
            End Get
            Set(value As String)
                IP_TimeZone = value
            End Set
        End Property
        Private IP_Elevation As String
        Public Property IPElevation() As String
            Get
                Return IP_Elevation
            End Get
            Set(value As String)
                IP_Elevation = value
            End Set
        End Property
        Private IP_Domain As String
        Public Property IPDomain() As String
            Get
                Return IP_Domain
            End Get
            Set(value As String)
                IP_Domain = value
            End Set
        End Property
        Private IP_MobileMNC As String
        Public Property IPMobileMNC() As String
            Get
                Return IP_MobileMNC
            End Get
            Set(value As String)
                IP_MobileMNC = value
            End Set
        End Property
        Private IP_MobileMCC As String
        Public Property IPMobileMCC() As String
            Get
                Return IP_MobileMCC
            End Get
            Set(value As String)
                IP_MobileMCC = value
            End Set
        End Property
        Private IP_MobileBrand As String
        Public Property IPMobileBrand() As String
            Get
                Return IP_MobileBrand
            End Get
            Set(value As String)
                IP_MobileBrand = value
            End Set
        End Property
        Private IP_NetSpeed As String
        Public Property IPNetSpeed() As String
            Get
                Return IP_NetSpeed
            End Get
            Set(value As String)
                IP_NetSpeed = value
            End Set
        End Property
        Private IP_ISPName As String
        Public Property IPISPName() As String
            Get
                Return IP_ISPName
            End Get
            Set(value As String)
                IP_ISPName = value
            End Set
        End Property
        Private IP_UsageType As String
        Public Property IPUsageType() As String
            Get
                Return IP_UsageType
            End Get
            Set(value As String)
                IP_UsageType = value
            End Set
        End Property
        Private Is_FreeEmail As String
        Public Property IsFreeEmail() As String
            Get
                Return Is_FreeEmail
            End Get
            Set(value As String)
                Is_FreeEmail = value
            End Set
        End Property
        Private Is_DisposableEmail As String
        Public Property IsDisposableEmail() As String
            Get
                Return Is_DisposableEmail
            End Get
            Set(value As String)
                Is_DisposableEmail = value
            End Set
        End Property
        Private Is_NewDomainName As String
        Public Property IsNewDomainName() As String
            Get
                Return Is_NewDomainName
            End Get
            Set(value As String)
                Is_NewDomainName = value
            End Set
        End Property
        Private Is_DomainExists As String
        Public Property IsDomainExists() As String
            Get
                Return Is_DomainExists
            End Get
            Set(value As String)
                Is_DomainExists = value
            End Set
        End Property
        Private Is_ProxyIPAddress As String
        Public Property IsProxyIPAddress() As String
            Get
                Return Is_ProxyIPAddress
            End Get
            Set(value As String)
                Is_ProxyIPAddress = value
            End Set
        End Property
        Private Is_BinFound As String
        Public Property IsBinFound() As String
            Get
                Return Is_BinFound
            End Get
            Set(value As String)
                Is_BinFound = value
            End Set
        End Property
        Private Is_BinCountryMatch As String
        Public Property IsBinCountryMatch() As String
            Get
                Return Is_BinCountryMatch
            End Get
            Set(value As String)
                Is_BinCountryMatch = value
            End Set
        End Property
        Private Is_BinNameMatch As String
        Public Property IsBinNameMatch() As String
            Get
                Return Is_BinNameMatch
            End Get
            Set(value As String)
                Is_BinNameMatch = value
            End Set
        End Property
        Private Is_BinPhoneMatch As String
        Public Property IsBinPhoneMatch() As String
            Get
                Return Is_BinPhoneMatch
            End Get
            Set(value As String)
                Is_BinPhoneMatch = value
            End Set
        End Property
        Private Is_BinPrepaid As String
        Public Property IsBinPrepaid() As String
            Get
                Return Is_BinPrepaid
            End Get
            Set(value As String)
                Is_BinPrepaid = value
            End Set
        End Property
        Private Is_AddressShipForward As String
        Public Property IsAddressShipForward() As String
            Get
                Return Is_AddressShipForward
            End Get
            Set(value As String)
                Is_AddressShipForward = value
            End Set
        End Property
        Private Is_BillShipCityMatch As String
        Public Property IsBillShipCityMatch() As String
            Get
                Return Is_BillShipCityMatch
            End Get
            Set(value As String)
                Is_BillShipCityMatch = value
            End Set
        End Property
        Private Is_BillShipStateMatch As String
        Public Property IsBillShipStateMatch() As String
            Get
                Return Is_BillShipStateMatch
            End Get
            Set(value As String)
                Is_BillShipStateMatch = value
            End Set
        End Property
        Private Is_BillShipCountryMatch As String
        Public Property IsBillShipCountryMatch() As String
            Get
                Return Is_BillShipCountryMatch
            End Get
            Set(value As String)
                Is_BillShipCountryMatch = value
            End Set
        End Property
        Private Is_BillShipPostalMatch As String
        Public Property IsBillShipPostalMatch() As String
            Get
                Return Is_BillShipPostalMatch
            End Get
            Set(value As String)
                Is_BillShipPostalMatch = value
            End Set
        End Property
        Private Is_IPBlacklist As String
        Public Property IsIPBlacklist() As String
            Get
                Return Is_IPBlacklist
            End Get
            Set(value As String)
                Is_IPBlacklist = value
            End Set
        End Property
        Private Is_EmailBlacklist As String
        Public Property IsEmailBlacklist() As String
            Get
                Return Is_EmailBlacklist
            End Get
            Set(value As String)
                Is_EmailBlacklist = value
            End Set
        End Property
        Private Is_CreditCardBlacklist As String
        Public Property IsCreditCardBlacklist() As String
            Get
                Return Is_CreditCardBlacklist
            End Get
            Set(value As String)
                Is_CreditCardBlacklist = value
            End Set
        End Property
        Private Is_DeviceBlacklist As String
        Public Property IsDeviceBlacklist() As String
            Get
                Return Is_DeviceBlacklist
            End Get
            Set(value As String)
                Is_DeviceBlacklist = value
            End Set
        End Property
        Private Is_UserBlacklist As String
        Public Property IsUserBlacklist() As String
            Get
                Return Is_UserBlacklist
            End Get
            Set(value As String)
                Is_UserBlacklist = value
            End Set
        End Property
        Private Is_ShipAddressBlackList As String
        Public Property IsShipAddressBlackList() As String
            Get
                Return Is_ShipAddressBlackList
            End Get
            Set(value As String)
                Is_ShipAddressBlackList = value
            End Set
        End Property
        Private Is_PhoneBlacklist As String
        Public Property IsPhoneBlacklist() As String
            Get
                Return Is_PhoneBlacklist
            End Get
            Set(value As String)
                Is_PhoneBlacklist = value
            End Set
        End Property
        Private Is_HighRiskUsernamePassword As String
        Public Property IsHighRiskUsernamePassword() As String
            Get
                Return Is_HighRiskUsernamePassword
            End Get
            Set(value As String)
                Is_HighRiskUsernamePassword = value
            End Set
        End Property
        Private Is_MalwareExploit As String
        Public Property IsMalwareExploit() As String
            Get
                Return Is_MalwareExploit
            End Get
            Set(value As String)
                Is_MalwareExploit = value
            End Set
        End Property
        Private Is_ExportControlledCountry As String
        Public Property IsExportControlledCountry() As String
            Get
                Return Is_ExportControlledCountry
            End Get
            Set(value As String)
                Is_ExportControlledCountry = value
            End Set
        End Property
        Private User_OrderID As String
        Public Property UserOrderID() As String
            Get
                Return User_OrderID
            End Get
            Set(value As String)
                User_OrderID = value
            End Set
        End Property
        Private User_OrderMemo As String
        Public Property UserOrderMemo() As String
            Get
                Return User_OrderMemo
            End Get
            Set(value As String)
                User_OrderMemo = value
            End Set
        End Property
        Private FraudLabsPro_Score As String
        Public Property FraudLabsProScore() As String
            Get
                Return FraudLabsPro_Score
            End Get
            Set(value As String)
                FraudLabsPro_Score = value
            End Set
        End Property
        Private FraudLabsPro_Distribution As String
        Public Property FraudLabsProDistribution() As String
            Get
                Return FraudLabsPro_Distribution
            End Get
            Set(value As String)
                FraudLabsPro_Distribution = value
            End Set
        End Property
        Private FraudLabsPro_Status As String
        Public Property FraudLabsProStatus() As String
            Get
                Return FraudLabsPro_Status
            End Get
            Set(value As String)
                FraudLabsPro_Status = value
            End Set
        End Property
        Private FraudLabsPro_ID As String
        Public Property FraudLabsProID() As String
            Get
                Return FraudLabsPro_ID
            End Get
            Set(value As String)
                FraudLabsPro_ID = value
            End Set
        End Property
        Private FraudLabsPro_Version As String
        Public Property FraudLabsProVersion() As String
            Get
                Return FraudLabsPro_Version
            End Get
            Set(value As String)
                FraudLabsPro_Version = value
            End Set
        End Property
        Private FraudLabsPro_ErrorCode As String
        Public Property FraudLabsProErrorCode() As String
            Get
                Return FraudLabsPro_ErrorCode
            End Get
            Set(value As String)
                FraudLabsPro_ErrorCode = value
            End Set
        End Property
        Private FraudLabsPro_Message As String
        Public Property FraudLabsProMessage() As String
            Get
                Return FraudLabsPro_Message
            End Get
            Set(value As String)
                FraudLabsPro_Message = value
            End Set
        End Property
        Private FraudLabsPro_Credit As String
        Public Property FraudLabsProCredit() As String
            Get
                Return FraudLabsPro_Credit
            End Get
            Set(value As String)
                FraudLabsPro_Credit = value
            End Set
        End Property
    End Class
End Namespace