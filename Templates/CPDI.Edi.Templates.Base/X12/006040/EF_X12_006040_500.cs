namespace EdiFabric.Templates.X12006040
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
    [Group(typeof(HL))]
    public class Loop_HL_500
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
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_LM_500> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_LIN_500> LoopLIN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_NM1_500_2> LoopNM1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_500
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
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<TRN> TRN { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_500
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
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_LQ_500> LoopLQ { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_500
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
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MTX))]
    public class Loop_MTX_500
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_500
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<TRN> TRN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_LM_500> LoopLM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_500_2
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Demographic Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<DMG> DMG { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Paperwork
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<TRN> TRN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_QTY_500> LoopQTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_PID_500> LoopPID { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<Loop_MTX_500> LoopMTX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_500
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PID PID { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_500
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_LM_500> LoopLM { get; set; }
    }
    
    /// <summary>
    // Medical Event Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "500")]
    public class TS500 : EdiMessage
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
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_NM1_500> LoopNM1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_HL_500> LoopHL { get; set; }
        /// <summary>
        // Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
