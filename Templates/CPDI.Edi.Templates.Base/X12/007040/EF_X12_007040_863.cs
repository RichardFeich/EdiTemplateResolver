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
    [Group(typeof(CID))]
    public class Loop_CID_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CID CID { get; set; }
        /// <summary>
        // Unit Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual UIT UIT { get; set; }
        /// <summary>
        // Physical Sample Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PSD> PSD { get; set; }
        /// <summary>
        // Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<SPS> SPS { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_MEA_863_3> LoopMEA { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_STA_863> LoopSTA { get; set; }
        [DataMember]
        [ListCount(100)]
        [Pos(10)]
        public virtual List<Loop_TMD_863> LoopTMD { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_TSP_863> LoopTSP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL HL { get; set; }
        /// <summary>
        // Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        // Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        // Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CID CID { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Test Method
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<TMD> TMD { get; set; }
        /// <summary>
        // Physical Sample Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<PSD> PSD { get; set; }
        /// <summary>
        // Test Period or Interval
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual TSP TSP { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        // Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<SPS> SPS { get; set; }
        /// <summary>
        // Statistics
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<STA> STA { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<Loop_LM_863> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<Loop_NM1_863> LoopNM1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        // Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        // Test Method
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        // Physical Sample Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PSD> PSD { get; set; }
        /// <summary>
        // Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<SPS> SPS { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(9)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_MEA_863> LoopMEA { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_N1_863_2> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_CID_863> LoopCID { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_863
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
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_LM_863> LoopLM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_863_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_LM_863> LoopLM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_863
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
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_PER_863> LoopPER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_863_2
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
        [ListCount(10)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_863
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Unit Detail
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual UIT UIT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PER))]
    public class Loop_PER_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PER PER { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(STA))]
    public class Loop_STA_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Statistics
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual STA STA { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_LM_863> LoopLM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TMD))]
    public class Loop_TMD_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Test Method
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TSP))]
    public class Loop_TSP_863
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Test Period or Interval
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TSP TSP { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_LM_863> LoopLM { get; set; }
    }
    
    /// <summary>
    // Report of Test Results
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "863")]
    public class TS863 : EdiMessage
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
        // Beginning Segment for Test Results
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BTR BTR { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(6)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        // Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        // Test Method
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual TMD TMD { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_MEA_863> LoopMEA { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_N1_863> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_LIN_863> LoopLIN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_HL_863> LoopHL { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
