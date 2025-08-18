namespace EdiFabric.Templates.X12003060
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001 : I_C001
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003 : I_C003
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 40)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    /// <summary>
    /// Composite Diagnosis Code Pointer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C004")]
    public class C004 : I_C004
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    /// <summary>
    /// Tooth Surface
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C005")]
    public class C005 : I_C005
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(1)]
        public string ToothSurfaceCode_01 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(2)]
        public string ToothSurfaceCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(3)]
        public string ToothSurfaceCode_03 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(4)]
        public string ToothSurfaceCode_04 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(5)]
        public string ToothSurfaceCode_05 { get; set; }
    }
    
    /// <summary>
    /// Oral Cavity Designation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C006")]
    public class C006 : I_C006
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(1)]
        public string OralCavityDesignationCode_01 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(2)]
        public string OralCavityDesignationCode_02 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(3)]
        public string OralCavityDesignationCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(4)]
        public string OralCavityDesignationCode_04 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(5)]
        public string OralCavityDesignationCode_05 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022 : I_C022
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023 : I_C023
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public string FacilityCodeValue_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_AN))]
        [Pos(3)]
        public string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024 : I_C024
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Position in Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C030")]
    public class C030 : I_C030
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Element Position in Segment
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("722", typeof(X12_N0))]
        [Pos(1)]
        public string ElementPositioninSegment_01 { get; set; }
        /// <summary>
        /// Component Data Element Position in Composite
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1528", typeof(X12_N0))]
        [Pos(2)]
        public string ComponentDataElementPositioninComposite_02 { get; set; }
    }
    
    /// <summary>
    /// Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C035")]
    public class C035 : I_C035
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Provider Specialty Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1222", typeof(X12_AN))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    /// <summary>
    /// Index Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C036")]
    public class C036 : I_C036
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Configuration Type Code
        /// </summary>
        [DataMember]
        [DataElement("1395", typeof(X12_ID_1395))]
        [Pos(1)]
        public string ConfigurationTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Paired(3)]
        [RequiredAny(4)]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        /// <summary>
        /// X-Peg
        /// </summary>
        [DataMember]
        [Paired(5)]
        [StringLength(1, 6)]
        [DataElement("863", typeof(X12_R))]
        [Pos(4)]
        public string XPeg_04 { get; set; }
        /// <summary>
        /// Y-Peg
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("864", typeof(X12_R))]
        [Pos(5)]
        public string YPeg_05 { get; set; }
    }
    
    /// <summary>
    /// Tax Field Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C037")]
    public class C037 : I_C037
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Information Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("817", typeof(X12_AN))]
        [Pos(1)]
        public string TaxInformationIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Application Error Condition Code
        /// </summary>
        [DataMember]
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(2)]
        public string ApplicationErrorConditionCode_02 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040 : I_C040
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
}
