namespace EdiFabric.Templates.X12006040
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
        // Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public virtual string UnitOrBasisForMeasurementCode_01 { get; set; }
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
        // Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public virtual string UnitOrBasisForMeasurementCode_04 { get; set; }
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
        // Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public virtual string UnitOrBasisForMeasurementCode_07 { get; set; }
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
        // Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public virtual string UnitOrBasisForMeasurementCode_10 { get; set; }
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
        // Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public virtual string UnitOrBasisForMeasurementCode_13 { get; set; }
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
        // Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public virtual string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        // Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public virtual string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        // Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public virtual string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        // Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public virtual string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        // Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public virtual string PaperworkReportActionCode_05 { get; set; }
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
        // Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public virtual string ProductServiceIDQualifier_01 { get; set; }
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
        // Tooth Surface Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(1)]
        public virtual string ToothSurfaceCode_01 { get; set; }
        /// <summary>
        // Tooth Surface Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(2)]
        public virtual string ToothSurfaceCode_02 { get; set; }
        /// <summary>
        // Tooth Surface Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(3)]
        public virtual string ToothSurfaceCode_03 { get; set; }
        /// <summary>
        // Tooth Surface Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(4)]
        public virtual string ToothSurfaceCode_04 { get; set; }
        /// <summary>
        // Tooth Surface Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(5)]
        public virtual string ToothSurfaceCode_05 { get; set; }
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
        // Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public virtual string AmountQualifierCode_01 { get; set; }
        /// <summary>
        // Amount Qualifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(2)]
        public virtual string AmountQualifierCode_02 { get; set; }
        /// <summary>
        // Value Detail Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1638", typeof(X12_ID_1638))]
        [Pos(3)]
        public virtual string ValueDetailCode_03 { get; set; }
        /// <summary>
        // Measurement Significance Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(4)]
        public virtual string MeasurementSignificanceCode_04 { get; set; }
        /// <summary>
        // Unit of Time Period or Interval Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(5)]
        public virtual string UnitOfTimePeriodOrIntervalCode_05 { get; set; }
        /// <summary>
        // Net/Gross Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1637", typeof(X12_ID_1637))]
        [Pos(6)]
        public virtual string NetGrossCode_06 { get; set; }
        /// <summary>
        // Measurement Significance Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public virtual string MeasurementSignificanceCode_07 { get; set; }
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
        // Code List Qualifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(10)]
        public virtual string CodeListQualifierCode_10 { get; set; }
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
        // Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public virtual string CodeListQualifierCode_01 { get; set; }
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
        // Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public virtual string DateTimePeriodFormatQualifier_03 { get; set; }
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
        // Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public virtual string FacilityCodeQualifier_02 { get; set; }
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
        // Related-Causes Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public virtual string RelatedCausesCode_01 { get; set; }
        /// <summary>
        // Related-Causes Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public virtual string RelatedCausesCode_02 { get; set; }
        /// <summary>
        // Related-Causes Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        public virtual string RelatedCausesCode_03 { get; set; }
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
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(1)]
        public virtual string AssuranceTokenParameterCode_01 { get; set; }
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
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(3)]
        public virtual string AssuranceTokenParameterCode_03 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(4)]
        public virtual string AssuranceTokenParameterValue_04 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(5)]
        public virtual string AssuranceTokenParameterCode_05 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(6)]
        public virtual string AssuranceTokenParameterValue_06 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(7)]
        public virtual string AssuranceTokenParameterCode_07 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(8)]
        public virtual string AssuranceTokenParameterValue_08 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(9)]
        public virtual string AssuranceTokenParameterCode_09 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(10)]
        public virtual string AssuranceTokenParameterValue_10 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(11)]
        public virtual string AssuranceTokenParameterCode_11 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(12)]
        public virtual string AssuranceTokenParameterValue_12 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(13)]
        public virtual string AssuranceTokenParameterCode_13 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(14)]
        public virtual string AssuranceTokenParameterValue_14 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(15)]
        public virtual string AssuranceTokenParameterCode_15 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(16)]
        public virtual string AssuranceTokenParameterValue_16 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(17)]
        public virtual string AssuranceTokenParameterCode_17 { get; set; }
        /// <summary>
        // Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(18)]
        public virtual string AssuranceTokenParameterValue_18 { get; set; }
        /// <summary>
        // Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(19)]
        public virtual string AssuranceTokenParameterCode_19 { get; set; }
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
        // Protocol ID Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1564", typeof(X12_ID_1564))]
        [Pos(2)]
        public virtual string ProtocolIDCode_02 { get; set; }
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
        // Encryption Service Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("994", typeof(X12_ID_994))]
        [Pos(1)]
        public virtual string EncryptionServiceCode_01 { get; set; }
        /// <summary>
        // Algorithm ID Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1568", typeof(X12_ID_1568))]
        [Pos(2)]
        public virtual string AlgorithmIDCode_02 { get; set; }
        /// <summary>
        // Algorithm Mode of Operation Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1569", typeof(X12_ID_1569))]
        [Pos(3)]
        public virtual string AlgorithmModeOfOperationCode_03 { get; set; }
        /// <summary>
        // Filter ID Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(4)]
        public virtual string FilterIDCode_04 { get; set; }
        /// <summary>
        // Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(5)]
        public virtual string VersionIdentifier_05 { get; set; }
        /// <summary>
        // Compression ID Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1571", typeof(X12_ID_1571))]
        [Pos(6)]
        public virtual string CompressionIDCode_06 { get; set; }
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
        // Security Value Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1572", typeof(X12_ID_1572))]
        [Pos(1)]
        public virtual string SecurityValueQualifier_01 { get; set; }
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
        // Assurance Algorithm Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1574", typeof(X12_ID_1574))]
        [Pos(1)]
        public virtual string AssuranceAlgorithmCode_01 { get; set; }
        /// <summary>
        // Hashing Algorithm Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1575", typeof(X12_ID_1575))]
        [Pos(2)]
        public virtual string HashingAlgorithmCode_02 { get; set; }
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
        // Provider Specialty Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public virtual string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        // Agency Qualifier Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public virtual string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        // Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public virtual string YesNoConditionOrResponseCode_03 { get; set; }
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
        // Configuration Type Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1395", typeof(X12_ID_1395))]
        [Pos(1)]
        public virtual string ConfigurationTypeCode_01 { get; set; }
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
        // Application Error Condition Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(2)]
        public virtual string ApplicationErrorConditionCode_02 { get; set; }
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
        // Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public virtual string ReferenceIdentificationQualifier_01 { get; set; }
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
        // Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public virtual string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        // Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public virtual string ReferenceIdentification_04 { get; set; }
        /// <summary>
        // Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(5)]
        public virtual string ReferenceIdentificationQualifier_05 { get; set; }
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
        // Condition Indicator Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(1)]
        public virtual string ConditionIndicatorCode_01 { get; set; }
        /// <summary>
        // Condition Indicator Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(2)]
        public virtual string ConditionIndicatorCode_02 { get; set; }
        /// <summary>
        // Condition Indicator Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public virtual string ConditionIndicatorCode_03 { get; set; }
        /// <summary>
        // Condition Indicator Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public virtual string ConditionIndicatorCode_04 { get; set; }
        /// <summary>
        // Condition Indicator Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public virtual string ConditionIndicatorCode_05 { get; set; }
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
        // Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(1)]
        public virtual string RateValueQualifier_01 { get; set; }
        /// <summary>
        // Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(2)]
        public virtual string RateValueQualifier_02 { get; set; }
        /// <summary>
        // Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(3)]
        public virtual string RateValueQualifier_03 { get; set; }
        /// <summary>
        // Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(4)]
        public virtual string RateValueQualifier_04 { get; set; }
        /// <summary>
        // Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(5)]
        public virtual string RateValueQualifier_05 { get; set; }
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
        // Entity Identifier Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(3)]
        public virtual string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        // Code List Qualifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(4)]
        public virtual string CodeListQualifierCode_04 { get; set; }
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
        // Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(1)]
        public virtual string TypeOfRealEstateAssetCode_01 { get; set; }
        /// <summary>
        // Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(2)]
        public virtual string TypeOfRealEstateAssetCode_02 { get; set; }
        /// <summary>
        // Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(3)]
        public virtual string TypeOfRealEstateAssetCode_03 { get; set; }
        /// <summary>
        // Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(4)]
        public virtual string TypeOfRealEstateAssetCode_04 { get; set; }
        /// <summary>
        // Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(5)]
        public virtual string TypeOfRealEstateAssetCode_05 { get; set; }
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
        // Use of Proceeds Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(1)]
        public virtual string UseOfProceedsCode_01 { get; set; }
        /// <summary>
        // Refinance Type Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1680", typeof(X12_ID_1680))]
        [Pos(2)]
        public virtual string RefinanceTypeCode_02 { get; set; }
        /// <summary>
        // Use of Proceeds Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(3)]
        public virtual string UseOfProceedsCode_03 { get; set; }
        /// <summary>
        // Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(4)]
        public virtual string YesNoConditionOrResponseCode_04 { get; set; }
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
        // Look-up Value Protocol Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(1)]
        public virtual string LookupValueProtocolCode_01 { get; set; }
        /// <summary>
        // Filter ID Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(2)]
        public virtual string FilterIDCode_02 { get; set; }
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
        // Look-up Value Protocol Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(5)]
        public virtual string LookupValueProtocolCode_05 { get; set; }
        /// <summary>
        // Filter ID Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(6)]
        public virtual string FilterIDCode_06 { get; set; }
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
        // Look-up Value Protocol Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(9)]
        public virtual string LookupValueProtocolCode_09 { get; set; }
        /// <summary>
        // Filter ID Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(10)]
        public virtual string FilterIDCode_10 { get; set; }
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
        // Medicare Plan Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("1218", typeof(X12_ID_1218))]
        [Pos(1)]
        public virtual string MedicarePlanCode_01 { get; set; }
        /// <summary>
        // Eligibility Reason Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(2)]
        public virtual string EligibilityReasonCode_02 { get; set; }
        /// <summary>
        // Eligibility Reason Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(3)]
        public virtual string EligibilityReasonCode_03 { get; set; }
        /// <summary>
        // Eligibility Reason Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(4)]
        public virtual string EligibilityReasonCode_04 { get; set; }
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
        // Electronic Form Standards Type Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("922", typeof(X12_ID_922))]
        [Pos(1)]
        public virtual string ElectronicFormStandardsTypeCode_01 { get; set; }
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
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(1)]
        public virtual string TaxServiceNonpaymentCode_01 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(2)]
        public virtual string TaxServiceNonpaymentCode_02 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(3)]
        public virtual string TaxServiceNonpaymentCode_03 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(4)]
        public virtual string TaxServiceNonpaymentCode_04 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(5)]
        public virtual string TaxServiceNonpaymentCode_05 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(6)]
        public virtual string TaxServiceNonpaymentCode_06 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(7)]
        public virtual string TaxServiceNonpaymentCode_07 { get; set; }
        /// <summary>
        // Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(8)]
        public virtual string TaxServiceNonpaymentCode_08 { get; set; }
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
        // Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public virtual string RaceOrEthnicityCode_01 { get; set; }
        /// <summary>
        // Code List Qualifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public virtual string CodeListQualifierCode_02 { get; set; }
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
        // Communication Number Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(1)]
        public virtual string CommunicationNumberQualifier_01 { get; set; }
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
        // Code List Qualifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public virtual string CodeListQualifierCode_02 { get; set; }
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
        // Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public virtual string YesNoConditionOrResponseCode_02 { get; set; }
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
        // Health-Related Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1212", typeof(X12_ID_1212))]
        [Pos(1)]
        public virtual string HealthRelatedCode_01 { get; set; }
        /// <summary>
        // Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public virtual string YesNoConditionOrResponseCode_02 { get; set; }
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
        // Account Relationship Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1636", typeof(X12_ID_1636))]
        [Pos(1)]
        public virtual string AccountRelationshipCode_01 { get; set; }
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
