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
    [Group(typeof(AMT))]
    public class Loop_AMT_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MSG MSG { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ATV))]
    public class Loop_ATV_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Student Activities and Awards
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ATV ATV { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(COM))]
    public class Loop_COM_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual COM COM { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRS))]
    public class Loop_CRS_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Course Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRS CRS { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NTE NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Degree Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DEG DEG { get; set; }
        /// <summary>
        // Academic Summary
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SUM SUM { get; set; }
        /// <summary>
        // Field of Study
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMS))]
    public class Loop_EMS_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Employment Position
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AMT AMT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        // Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        // Additional Individual Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual IND IND { get; set; }
        /// <summary>
        // Immunization Status
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<IMM> IMM { get; set; }
        /// <summary>
        // Health Condition
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<HC> HC { get; set; }
        /// <summary>
        // Language Use
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        // Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<III> III { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual NTE NTE { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<Loop_N3_189> LoopN3 { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_COM_189> LoopCOM { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<Loop_N1_189_2> LoopN1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        // Payment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PDL PDL { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<Loop_AMT_189> LoopAMT { get; set; }
        /// <summary>
        // Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LT))]
    public class Loop_LT_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Letter of Recommendation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LT LT { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Letter of Recommendation Evaluation
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(8)]
        public virtual List<LTE> LTE { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_189
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
        // Message Text
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_189
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_189_2
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
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_EMS_189> LoopEMS { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCL))]
    public class Loop_PCL_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Previous College
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCL PCL { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual COM COM { get; set; }
        /// <summary>
        // Entry and Exit Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        // Academic Summary
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SUM SUM { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MSG MSG { get; set; }
        [DataMember]
        [ListCount(1000)]
        [Pos(8)]
        public virtual List<Loop_SES_189> LoopSES { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RQS))]
    public class Loop_RQS_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Request for Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RQS RQS { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RSD))]
    public class Loop_RSD_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Residency Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RSD RSD { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBT))]
    public class Loop_SBT_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Subtest
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SBT SBT { get; set; }
        /// <summary>
        // Test Scores
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<SRE> SRE { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SES))]
    public class Loop_SES_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Academic Session Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SES SES { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(2)]
        public virtual List<Loop_CRS_189> LoopCRS { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_DEG_189> LoopDEG { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SES))]
    public class Loop_SES_189_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Academic Session Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SES SES { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(2)]
        public virtual List<Loop_CRS_189> LoopCRS { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SSE))]
    public class Loop_SSE_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Entry and Exit Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        // Degree Record
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DEG DEG { get; set; }
        /// <summary>
        // Field of Study
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<FOS> FOS { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SST))]
    public class Loop_SST_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Student Academic Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SST SST { get; set; }
        /// <summary>
        // Entry and Exit Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual COM COM { get; set; }
        /// <summary>
        // Academic Summary
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<SUM> SUM { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual MSG MSG { get; set; }
        [DataMember]
        [ListCount(20)]
        [Pos(9)]
        public virtual List<Loop_SES_189_2> LoopSES { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TST))]
    public class Loop_TST_189
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Test Score Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TST TST { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_SBT_189> LoopSBT { get; set; }
    }
    
    /// <summary>
    // Application for Admission to Educational Institutions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "189")]
    public class TS189 : EdiMessage
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
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Loop_N1_189> LoopN1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(4)]
        public virtual List<Loop_REF_189> LoopREF { get; set; }
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_IN1_189> LoopIN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_ATV_189> LoopATV { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual Loop_LS_189 LoopLS { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_SSE_189> LoopSSE { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual Loop_LQ_189 LoopLQ { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_RSD_189> LoopRSD { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_RQS_189> LoopRQS { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_SST_189> LoopSST { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_TST_189> LoopTST { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(14)]
        public virtual List<Loop_PCL_189> LoopPCL { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual Loop_LX_189 LoopLX { get; set; }
        [DataMember]
        [ListCount(15)]
        [Pos(16)]
        public virtual List<Loop_LT_189> LoopLT { get; set; }
    }
}
