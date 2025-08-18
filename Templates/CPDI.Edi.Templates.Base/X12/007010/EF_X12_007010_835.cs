namespace EdiFabric.Templates.X12007010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_1000_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Remittance Delivery Method
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual RDM RDM { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTM DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_2000_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        // Transaction Statistics
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TS3 TS3 { get; set; }
        /// <summary>
        // Transaction Supplemental Statistics
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TS2 TS2 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_2100_835> Loop2100 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLP))]
    public class Loop_2100_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Claim Level Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CLP CLP { get; set; }
        /// <summary>
        // Claims Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<CAS> CAS { get; set; }
        /// <summary>
        // Reason Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<RAS> RAS { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        // Inpatient Adjudication
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MIA MIA { get; set; }
        /// <summary>
        // Outpatient Adjudication
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(11)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // File Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual K3 K3 { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(13)]
        public virtual List<Loop_2110_835> Loop2110 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC))]
    public class Loop_2110_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Service Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SVC SVC { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Claims Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<CAS> CAS { get; set; }
        /// <summary>
        // Reason Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<RAS> RAS { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        // Tooth Identification
        /// </summary>
        [DataMember]
        [ListCount(32)]
        [Pos(9)]
        public virtual List<TOO> TOO { get; set; }
        /// <summary>
        // File Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual K3 K3 { get; set; }
    }
    
    /// <summary>
    // Health Care Claim Payment/Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "835")]
    public class TS835 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        // Beginning Segment for Payment Order/Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPR BPR { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(200)]
        [Pos(8)]
        public virtual List<Loop_1000_835> Loop1000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_2000_835> Loop2000 { get; set; }
        /// <summary>
        // Provider Level Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<PLB> PLB { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
