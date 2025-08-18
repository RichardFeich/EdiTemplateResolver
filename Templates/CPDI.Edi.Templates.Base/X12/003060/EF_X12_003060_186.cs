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
    /// Loop for Account Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ACT))]
    public class Loop_ACT_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ACT ACT { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_LIN_186> LINLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(10)]
        public virtual List<K3> K3 { get; set; }
        /// <summary>
        /// Loop for Specimen Kit Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual List<Loop_SPK_186> SPKLoop { get; set; }
        /// <summary>
        /// Loop for Laboratory Test Results
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LTR_186> LTRLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Laboratory Test Results
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LTR))]
    public class Loop_LTR_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Laboratory Test Results
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LTR LTR { get; set; }
        /// <summary>
        /// Multi-Valued Characteristics
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<CD2> CD2 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<K3> K3 { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_186_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Specimen Kit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPK))]
    public class Loop_SPK_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Specimen Kit Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPK SPK { get; set; }
        /// <summary>
        /// Multi-Valued Characteristics
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<CD2> CD2 { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<K3> K3 { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_NM1_186_2> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Laboratory Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "186")]
    public class TS186 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Laboratory Test Results
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<LTR> LTR { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<Loop_NM1_186> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_ACT_186> ACTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
