namespace EdiFabric.Templates.X12007020
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
    [Group(typeof(ACT))]
    public class Loop_ACT_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ACT ACT { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_LM_821> LoopLM { get; set; }
        [DataMember]
        [ListCount(13)]
        [Pos(4)]
        public virtual List<Loop_RTE_821> LoopRTE { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_BLN_821> LoopBLN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_TSU_821> LoopTSU { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_FIR_821> LoopFIR { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(BLN))]
    public class Loop_BLN_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Balance Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BLN BLN { get; set; }
        /// <summary>
        // Funds Availability
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AVA> AVA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT ENT { get; set; }
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<Loop_N1_821> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_ACT_821> LoopACT { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_FA1_821> LoopFA1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FA1 FA1 { get; set; }
        /// <summary>
        // Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<FA2> FA2 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FIR))]
    public class Loop_FIR_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Financial Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FIR FIR { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        // Funds Availability
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AVA> AVA { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        // Rate Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<RTE> RTE { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_NM1_821> LoopNM1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<Loop_LQ_821> LoopLQ { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_821
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_821
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_821
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTE))]
    public class Loop_RTE_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Rate Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RTE RTE { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TSU))]
    public class Loop_TSU_821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TSU TSU { get; set; }
        /// <summary>
        // Funds Availability
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AVA> AVA { get; set; }
    }
    
    /// <summary>
    // Financial Information Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "821")]
    public class TS821 : EdiMessage
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
        // Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<TRN> TRN { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_LM_821> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_FA1_821> LoopFA1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_ENT_821> LoopENT { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
