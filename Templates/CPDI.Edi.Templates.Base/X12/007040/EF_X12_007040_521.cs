namespace EdiFabric.Templates.X12007040
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
    [Group(typeof(CDS))]
    public class Loop_CDS_521
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Case Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CDS CDS { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Period Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_N1_521_2> LoopN1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_521
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
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
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_521_2
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_521
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
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
        /// <summary>
        // Adjustment Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<AD1> AD1 { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<MSG> MSG { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_PAM_521> LoopPAM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_CDS_521> LoopCDS { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAM))]
    public class Loop_PAM_521
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Period Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAM PAM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    // Income or Asset Offset
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "521")]
    public class TS521 : EdiMessage
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
        // Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        // Beginning Segment for Payment Order/Remittance Advice
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual BPR BPR { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Adjustment Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<AD1> AD1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_N1_521> LoopN1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_NM1_521> LoopNM1 { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
