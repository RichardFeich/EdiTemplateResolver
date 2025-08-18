namespace EdiFabric.Templates.X12006050
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi.X12;


    /// <summary>
    // Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Actual Pounds
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public virtual string ActualPounds_01 { get; set; }
        /// <summary>
        // Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public virtual string Exponent_02 { get; set; }
        /// <summary>
        // Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public virtual string Multiplier_03 { get; set; }
        /// <summary>
        // Actual Pounds
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public virtual string ActualPounds_04 { get; set; }
        /// <summary>
        // Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public virtual string Exponent_05 { get; set; }
        /// <summary>
        // Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public virtual string Multiplier_06 { get; set; }
        /// <summary>
        // Actual Pounds
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public virtual string ActualPounds_07 { get; set; }
        /// <summary>
        // Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public virtual string Exponent_08 { get; set; }
        /// <summary>
        // Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public virtual string Multiplier_09 { get; set; }
        /// <summary>
        // Actual Pounds
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public virtual string ActualPounds_10 { get; set; }
        /// <summary>
        // Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public virtual string Exponent_11 { get; set; }
        /// <summary>
        // Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public virtual string Multiplier_12 { get; set; }
        /// <summary>
        // Actual Pounds
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public virtual string ActualPounds_13 { get; set; }
        /// <summary>
        // Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public virtual string Exponent_14 { get; set; }
        /// <summary>
        // Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public virtual string Multiplier_15 { get; set; }
    }

    /// <summary>
    // Actions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Used to Initiate This Report
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public virtual string UsedToInitiateThisReport_01 { get; set; }
        /// <summary>
        // Used to Initiate This Report
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public virtual string UsedToInitiateThisReport_02 { get; set; }
        /// <summary>
        // Used to Initiate This Report
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public virtual string UsedToInitiateThisReport_03 { get; set; }
        /// <summary>
        // Used to Initiate This Report
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public virtual string UsedToInitiateThisReport_04 { get; set; }
        /// <summary>
        // Used to Initiate This Report
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public virtual string UsedToInitiateThisReport_05 { get; set; }
    }

    /// <summary>
    // Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Credit Card
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public virtual string CreditCard_01 { get; set; }
        /// <summary>
        // Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ProductServiceID_02 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public virtual string ProcedureModifier_03 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public virtual string ProcedureModifier_04 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public virtual string ProcedureModifier_05 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public virtual string ProcedureModifier_06 { get; set; }
        /// <summary>
        // Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public virtual string Description_07 { get; set; }
        /// <summary>
        // Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public virtual string ProductServiceID_08 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(9)]
        public virtual string ProcedureModifier_09 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(10)]
        public virtual string ProcedureModifier_10 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(11)]
        public virtual string ProcedureModifier_11 { get; set; }
        /// <summary>
        // Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(12)]
        public virtual string ProcedureModifier_12 { get; set; }
    }

    /// <summary>
    // Composite Diagnosis Code Pointer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C004")]
    public class C004
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public virtual string DiagnosisCodePointer_01 { get; set; }
        /// <summary>
        // Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public virtual string DiagnosisCodePointer_02 { get; set; }
        /// <summary>
        // Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public virtual string DiagnosisCodePointer_03 { get; set; }
        /// <summary>
        // Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public virtual string DiagnosisCodePointer_04 { get; set; }
    }

    /// <summary>
    // Tooth Surface
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C005")]
    public class C005
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Buccal
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(1)]
        public virtual string Buccal_01 { get; set; }
        /// <summary>
        // Buccal
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(2)]
        public virtual string Buccal_02 { get; set; }
        /// <summary>
        // Buccal
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(3)]
        public virtual string Buccal_03 { get; set; }
        /// <summary>
        // Buccal
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(4)]
        public virtual string Buccal_04 { get; set; }
        /// <summary>
        // Buccal
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(5)]
        public virtual string Buccal_05 { get; set; }
    }

    /// <summary>
    // Oral Cavity Designation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C006")]
    public class C006
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(1)]
        public virtual string OralCavityDesignationCode_01 { get; set; }
        /// <summary>
        // Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(2)]
        public virtual string OralCavityDesignationCode_02 { get; set; }
        /// <summary>
        // Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(3)]
        public virtual string OralCavityDesignationCode_03 { get; set; }
        /// <summary>
        // Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(4)]
        public virtual string OralCavityDesignationCode_04 { get; set; }
        /// <summary>
        // Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(5)]
        public virtual string OralCavityDesignationCode_05 { get; set; }
    }

    /// <summary>
    // Amount Qualifying Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C007")]
    public class C007
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Downpayment on the Repayment Plan Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public virtual string DownpaymentOnTheRepaymentPlanAmount_01 { get; set; }
        /// <summary>
        // Downpayment on the Repayment Plan Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(2)]
        public virtual string DownpaymentOnTheRepaymentPlanAmount_02 { get; set; }
        /// <summary>
        // Additional
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1638", typeof(X12_ID_1638))]
        [Pos(3)]
        public virtual string Additional_03 { get; set; }
        /// <summary>
        // Where Air = 1
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(4)]
        public virtual string WhereAir_04 { get; set; }
        /// <summary>
        // More Than One Year
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(5)]
        public virtual string MoreThanOneYear_05 { get; set; }
        /// <summary>
        // Gross
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1637", typeof(X12_ID_1637))]
        [Pos(6)]
        public virtual string Gross_06 { get; set; }
        /// <summary>
        // Where Air = 1
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public virtual string WhereAir_07 { get; set; }
        /// <summary>
        // Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(8)]
        public virtual string Description_08 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(9)]
        public virtual string IndustryCode_09 { get; set; }
        /// <summary>
        // Document Identification Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(10)]
        public virtual string DocumentIdentificationCode_10 { get; set; }
    }

    /// <summary>
    // Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Document Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public virtual string DocumentIdentificationCode_01 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public virtual string IndustryCode_02 { get; set; }
        /// <summary>
        // First Two Digits of Year Expressed in Format CCYY
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public virtual string FirstTwoDigitsOfYearExpressedInFormatCCYY_03 { get; set; }
        /// <summary>
        // Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public virtual string DateTimePeriod_04 { get; set; }
        /// <summary>
        // Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public virtual string MonetaryAmount_05 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public virtual string Quantity_06 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public virtual string VersionIdentifier_07 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public virtual string IndustryCode_08 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(9)]
        public virtual string IndustryCode_09 { get; set; }
    }

    /// <summary>
    // Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Facility Code Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public virtual string FacilityCodeValue_01 { get; set; }
        /// <summary>
        // Uniform Billing Claim Form Bill Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public virtual string UniformBillingClaimFormBillType_02 { get; set; }
        /// <summary>
        // Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_AN))]
        [Pos(3)]
        public virtual string ClaimFrequencyTypeCode_03 { get; set; }
    }

    /// <summary>
    // Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Auto Accident
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public virtual string AutoAccident_01 { get; set; }
        /// <summary>
        // Auto Accident
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public virtual string AutoAccident_02 { get; set; }
        /// <summary>
        // Auto Accident
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        public virtual string AutoAccident_03 { get; set; }
        /// <summary>
        // State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        public virtual string StateOrProvinceCode_04 { get; set; }
        /// <summary>
        // Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        public virtual string CountryCode_05 { get; set; }
    }

    /// <summary>
    // Assurance Token Parameters
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C028")]
    public class C028
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(1)]
        public virtual string CertificationAuthorityID_01 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(2)]
        public virtual string AssuranceTokenParameterValue_02 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(3)]
        public virtual string CertificationAuthorityID_03 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(4)]
        public virtual string AssuranceTokenParameterValue_04 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(5)]
        public virtual string CertificationAuthorityID_05 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(6)]
        public virtual string AssuranceTokenParameterValue_06 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(7)]
        public virtual string CertificationAuthorityID_07 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(8)]
        public virtual string AssuranceTokenParameterValue_08 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(9)]
        public virtual string CertificationAuthorityID_09 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(10)]
        public virtual string AssuranceTokenParameterValue_10 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(11)]
        public virtual string CertificationAuthorityID_11 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(12)]
        public virtual string AssuranceTokenParameterValue_12 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(13)]
        public virtual string CertificationAuthorityID_13 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(14)]
        public virtual string AssuranceTokenParameterValue_14 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(15)]
        public virtual string CertificationAuthorityID_15 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(16)]
        public virtual string AssuranceTokenParameterValue_16 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(17)]
        public virtual string CertificationAuthorityID_17 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(18)]
        public virtual string AssuranceTokenParameterValue_18 { get; set; }
        /// <summary>
        // Certification Authority ID
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(19)]
        public virtual string CertificationAuthorityID_19 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(20)]
        public virtual string AssuranceTokenParameterValue_20 { get; set; }
    }

    /// <summary>
    // Position in Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C030")]
    public class C030
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Element Position in Segment
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("722", typeof(X12_N0))]
        [Pos(1)]
        public virtual string ElementPositionInSegment_01 { get; set; }
        /// <summary>
        // Component Data Element Position in Composite
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1528", typeof(X12_N0))]
        [Pos(2)]
        public virtual string ComponentDataElementPositionInComposite_02 { get; set; }
        /// <summary>
        // Repeating Data Element Position
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("1686", typeof(X12_N0))]
        [Pos(3)]
        public virtual string RepeatingDataElementPosition_03 { get; set; }
    }

    /// <summary>
    // Encryption Key Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C031")]
    public class C031
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Encryption Key Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 64)]
        [DataElement("993", typeof(X12_AN))]
        [Pos(1)]
        public virtual string EncryptionKeyName_01 { get; set; }
        /// <summary>
        // Triple Data Encryption Algorithm
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1564", typeof(X12_ID_1564))]
        [Pos(2)]
        public virtual string TripleDataEncryptionAlgorithm_02 { get; set; }
        /// <summary>
        // Keying Material
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("1566", typeof(X12_AN))]
        [Pos(3)]
        public virtual string KeyingMaterial_03 { get; set; }
        /// <summary>
        // One-time Encryption Key
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("1567", typeof(X12_AN))]
        [Pos(4)]
        public virtual string OnetimeEncryptionKey_04 { get; set; }
    }

    /// <summary>
    // Encryption Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C032")]
    public class C032
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // ANSI X9.23 Cipher Block Chaining (CBC)
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("994", typeof(X12_ID_994))]
        [Pos(1)]
        public virtual string ANSIXCipherBlockChaining_01 { get; set; }
        /// <summary>
        // Advanced Encryption Standard (AES) with a 128-bit Key
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1568", typeof(X12_ID_1568))]
        [Pos(2)]
        public virtual string AdvancedEncryptionStandard_02 { get; set; }
        /// <summary>
        // Cipher Block Chaining
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1569", typeof(X12_ID_1569))]
        [Pos(3)]
        public virtual string CipherBlockChaining_03 { get; set; }
        /// <summary>
        // ASCII-Baudot Filter
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(4)]
        public virtual string ASCIIBaudotFilter_04 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(5)]
        public virtual string VersionIdentifier_05 { get; set; }
        /// <summary>
        // Deflate Compressed Data Format with LZ77 (Lempel-Ziv 1977) and Huffman Coding
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1571", typeof(X12_ID_1571))]
        [Pos(6)]
        public virtual string DeflateCompressedDataFormatWithLZ_06 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public virtual string VersionIdentifier_07 { get; set; }
        /// <summary>
        // Length of Initialization Vector
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1704", typeof(X12_N))]
        [Pos(8)]
        public virtual string LengthOfInitializationVector_08 { get; set; }
    }

    /// <summary>
    // Security Token Value
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C033")]
    public class C033
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Assurance Token
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1572", typeof(X12_ID_1572))]
        [Pos(1)]
        public virtual string AssuranceToken_01 { get; set; }
        /// <summary>
        // Encoded Security Value
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1573", typeof(X12_AN))]
        [Pos(2)]
        public virtual string EncodedSecurityValue_02 { get; set; }
    }

    /// <summary>
    // Computation Methods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C034")]
    public class C034
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Digital Signature Standard
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1574", typeof(X12_ID_1574))]
        [Pos(1)]
        public virtual string DigitalSignatureStandard_01 { get; set; }
        /// <summary>
        // MD2
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1575", typeof(X12_ID_1575))]
        [Pos(2)]
        public virtual string MD_02 { get; set; }
    }

    /// <summary>
    // Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C035")]
    public class C035
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Denturist
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public virtual string Denturist_01 { get; set; }
        /// <summary>
        // Alabama
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public virtual string Alabama_02 { get; set; }
        /// <summary>
        // No
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public virtual string No_03 { get; set; }
    }

    /// <summary>
    // Index Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C036")]
    public class C036
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Horizontal
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1395", typeof(X12_ID_1395))]
        [Pos(1)]
        public virtual string Horizontal_01 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ReferenceIdentification_02 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public virtual string ReferenceIdentification_03 { get; set; }
        /// <summary>
        // X-Peg
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("863", typeof(X12_R))]
        [Pos(4)]
        public virtual string XPeg_04 { get; set; }
        /// <summary>
        // Y-Peg
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("864", typeof(X12_R))]
        [Pos(5)]
        public virtual string YPeg_05 { get; set; }
    }

    /// <summary>
    // Tax Field Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C037")]
    public class C037
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Tax Information Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("817", typeof(X12_AN))]
        [Pos(1)]
        public virtual string TaxInformationIdentificationNumber_01 { get; set; }
        /// <summary>
        // Car Not in Umler
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(2)]
        public virtual string CarNotInUmler_02 { get; set; }
    }

    /// <summary>
    // Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Contracting District Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public virtual string ContractingDistrictNumber_01 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ReferenceIdentification_02 { get; set; }
        /// <summary>
        // Contracting District Number
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public virtual string ContractingDistrictNumber_03 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public virtual string ReferenceIdentification_04 { get; set; }
        /// <summary>
        // Contracting District Number
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(5)]
        public virtual string ContractingDistrictNumber_05 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public virtual string ReferenceIdentification_06 { get; set; }
    }

    /// <summary>
    // Adjustment Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(1)]
        public virtual string IndustryCode_01 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ReferenceIdentification_02 { get; set; }
    }

    /// <summary>
    // Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(1)]
        public virtual string IndustryCode_01 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public virtual string IndustryCode_02 { get; set; }
        /// <summary>
        // Alternate Insurer
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(3)]
        public virtual string AlternateInsurer_03 { get; set; }
        /// <summary>
        // Document Identification Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(4)]
        public virtual string DocumentIdentificationCode_04 { get; set; }
    }

    /// <summary>
    // Conditions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C045")]
    public class C045
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Requested
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(1)]
        public virtual string Requested_01 { get; set; }
        /// <summary>
        // Requested
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(2)]
        public virtual string Requested_02 { get; set; }
        /// <summary>
        // Requested
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public virtual string Requested_03 { get; set; }
        /// <summary>
        // Requested
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public virtual string Requested_04 { get; set; }
        /// <summary>
        // Requested
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public virtual string Requested_05 { get; set; }
    }

    /// <summary>
    // Composite Qualifier Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C046")]
    public class C046
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Percent Of Amount Advanced
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(1)]
        public virtual string PercentOfAmountAdvanced_01 { get; set; }
        /// <summary>
        // Percent Of Amount Advanced
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(2)]
        public virtual string PercentOfAmountAdvanced_02 { get; set; }
        /// <summary>
        // Percent Of Amount Advanced
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(3)]
        public virtual string PercentOfAmountAdvanced_03 { get; set; }
        /// <summary>
        // Percent Of Amount Advanced
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(4)]
        public virtual string PercentOfAmountAdvanced_04 { get; set; }
        /// <summary>
        // Percent Of Amount Advanced
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(5)]
        public virtual string PercentOfAmountAdvanced_05 { get; set; }
    }

    /// <summary>
    // Composite Type of Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C047")]
    public class C047
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Manufactured
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(1)]
        public virtual string Manufactured_01 { get; set; }
        /// <summary>
        // Manufactured
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(2)]
        public virtual string Manufactured_02 { get; set; }
        /// <summary>
        // Manufactured
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(3)]
        public virtual string Manufactured_03 { get; set; }
        /// <summary>
        // Manufactured
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(4)]
        public virtual string Manufactured_04 { get; set; }
        /// <summary>
        // Manufactured
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(5)]
        public virtual string Manufactured_05 { get; set; }
    }

    /// <summary>
    // Composite Use of Proceeds
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C048")]
    public class C048
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Cash
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(1)]
        public virtual string Cash_01 { get; set; }
        /// <summary>
        // Cash Out
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1680", typeof(X12_ID_1680))]
        [Pos(2)]
        public virtual string CashOut_02 { get; set; }
        /// <summary>
        // Cash
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(3)]
        public virtual string Cash_03 { get; set; }
        /// <summary>
        // No
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(4)]
        public virtual string No_04 { get; set; }
    }

    /// <summary>
    // Certificate Look-up Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C050")]
    public class C050
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // X509 Issuer Distinguished Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(1)]
        public virtual string XIssuerDistinguishedName_01 { get; set; }
        /// <summary>
        // ASCII-Baudot Filter
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(2)]
        public virtual string ASCIIBaudotFilter_02 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(3)]
        public virtual string VersionIdentifier_03 { get; set; }
        /// <summary>
        // Look-up Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(4)]
        public virtual string LookupValue_04 { get; set; }
        /// <summary>
        // X509 Issuer Distinguished Name
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(5)]
        public virtual string XIssuerDistinguishedName_05 { get; set; }
        /// <summary>
        // ASCII-Baudot Filter
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(6)]
        public virtual string ASCIIBaudotFilter_06 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public virtual string VersionIdentifier_07 { get; set; }
        /// <summary>
        // Look-up Value
        /// </summary>
        [DataMember]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(8)]
        public virtual string LookupValue_08 { get; set; }
        /// <summary>
        // X509 Issuer Distinguished Name
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(9)]
        public virtual string XIssuerDistinguishedName_09 { get; set; }
        /// <summary>
        // ASCII-Baudot Filter
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(10)]
        public virtual string ASCIIBaudotFilter_10 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(11)]
        public virtual string VersionIdentifier_11 { get; set; }
        /// <summary>
        // Look-up Value
        /// </summary>
        [DataMember]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(12)]
        public virtual string LookupValue_12 { get; set; }
    }

    /// <summary>
    // Medicare Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C052")]
    public class C052
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Medicare Part A
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("1218", typeof(X12_ID_1218))]
        [Pos(1)]
        public virtual string MedicarePartA_01 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(2)]
        public virtual string Age_02 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(3)]
        public virtual string Age_03 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(4)]
        public virtual string Age_04 { get; set; }
    }

    /// <summary>
    // Standards Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C053")]
    public class C053
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Health Level 7 (HL7)
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("922", typeof(X12_ID_922))]
        [Pos(1)]
        public virtual string HealthLevel_01 { get; set; }
        /// <summary>
        // Electronic Form Standards Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("1707", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ElectronicFormStandardsIdentifier_02 { get; set; }
        /// <summary>
        // Implementation Convention Reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("1705", typeof(X12_AN))]
        [Pos(3)]
        public virtual string ImplementationConventionReference_03 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(4)]
        public virtual string VersionIdentifier_04 { get; set; }
        /// <summary>
        // Revision Value
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("796", typeof(X12_AN))]
        [Pos(5)]
        public virtual string RevisionValue_05 { get; set; }
    }

    /// <summary>
    // Tax Service Non-payment Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C055")]
    public class C055
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(1)]
        public virtual string CannotIdentifyLoan_01 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(2)]
        public virtual string CannotIdentifyLoan_02 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(3)]
        public virtual string CannotIdentifyLoan_03 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(4)]
        public virtual string CannotIdentifyLoan_04 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(5)]
        public virtual string CannotIdentifyLoan_05 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(6)]
        public virtual string CannotIdentifyLoan_06 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(7)]
        public virtual string CannotIdentifyLoan_07 { get; set; }
        /// <summary>
        // Cannot Identify Loan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(8)]
        public virtual string CannotIdentifyLoan_08 { get; set; }
    }

    /// <summary>
    // Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Not Provided
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public virtual string NotProvided_01 { get; set; }
        /// <summary>
        // Document Identification Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public virtual string DocumentIdentificationCode_02 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public virtual string IndustryCode_03 { get; set; }
    }

    /// <summary>
    // Communication Number Component
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C057")]
    public class C057
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // International Telephone Access Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(1)]
        public virtual string InternationalTelephoneAccessCode_01 { get; set; }
        /// <summary>
        // Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(2)]
        public virtual string CommunicationNumber_02 { get; set; }
    }

    /// <summary>
    // Adjustment Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(1)]
        public virtual string ClaimAdjustmentReasonCode_01 { get; set; }
        /// <summary>
        // Document Identification Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public virtual string DocumentIdentificationCode_02 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public virtual string IndustryCode_03 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(4)]
        public virtual string IndustryCode_04 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(5)]
        public virtual string IndustryCode_05 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(6)]
        public virtual string IndustryCode_06 { get; set; }
        /// <summary>
        // Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(7)]
        public virtual string IndustryCode_07 { get; set; }
    }

    /// <summary>
    // Drug Use Review (DUR)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Reason for Service Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1738", typeof(X12_AN))]
        [Pos(1)]
        public virtual string ReasonForServiceCode_01 { get; set; }
        /// <summary>
        // Professional Service Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1739", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ProfessionalServiceCode_02 { get; set; }
        /// <summary>
        // Result of Service Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1740", typeof(X12_AN))]
        [Pos(3)]
        public virtual string ResultOfServiceCode_03 { get; set; }
    }

    /// <summary>
    // Question and Answer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C060")]
    public class C060
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Assigned Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public virtual string AssignedIdentification_01 { get; set; }
        /// <summary>
        // No
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public virtual string No_02 { get; set; }
    }

    /// <summary>
    // Member Health and Treatment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C061")]
    public class C061
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Obesity
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1212", typeof(X12_ID_1212))]
        [Pos(1)]
        public virtual string Obesity_01 { get; set; }
        /// <summary>
        // No
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public virtual string No_02 { get; set; }
    }

    /// <summary>
    // Tax Advantage Account Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C062")]
    public class C062
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Checking Account
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1636", typeof(X12_ID_1636))]
        [Pos(1)]
        public virtual string CheckingAccount_01 { get; set; }
        /// <summary>
        // Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(2)]
        public virtual string AccountNumber_02 { get; set; }
    }

    /// <summary>
    // Change Quantities
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C063")]
    public class C063
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public virtual string Quantity_03 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public virtual string Quantity_04 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(5)]
        public virtual string Quantity_05 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public virtual string Quantity_06 { get; set; }
    }

    /// <summary>
    // Context Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C998")]
    public class C998
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Context Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9999", typeof(X12_AN))]
        [Pos(1)]
        public virtual string ContextName_01 { get; set; }
        /// <summary>
        // Context Reference
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9998", typeof(X12_AN))]
        [Pos(2)]
        public virtual string ContextReference_02 { get; set; }
    }

    /// <summary>
    // Reference in Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C999")]
    public class C999
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Data Element Reference Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_AN))]
        [Pos(1)]
        public virtual string DataElementReferenceCode_01 { get; set; }
        /// <summary>
        // Data Element Reference Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_AN))]
        [Pos(2)]
        public virtual string DataElementReferenceCode_02 { get; set; }
    }
}
